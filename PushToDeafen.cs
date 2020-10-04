using AfvCompanion.Core;
using System;

namespace AfvCompanion
{
    class PushToDeafen
    {
        public static bool run = false;

        public static void toggle(object sender, EventArgs e)
        {
            if (run)
            {
                run = false;
                if (AutoDeafen.run == false && AutoVolume.run == false)
                {
                    Form1.btnDisableAll.BackColor = System.Drawing.Color.Empty;

                }
                Form1.btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
                Form1.btnPushToDeafenToggle.Text = "Start";
                PtmManager.mPtmTimer.Stop();
            }
            else if (run == false)
            {
                run = true;
                Form1.btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                Form1.btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                Form1.btnPushToDeafenToggle.Text = "Stop";
                PtmManager.mPtmTimer.Start();
            }
        }
        public static void muteApplication()
        {
            AudioManager.SetApplicationMute(Form1.PTMApplicationPid, true);
        }

        public static void unMuteApplication()
        {
            AudioManager.SetApplicationMute(Form1.PTMApplicationPid, false);
        }
    }
}
