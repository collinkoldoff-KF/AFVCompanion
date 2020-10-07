using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AfvCompanion
{
    class AudioManager
    {
        public static float? GetApplicationVolume(int? pid)
        {
            if (pid == null)
                return null;
            ISimpleAudioVolume volume = GetVolumeObject(pid);
            if (volume == null)
                return null;

            volume.GetMasterVolume(out float level);
            Marshal.ReleaseComObject(volume);
            return level * 100;
        }
        private static ISimpleAudioVolume GetVolumeObject(int? pid)
        {
            IMMDeviceEnumerator deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
            deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out IMMDevice speakers);

            Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
            speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out object o);
            IAudioSessionManager2 mgr = (IAudioSessionManager2)o;

            mgr.GetSessionEnumerator(out IAudioSessionEnumerator sessionEnumerator);
            sessionEnumerator.GetCount(out int count);

            ISimpleAudioVolume volumeControl = null;
            for (int i = 0; i < count; i++)
            {
                sessionEnumerator.GetSession(i, out IAudioSessionControl2 ctl);
                ctl.GetProcessId(out int cpid);

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
                    deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
                    deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

                    Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
                    speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out object o);
                    mgr = (IAudioSessionManager2)o;

                    mgr.GetSessionEnumerator(out sessionEnumerator);
                    sessionEnumerator.GetCount(out int count);

                    ISimpleAudioVolume volumeControl = null;
                    for (int i = 0; i < count; ++i)
                    {
                        IAudioSessionControl2 ctl = null;
                        try
                        {
                            sessionEnumerator.GetSession(i, out ctl);

                            ctl.GetProcessId(out int cpid);

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
                catch
                {

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
        public static void SetApplicationVolume(int? pid, float? volume)
        {
            if (pid == null || volume == null)
                return;
            IMMDeviceEnumerator deviceEnumerator = null;
            IAudioSessionEnumerator sessionEnumerator = null;
            IAudioSessionManager2 mgr = null;
            IMMDevice speakers = null;
            try
            {
                deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
                deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

                Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
                speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out object o);
                mgr = (IAudioSessionManager2)o;

                mgr.GetSessionEnumerator(out sessionEnumerator);
                sessionEnumerator.GetCount(out int count);

                ISimpleAudioVolume volumeControl = null;
                for (int i = 0; i < count; ++i)
                {
                    IAudioSessionControl2 ctl = null;
                    try
                    {
                        sessionEnumerator.GetSession(i, out ctl);

                        ctl.GetProcessId(out int cpid);

                        if (cpid == pid)
                        {
                            Guid guid = Guid.Empty;
                            volumeControl = ctl as ISimpleAudioVolume;
                            volumeControl.SetMasterVolume((float)volume, ref guid);
                        }
                    }
                    finally
                    {
                        if (ctl != null) Marshal.ReleaseComObject(ctl);
                    }
                }
            }
            catch
            {
                Debug.WriteLine("Major Error");
                // If it gets to this point something is very wrong
            }
            finally
            {
                if (speakers != null) Marshal.ReleaseComObject(speakers);
                if (mgr != null) Marshal.ReleaseComObject(mgr);
                if (sessionEnumerator != null) Marshal.ReleaseComObject(sessionEnumerator);
                if (deviceEnumerator != null) Marshal.ReleaseComObject(deviceEnumerator);
            }
        }
        public static class MMDeviceEnumeratorFactory
        {
            private static readonly Guid MMDeviceEnumerator = new Guid("BCDE0395-E52F-467C-8E3D-C4579291692E");

            public static IMMDeviceEnumerator CreateInstance()
            {
                var type = Type.GetTypeFromCLSID(MMDeviceEnumerator);
                return (IMMDeviceEnumerator)Activator.CreateInstance(type);
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

    [ComImport]
    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
