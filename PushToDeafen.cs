using AfvCompanion.Core;
using System;

namespace AfvCompanion
{
    class PushToDeafen
    {
        public static bool run = false;

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
