using AfvCompanion.Config;
using AfvCompanion.Core;
using Appccelerate.EventBroker;
using Ninject;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AfvCompanion
{
    static class Program
    {
        public const string VERSION = "V0.1.0";
        private static string AppPath;

        [STAThread]
        static void Main()
        {
            //if (Environment.OSVersion.Version.Major & gt;= 6)
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string configFilePath = Path.Combine(AppPath, "AppConfig.json");

            IKernel kernel = new StandardKernel(new InjectionModules());
            IAppConfig config = kernel.Get<IAppConfig>();

            IEventBroker broker = kernel.Get<IEventBroker>();
            _ = new PtmManager(broker, config);
            PtmManager.mPtmTimer.Stop();
            _ = new AutoDeafenManager(broker, config);
            AutoDeafenManager.mOutputTimer.Stop();

            try
            {
                config.LoadConfig(configFilePath);
            }
            catch (FileNotFoundException)
            {
                config.SaveConfig();
            }
            catch (Exception)
            {
                config.SaveConfig();
                MessageBox.Show("Error loading configuration file. The configuration file has become corrupt and will be reset to the default settings.", "Error Loading Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                config.AppPath = AppPath;
            }

            Application.Run(new Form1());
            kernel.Dispose();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
