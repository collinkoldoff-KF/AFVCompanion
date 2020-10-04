using System;

namespace AfvCompanion
{
    class AutoVolume
    {
        public static bool run = false;
        public static void toggle(object sender, EventArgs e)
        {
            if (run)
            {
                run = false;
                if (AutoDeafen.run == false && PushToDeafen.run == false)
                {
                    Form1.btnDisableAll.BackColor = System.Drawing.Color.Empty;
                }
            }
            else if (run == false)
            {
                run = true;
                Form1.btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            }

        }
    }
}
