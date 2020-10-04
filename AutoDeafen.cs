using AfvCompanion.Core;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AfvCompanion
{
    class AutoDeafen
    {
        public static bool run = false;
        public static float? appOriginalVol1 = null;
        public static float? appOriginalVol2 = null;
        public static float? appOriginalVol3 = null;
        public static float? appOriginalVol4 = null;
        public static float? appOriginalVol5 = null;

        public static int? AutoDeafenApplicationPid1 = null;
        public static int? AutoDeafenApplicationPid2 = null;
        public static int? AutoDeafenApplicationPid3 = null;
        public static int? AutoDeafenApplicationPid4 = null;
        public static int? AutoDeafenApplicationPid5 = null;

        public static void Toggle(object sender, EventArgs e)
        {
            if (run)
            {
                run = false;
                if (PushToDeafen.run == false && AutoVolume.run == false)
                {
                    Form1.btnDisableAll.BackColor = System.Drawing.Color.Empty;

                }
                try { AudioManager.SetApplicationVolume(AutoDeafenApplicationPid1, appOriginalVol1); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafenApplicationPid2, appOriginalVol2); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafenApplicationPid3, appOriginalVol3); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafenApplicationPid4, appOriginalVol4); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafenApplicationPid5, appOriginalVol5); }
                catch { }
                Form1.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
                Form1.btnAutoDeafenToggle.Text = "Start";
                AutoDeafenManager.mOutputTimer.Stop();
            }
            else if (run == false)
            {
                if (Form1.AutoDeafenApplication1 == "Undefined")
                {
                    var result = MessageBox.Show("Error: You must define one or more application to deafen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Form1.AutoDeafenApplicationName == "Undefined")
                {
                    var result = MessageBox.Show("Error: You must define a listener application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                run = true;

                try { AutoDeafenApplicationPid1 = Process.GetProcessesByName(Form1.AutoDeafenApplication1)[0].Id; }
                catch { }
                try { AutoDeafenApplicationPid2 = Process.GetProcessesByName(Form1.AutoDeafenApplication2)[0].Id; }
                catch { }
                try { AutoDeafenApplicationPid3 = Process.GetProcessesByName(Form1.AutoDeafenApplication3)[0].Id; }
                catch { }
                try { AutoDeafenApplicationPid4 = Process.GetProcessesByName(Form1.AutoDeafenApplication4)[0].Id; }
                catch { }
                try { AutoDeafenApplicationPid5 = Process.GetProcessesByName(Form1.AutoDeafenApplication5)[0].Id; }
                catch { }

                try { appOriginalVol1 = AudioManager.GetApplicationVolume(AutoDeafenApplicationPid1) / 100; }
                catch { }
                try { appOriginalVol2 = AudioManager.GetApplicationVolume(AutoDeafenApplicationPid1) / 100; }
                catch { }
                try { appOriginalVol3 = AudioManager.GetApplicationVolume(AutoDeafenApplicationPid3) / 100; }
                catch { }
                try { appOriginalVol4 = AudioManager.GetApplicationVolume(AutoDeafenApplicationPid4) / 100; }
                catch { }
                try { appOriginalVol5 = AudioManager.GetApplicationVolume(AutoDeafenApplicationPid5) / 100; }
                catch { }

                Debug.WriteLine(appOriginalVol1);
                Debug.WriteLine(appOriginalVol2);
                Debug.WriteLine(appOriginalVol3);
                Debug.WriteLine(appOriginalVol4);
                Debug.WriteLine(appOriginalVol5);


                Form1.btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                Form1.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                Form1.btnAutoDeafenToggle.Text = "Stop";
                AutoDeafenManager.mOutputTimer.Start();
            }
        }
    }
}
