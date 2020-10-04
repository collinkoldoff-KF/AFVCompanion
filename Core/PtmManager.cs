using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AfvCompanion.Config;
using AfvCompanion.Core.Events;
using Appccelerate.EventBroker;
using Appccelerate.EventBroker.Handlers;
using SharpDX;
using SharpDX.DirectInput;

namespace AfvCompanion.Core
{
    class PtmManager : EventBus, IPtmManager
    {
        [EventPublication(EventTopics.PushToTalkStateChanged)]
        public event EventHandler<PushToMuteStateChangedEventArgs> PushToTalkStateChanged;

        private readonly IAppConfig mConfig;
        private readonly DirectInput mDirectInput;
        public static System.Windows.Forms.Timer mPtmTimer;
        private static PTMConfiguration mPtmConfiguration = new PTMConfiguration();
        private Joystick mJoystick;
        private bool mPtmStatus;

        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int state);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public PtmManager(IEventBroker broker, IAppConfig config) : base(broker)
        {
            mConfig = config;
            mDirectInput = new DirectInput();
            mPtmTimer = new System.Windows.Forms.Timer
            {
                Interval = 10
            };
            mPtmTimer.Tick += PtmTimer_Tick;
            OnSessionStarted(null, null);
        }

        private void PtmTimer_Tick(object sender, EventArgs e)
        {
            if (mPtmConfiguration.DeviceType == PTMDeviceType.Joystick && !mPtmConfiguration.JoystickAcquired)
            {
                AcquireJoystick();
            }
            CheckPtmDevice();
            if (PushToDeafen.run == false)
            {
                mPtmTimer.Stop();
            }
        }

        private void CheckPtmDevice()
        {
            bool isPressed = false;
            switch (mPtmConfiguration.DeviceType)
            {
                case PTMDeviceType.None:
                    isPressed = false;
                    break;
                case PTMDeviceType.Keyboard:
                    isPressed = (GetAsyncKeyState(mPtmConfiguration.ButtonOrKey) & 32768) > 0;
                    break;
                case PTMDeviceType.Joystick:
                    if (mJoystick != null && mPtmConfiguration.JoystickAcquired && mPtmConfiguration.ButtonOrKey >= 0)
                    {
                        try
                        {
                            JoystickState currentState = mJoystick.GetCurrentState();
                            bool[] buttons = currentState.Buttons;
                            try
                            {
                                isPressed = buttons[mPtmConfiguration.ButtonOrKey];
                            }
                            catch (IndexOutOfRangeException)
                            {
                            }
                        }
                        catch (SharpDXException)
                        {
                            mPtmConfiguration.JoystickAcquired = false;
                            if (mJoystick != null)
                            {
                                mJoystick.Unacquire();
                                mJoystick.Dispose();
                            }
                            mJoystick = null;
                        }
                    }
                    break;
                case PTMDeviceType.Mouse:
                    Keys key = intToXButton(mPtmConfiguration.ButtonOrKey);
                    isPressed = GetAsyncKeyState(key) != 0;
                    break;
            }
            
            if (isPressed != mPtmStatus)
            {
                mPtmStatus = isPressed;
                if (mPtmStatus)
                {
                    if (PushToDeafen.run)
                    PushToDeafen.muteApplication();
                } 
                else
                {
                    PushToDeafen.unMuteApplication();
                }

                PushToTalkStateChanged?.Invoke(this, new PushToMuteStateChangedEventArgs(mPtmStatus));
            }
        }

        private static Keys intToXButton(int id)
        {
            if (id == 8388608)
            {
                return Keys.XButton1;
            }
            else if (id == 16777216)
            {
                return Keys.XButton2;
            }
            return Keys.XButton2;
        }

        public static void UpdatePtmDevice()
        {
            mPtmConfiguration = new PTMConfiguration();
        }

        private void RemovePtmDevice(PTMConfiguration ptm)
        {
            if (mJoystick != null)
            {
                mJoystick.Unacquire();
                mJoystick.Dispose();
            }
            mJoystick = null;
            mPtmConfiguration = ptm;
            mPtmConfiguration.JoystickAcquired = false;
        }

        private void AcquireJoystick()
        {
            if (mDirectInput.IsDeviceAttached(mPtmConfiguration.JoystickGuid))
            {
                try
                {
                    mJoystick = new Joystick(mDirectInput, mPtmConfiguration.JoystickGuid);
                    mJoystick.Acquire();
                    mPtmConfiguration.JoystickAcquired = true;
                    return;
                }
                catch (SharpDXException)
                {
                    if (mJoystick != null)
                    {
                        mJoystick.Unacquire();
                        mJoystick.Dispose();
                    }
                    mJoystick = null;
                    return;
                }
            }
            mPtmConfiguration.JoystickAcquired = false;
            if (mJoystick != null)
            {
                mJoystick.Unacquire();
                mJoystick.Dispose();
            }
            mJoystick = null;
        }

        [EventSubscription(EventTopics.SessionStarted, typeof(OnUserInterfaceAsync))]
        public void OnSessionStarted(object sender, EventArgs e)
        {
            RemovePtmDevice(mConfig.PTMConfiguration);
            mPtmTimer.Start();
        }

        [EventSubscription(EventTopics.SessionEnded, typeof(OnUserInterfaceAsync))]
        public void OnSessionEnded(object sender, EventArgs e)
        {
            mPtmTimer.Stop();
        }

        [EventSubscription(EventTopics.ClientConfigChanged, typeof(OnUserInterfaceAsync))]
        public void OnClientConfigChanged(object sender, EventArgs e)
        {
            RemovePtmDevice(mConfig.PTMConfiguration);
        }
    }
}
