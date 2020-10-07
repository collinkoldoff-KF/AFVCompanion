using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace AfvCompanion.Config
{
    public enum PTMDeviceType
    {
        None,
        Keyboard,
        Joystick,
        Mouse
    }

    public class PTMConfiguration : IEquatable<PTMConfiguration>
    {
        private string mJoystickGuidString;
        private Guid mGuid;

        public PTMDeviceType DeviceType { get; set; }

        public string Name { get; set; }

        public int ButtonOrKey { get; set; }

        [JsonIgnore]
        public bool JoystickAcquired { get; set; }

        public Guid JoystickGuid
        {
            get
            {
                return mGuid;
            }
        }

        public string JoystickGuidString
        {
            get
            {
                return mJoystickGuidString;
            }
            set
            {
                mJoystickGuidString = value;
                if (!string.IsNullOrEmpty(value))
                {
                    mGuid = new Guid(value);
                }
            }
        }

        public override string ToString()
        {
            return DeviceType switch
            {
                PTMDeviceType.Keyboard => $"Keyboard { (Keys)ButtonOrKey }",
                PTMDeviceType.Joystick => $"Joystick Button { ButtonOrKey + 1 } on { Name }",
                PTMDeviceType.Mouse => $"Mouse Button { (MouseButtons)ButtonOrKey}",
                _ => "None",
            };
        }

        public bool Equals(PTMConfiguration other)
        {
            return
                (other != null) &&
                (other.DeviceType == DeviceType) &&
                (other.Name == Name) &&
                (other.JoystickGuidString == JoystickGuidString) &&
                (other.ButtonOrKey == ButtonOrKey);
        }
    }
}
