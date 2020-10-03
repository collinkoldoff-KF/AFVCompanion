using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using AsyncIO;

namespace AfvCompanion
{
    class AudioManager
    {
        public static void audioDevices(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();

            Form1.appListDropdown.Items.Clear();

            foreach (Process process in processlist)
            {
                if (GetApplicationVolume(process.Id) != null)
                {
                    Form1.appListDropdown.Items.Add(process.ProcessName);
                }
            }
            try
            {
                Form1.appListDropdown.SelectedIndex = Form1.appListDropdown.Items.IndexOf(Form1.PTMApplicationName);
            }
            catch
            {
                Form1.appListDropdown.SelectedIndex = 0;
            }
            
        }
        public static float? GetApplicationVolume(int pid)
        {
            ISimpleAudioVolume volume = GetVolumeObject(pid);
            if (volume == null)
                return null;

            float level;
            volume.GetMasterVolume(out level);
            Marshal.ReleaseComObject(volume);
            return level * 100;
        }
        private static ISimpleAudioVolume GetVolumeObject(int pid)
        {
            // get the speakers (1st render + multimedia) device
            IMMDeviceEnumerator deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
            IMMDevice speakers;
            deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

            // activate the session manager. we need the enumerator
            Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
            object o;
            speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out o);
            IAudioSessionManager2 mgr = (IAudioSessionManager2)o;

            // enumerate sessions for on this device
            IAudioSessionEnumerator sessionEnumerator;
            mgr.GetSessionEnumerator(out sessionEnumerator);
            int count;
            sessionEnumerator.GetCount(out count);

            // search for an audio session with the required name
            // NOTE: we could also use the process id instead of the app name (with IAudioSessionControl2)
            ISimpleAudioVolume volumeControl = null;
            for (int i = 0; i < count; i++)
            {
                IAudioSessionControl2 ctl;
                sessionEnumerator.GetSession(i, out ctl);
                int cpid;
                ctl.GetProcessId(out cpid);

                if (cpid == pid)
                {
                    volumeControl = ctl as ISimpleAudioVolume;
                    break;
                }
                Marshal.ReleaseComObject(ctl);
            }
            Marshal.ReleaseComObject(sessionEnumerator);
            Marshal.ReleaseComObject(mgr);
            Marshal.ReleaseComObject(speakers);
            Marshal.ReleaseComObject(deviceEnumerator);
            return volumeControl;
        }
        public static void SetApplicationMute(int pid, bool? mute)
        {
            if (mute == null) return;
            {
                IMMDeviceEnumerator deviceEnumerator = null;
                IAudioSessionEnumerator sessionEnumerator = null;
                IAudioSessionManager2 mgr = null;
                IMMDevice speakers = null;
                try
                {
                    // get the speakers (1st render + multimedia) device
                    deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
                    deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

                    // activate the session manager. we need the enumerator
                    Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
                    object o;
                    speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out o);
                    mgr = (IAudioSessionManager2)o;

                    // enumerate sessions for on this device
                    mgr.GetSessionEnumerator(out sessionEnumerator);
                    int count;
                    sessionEnumerator.GetCount(out count);

                    // search for an audio session with the required process-id
                    ISimpleAudioVolume volumeControl = null;
                    for (int i = 0; i < count; ++i)
                    {
                        IAudioSessionControl2 ctl = null;
                        try
                        {
                            sessionEnumerator.GetSession(i, out ctl);

                            // NOTE: we could also use the app name from ctl.GetDisplayName()
                            int cpid;
                            ctl.GetProcessId(out cpid);

                            if (cpid == pid)
                            {
                                Guid guid = Guid.Empty;
                                volumeControl = ctl as ISimpleAudioVolume;
                                volumeControl.SetMute(Convert.ToBoolean(mute), ref guid);
                            }
                        }
                        finally
                        {
                            if (ctl != null) Marshal.ReleaseComObject(ctl);
                        }
                    }
                }
                finally
                {
                    if (speakers != null) Marshal.ReleaseComObject(speakers);
                    if (mgr != null) Marshal.ReleaseComObject(mgr);
                    if (sessionEnumerator != null) Marshal.ReleaseComObject(sessionEnumerator);
                    if (deviceEnumerator != null) Marshal.ReleaseComObject(deviceEnumerator);
                }
            }
        }
    }
    [ComImport]
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    internal class MMDeviceEnumerator
    {
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
