using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using AfvCompanion.Config;
using AfvCompanion.Core;
using Appccelerate.EventBroker;
using Ninject;

namespace AfvCompanion
{
    static class Program
    {
        private static string AppPath;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string configFilePath = Path.Combine(AppPath, "AppConfig.json");

            IKernel kernel = new StandardKernel(new InjectionModules());
            IAppConfig config = kernel.Get<IAppConfig>();

            IEventBroker broker = kernel.Get<IEventBroker>();
            PtmManager ptmManager = new PtmManager(broker, config);

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
    }
}
