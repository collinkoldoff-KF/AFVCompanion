﻿using AfvCompanion.Config;
using Appccelerate.EventBroker;
using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AfvCompanion.Core
{
    class AutoDeafenManager : EventBus, IAutoDeafenManager
    {
        private readonly IAppConfig mConfig;
        private readonly System.Windows.Forms.Timer mOutputTimer;
        private bool mOutput;

        public AutoDeafenManager(IEventBroker broker, IAppConfig config) : base(broker)
        {
            mOutputTimer = new System.Windows.Forms.Timer
            {
                Interval = 10
            };
            mOutputTimer.Tick += PtmTimer_Tick;
            OnSessionStarted(null, null);
        }

        public static bool GetProcessSoundOutput(int pid)
        {
            using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            {
                using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                {
                    foreach (var session in sessionEnumerator)
                    {
                        using (var audioMeterInformation = session.QueryInterface<AudioMeterInformation>())
                        using (var session2 = session.QueryInterface<AudioSessionControl2>())
                        {
                            if (session2.ProcessID == pid)
                            {
                                if (audioMeterInformation.GetPeakValue() > 0.00)
                                {
                                    return true;
                                }
                            } 
                        }
                    }
                }
            }
            return false;
        }

        private void PtmTimer_Tick(object sender, EventArgs e)
        {
            CheckOutput();
        }

        private void CheckOutput()
        {
            bool output = Task.Run(() => GetProcessSoundOutput(20880)).Result;

            if (output != mOutput)
            {
                if (AutoDeafen.run)
                {
                    mOutput = output;
                    Debug.WriteLine("OUTPUT YAY!!!");
                    // Output code
                }
            }
        }
        public void OnSessionStarted(object sender, EventArgs e)
        {
            mOutputTimer.Start();
        }

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (CSCore.CoreAudioAPI.MMDeviceEnumerator enumerator = new CSCore.CoreAudioAPI.MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    //Debug.WriteLine("DefaultDevice: " + device.FriendlyName);
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }
    }

    internal enum EDataFlow
    {
        eRender,
        eCapture,
        eAll,
        EDataFlow_enum_count
    }

    internal enum ERole
    {
        eConsole,
        eMultimedia,
        eCommunications,
        ERole_enum_count
    }

    [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ISimpleAudioVolume
    {
        [PreserveSig]
        int SetMasterVolume(float fLevel, ref Guid EventContext);

        [PreserveSig]
        int GetMasterVolume(out float pfLevel);

        [PreserveSig]
        int SetMute(bool bMute, ref Guid EventContext);

        [PreserveSig]
        int GetMute(out bool pbMute);
    }

    [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionManager2
    {
        int NotImpl1();
        int NotImpl2();

        [PreserveSig]
        int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

        // the rest is not implemented
    }

    [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionEnumerator
    {
        [PreserveSig]
        int GetCount(out int SessionCount);

        [PreserveSig]
        int GetSession(int SessionCount, out IAudioSessionControl2 Session);
    }

    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDeviceEnumerator
    {
        int NotImpl1();

        [PreserveSig]
        int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppDevice);

        // the rest is not implemented
    }

    [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDevice
    {
        [PreserveSig]
        int Activate(ref Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);

        // the rest is not implemented
    }

    [Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionControl2
    {
        // IAudioSessionControl
        [PreserveSig]
        int NotImpl0();

        [PreserveSig]
        int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int SetDisplayName([MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int GetIconPath([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int SetIconPath([MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int GetGroupingParam(out Guid pRetVal);

        [PreserveSig]
        int SetGroupingParam([MarshalAs(UnmanagedType.LPStruct)] Guid Override, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int NotImpl1();

        [PreserveSig]
        int NotImpl2();

        // IAudioSessionControl2
        [PreserveSig]
        int GetSessionIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int GetSessionInstanceIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int GetProcessId(out int pRetVal);

        [PreserveSig]
        int IsSystemSoundsSession();

        [PreserveSig]
        int SetDuckingPreference(bool optOut);
    }
}
