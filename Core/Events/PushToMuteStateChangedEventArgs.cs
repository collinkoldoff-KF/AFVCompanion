using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfvCompanion.Core.Events
{
    public class PushToMuteStateChangedEventArgs : EventArgs
    {
        public bool Down { get; set; }
        public PushToMuteStateChangedEventArgs() { }
        public PushToMuteStateChangedEventArgs(bool down) : this()
        {
            Down = down;
        }
    }
}
