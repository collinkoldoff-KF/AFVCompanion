using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using AfvCompanion.Config;
using SharpDX.DirectInput;
using AfvCompanion.Core;
using Ninject;
using Appccelerate.EventBroker;
using Castle.Core.Internal;
using System.Drawing.Text;

namespace AfvCompanion
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static int PTMApplicationPid;
        public static int AutoDeafenApplicationPid;
        public static string PTMApplicationName = "Undefined";
        public static string AutoDeafenApplicationName = "Undefined";
        public static string AutoDeafenApplication1 = "Undefined";
        public static string AutoDeafenApplication2 = "None";
        public static string AutoDeafenApplication3 = "None";
        public static string AutoDeafenApplication4 = "None";
        public static string AutoDeafenApplication5 = "None";

        public static bool AutoDeafenAutoRunStarted = false;

        private readonly IAppConfig mConfig;
        private readonly DirectInput mDirectInput;
        private readonly List<Joystick> mPtmDevices = new List<Joystick>();
        private readonly Timer mPtmDevicePollTimer;
        private readonly List<PTMConfiguration> mIgnoreList = new List<PTMConfiguration>();
        private PTMConfiguration mNewPtmConfiguration;
        private bool mScanning;
        private bool firstAudioScan = true;

        private Process[] processlist;

        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int value);

        public Form1()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new InjectionModules());
            IAppConfig appConfig = kernel.Get<IAppConfig>();
            mConfig = appConfig;
            mConfig.LoadConfig();
            mDirectInput = new DirectInput();
            mPtmDevicePollTimer = new Timer
            {
                Interval = 50
            };
            mPtmDevicePollTimer.Tick += PtmDevicePollTimer_Tick;
            PTMApplicationName = mConfig.PTMApplication;
            AutoDeafenApplicationName = mConfig.AutoDeafenApplication;
            AutoDeafenApplication1 = mConfig.AutoDeafenApplication1;
            AutoDeafenApplication2 = mConfig.AutoDeafenApplication2;
            AutoDeafenApplication3 = mConfig.AutoDeafenApplication3;
            AutoDeafenApplication4 = mConfig.AutoDeafenApplication4;
            AutoDeafenApplication5 = mConfig.AutoDeafenApplication5;
            appVolume.Value = (int)(mConfig.AppVolume * 100);
            volumeLabel.Text = appVolume.Value + "%";
            checkBox1.Checked = mConfig.PTMAutoRun;
            checkBox2.Checked = mConfig.AutoDeafenAutoRun;
            ptmBtnLabel.Text = mConfig.PTMConfiguration.ToString();
            if (mConfig.PTMAutoRun)
                PushToDeafenToggle(null, null);
            if (mConfig.AutoDeafenAutoRun)
            {
                AutoDeafenAutoRunStarted = true;
                AutoDeafenToggle(null, null);
            }
            audioDevices(null, null);
            firstAudioScan = false;
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void appListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            mConfig.LoadConfig();
            mConfig.PTMApplication = ptmAppListDropdown.SelectedItem.ToString();
            mConfig.SaveConfig();

            foreach (Process process in Process.GetProcessesByName(ptmAppListDropdown.SelectedItem.ToString()))
            {
                if (AudioManager.GetApplicationVolume(process.Id) != null)
                {
                    if (process.ProcessName == ptmAppListDropdown.SelectedItem.ToString())
                    {
                        PTMApplicationPid = process.Id;
                    }
                }
            }
        }

        private void appListDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mConfig.LoadConfig();
            mConfig.AutoDeafenApplication = autoDeafenListenerDropdown1.SelectedItem.ToString();
            mConfig.SaveConfig();
            if (AutoDeafen.run)
                AutoDeafenToggle(null, null);
            foreach (Process process in Process.GetProcessesByName(autoDeafenListenerDropdown1.SelectedItem.ToString()))
            {
                if (AudioManager.GetApplicationVolume(process.Id) != null)
                {
                    if (process.ProcessName == autoDeafenListenerDropdown1.SelectedItem.ToString())
                    {
                        AutoDeafenApplicationPid = process.Id;
                    }
                }
            }
        }
        private void appListDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication1 = autoDeafenAppDropdown1.SelectedItem.ToString();
                AutoDeafenApplication1 = autoDeafenAppDropdown1.SelectedItem.ToString();
                mConfig.SaveConfig();
                if (AutoDeafen.run)
                    AutoDeafenToggle(null, null);
                foreach (Process process in Process.GetProcessesByName(autoDeafenAppDropdown1.SelectedItem.ToString()))
                {
                    if (AudioManager.GetApplicationVolume(process.Id) != null)
                    {
                        if (process.ProcessName == autoDeafenAppDropdown1.SelectedItem.ToString())
                        {
                            AutoDeafen.AutoDeafenApplicationPid1 = process.Id;
                        }
                    }
                }
            }
            catch { }
        }
        private void appListDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication2 = autoDeafenAppDropdown2.SelectedItem.ToString();
                AutoDeafenApplication2 = autoDeafenAppDropdown2.SelectedItem.ToString();
                mConfig.SaveConfig();
                if (AutoDeafen.run)
                    AutoDeafenToggle(null, null);
                foreach (Process process in Process.GetProcessesByName(autoDeafenAppDropdown2.SelectedItem.ToString()))
                {
                    if (AudioManager.GetApplicationVolume(process.Id) != null)
                    {
                        if (process.ProcessName == autoDeafenAppDropdown2.SelectedItem.ToString())
                        {
                            AutoDeafen.AutoDeafenApplicationPid2 = process.Id;
                        }
                    }
                }
            } 
            catch { }
        }
        private void appListDropdown5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication3 = autoDeafenAppDropdown3.SelectedItem.ToString();
                AutoDeafenApplication3 = autoDeafenAppDropdown3.SelectedItem.ToString();
                mConfig.SaveConfig();
                if (AutoDeafen.run)
                    AutoDeafenToggle(null, null);
                foreach (Process process in Process.GetProcessesByName(autoDeafenAppDropdown3.SelectedItem.ToString()))
                {
                    if (AudioManager.GetApplicationVolume(process.Id) != null)
                    {
                        if (process.ProcessName == autoDeafenAppDropdown3.SelectedItem.ToString())
                        {
                            AutoDeafen.AutoDeafenApplicationPid3 = process.Id;
                        }
                    }
                }
            }
            catch { }
        }
        private void appListDropdown6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication4 = autoDeafenAppDropdown4.SelectedItem.ToString();
                AutoDeafenApplication4 = autoDeafenAppDropdown4.SelectedItem.ToString();
                mConfig.SaveConfig();
                if (AutoDeafen.run)
                    AutoDeafenToggle(null, null);
                foreach (Process process in Process.GetProcessesByName(autoDeafenAppDropdown4.SelectedItem.ToString()))
                {
                    if (AudioManager.GetApplicationVolume(process.Id) != null)
                    {
                        if (process.ProcessName == autoDeafenAppDropdown4.SelectedItem.ToString())
                        {
                            AutoDeafen.AutoDeafenApplicationPid4 = process.Id;
                        }
                    }
                }
            }
            catch { }
        }
        private void appListDropdown7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication5 = autoDeafenAppDropdown5.SelectedItem.ToString();
                AutoDeafenApplication5 = autoDeafenAppDropdown5.SelectedItem.ToString();
                mConfig.SaveConfig();
                if (AutoDeafen.run)
                    AutoDeafenToggle(null, null);
                foreach (Process process in Process.GetProcessesByName(autoDeafenAppDropdown5.SelectedItem.ToString()))
                {
                    if (AudioManager.GetApplicationVolume(process.Id) != null)
                    {
                        if (process.ProcessName == autoDeafenAppDropdown5.SelectedItem.ToString())
                        {
                            AutoDeafen.AutoDeafenApplicationPid5 = process.Id;
                        }
                    }
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mNewPtmConfiguration = mConfig.PTMConfiguration;
            if (ptmAppListDropdown.SelectedItem != null)
            {
                foreach (Process process in Process.GetProcessesByName(ptmAppListDropdown.SelectedItem.ToString()))
                {
                    if (AudioManager.GetApplicationVolume(process.Id) != null)
                    {
                        if (process.ProcessName == ptmAppListDropdown.SelectedItem.ToString())
                        {
                            PTMApplicationPid = process.Id;
                        }
                    }
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                Focus();
                WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnDisableAll_click(null, null);
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            Focus();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void toolStripMenuItem2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnDisableAll_click(object sender, EventArgs e)
        {
            AutoVolume.run = false;
            PushToDeafen.unMuteApplication();
            btnDisableAll.BackColor = System.Drawing.Color.Empty;
            if (PushToDeafen.run)
                PushToDeafenToggle(null, null);
            if (AutoDeafen.run)
                AutoDeafenToggle(null, null);
        }
        private void assignPTM_click(object sender, EventArgs e)
        {
            if (mScanning)
            {
                btnSetPTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
                StopScanning();
            }
            else
            {
                /*
                if (mNewPtmConfiguration != null)
                {
                    mIgnoreList.Add(mNewPtmConfiguration);
                }*/
                StartScanning();
            }
        }
        private void StartScanning()
        {
            btnSetPTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            mScanning = true;
            UpdateControls();
            AcquireDevices();
            IdentifyPressedButtons();
            mPtmDevicePollTimer.Start();
        }
        private void StopScanning()
        {
            btnSetPTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            mConfig.PTMConfiguration = mNewPtmConfiguration;
            mConfig.SaveConfig();
            mPtmDevicePollTimer.Stop();
            mScanning = false;
            UpdateControls();
            DisposeDevices();
            PtmManager.UpdatePtmDevice();
            ReloadPtmManager();
        }
        private void DisposeDevices()
        {
            if (mPtmDevices != null)
            {
                foreach (Joystick device in mPtmDevices)
                {
                    device.Dispose();
                }
                mPtmDevices.Clear();
            }
        }
        private void UpdateControls()
        {
            if (mScanning)
            {
                btnSetPTM.Text = "Cancel";
                ptmBtnLabel.Text = "Waiting for button or key press...";
            }
            else
            {
                if (mNewPtmConfiguration != null)
                {
                    btnSetPTM.Text = "Set New PTM Key or Button";
                    ptmBtnLabel.Text = mNewPtmConfiguration.ToString();
                }
                else
                {
                    btnSetPTM.Text = "Set New PTM Key or Button";
                    ptmBtnLabel.Text = mNewPtmConfiguration.ToString();
                }
            }
            Application.DoEvents();
        }

        private void PtmDevicePollTimer_Tick(object sender, EventArgs e)
        {
            ScanDevices();
        }

        private void AcquireDevices()
        {
            mPtmDevices.Clear();
            foreach (var deviceInstance in mDirectInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AllDevices))
            {
                if (mDirectInput.IsDeviceAttached(deviceInstance.InstanceGuid))
                {
                    Joystick device = new Joystick(mDirectInput, deviceInstance.InstanceGuid);
                    try
                    {
                        device.Acquire();
                        mPtmDevices.Add(device);
                    }
                    catch { }
                }
            }
        }

        private void IdentifyPressedButtons()
        {
            foreach (Joystick device in mPtmDevices)
            {
                try
                {
                    JoystickState state = device.GetCurrentState();
                    bool[] buttons = state.Buttons;
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        if (buttons[i])
                        {
                            mIgnoreList.Add(new PTMConfiguration()
                            {
                                DeviceType = PTMDeviceType.Joystick,
                                JoystickGuidString = device.Information.InstanceGuid.ToString(),
                                ButtonOrKey = i,
                                Name = device.Information.InstanceName
                            });
                        }
                    }
                }
                catch (SharpDX.SharpDXException) { }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mScanning)
                return;

            if (e.Button == MouseButtons.XButton1 || e.Button == MouseButtons.XButton2)
            {
                var config = new PTMConfiguration
                {
                    DeviceType = PTMDeviceType.Mouse,
                    ButtonOrKey = (int)e.Button,
                    Name = "Mouse"
                };

                if (mIgnoreList.Contains(config))
                    return;

                mNewPtmConfiguration = config;
                StopScanning();
            }
        }   
        
        private void ScanDevices()
        {
            foreach (Joystick device in mPtmDevices)
            {
                ScanDevice(device, out bool buttonPressDetected);
                if (buttonPressDetected)
                {
                    break;
                }
            }
        }

        private void ScanDevice(Joystick device, out bool buttonPressDetected)
        {
            buttonPressDetected = false;
            try
            {
                JoystickState state = device.GetCurrentState();
                bool[] buttons = state.Buttons;
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i])
                    {
                        PTMConfiguration config = new PTMConfiguration()
                        {
                            DeviceType = PTMDeviceType.Joystick,
                            JoystickGuidString = device.Information.InstanceGuid.ToString(),
                            ButtonOrKey = i,
                            Name = device.Information.InstanceName
                        };
                        if (mIgnoreList.Contains(config))
                        {
                            continue;
                        }
                        mNewPtmConfiguration = config;
                        buttonPressDetected = true;
                        StopScanning();
                        break;
                    }
                }
            }
            catch (SharpDX.SharpDXException) { }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (!mScanning)
                return;

            var config = new PTMConfiguration
            {
                DeviceType = PTMDeviceType.Keyboard,
                ButtonOrKey = (int)GetVirtualKey(e.KeyCode),
                Name = "Keyboard"
            };

            if (mIgnoreList.Contains(config))
                return;

            mNewPtmConfiguration = config;
            StopScanning();

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private Keys GetVirtualKey(Keys keyCode)
        {
            Keys key = Keys.Add;
            switch (keyCode)
            {
                case Keys.ControlKey:
                    if (0 != (GetAsyncKeyState((int)Keys.RControlKey) & 0x8000))
                    {
                        key = Keys.RControlKey;
                    }
                    else if (0 != (GetAsyncKeyState((int)Keys.LControlKey) & 0x8000))
                    {
                        key = Keys.LControlKey;
                    }
                    break;
                case Keys.Menu:
                    if (0 != (GetAsyncKeyState((int)Keys.RMenu) & 0x8000))
                    {
                        key = Keys.RMenu;
                    }
                    else if (0 != (GetAsyncKeyState((int)Keys.LMenu) & 0x8000))
                    {
                        key = Keys.LMenu;
                    }
                    break;
                case Keys.ShiftKey:
                    if (0 != (GetAsyncKeyState((int)Keys.RShiftKey) & 0x8000))
                    {
                        key = Keys.RShiftKey;
                    }
                    else if (0 != (GetAsyncKeyState((int)Keys.LShiftKey) & 0x8000))
                    {
                        key = Keys.LShiftKey;
                    }
                    break;
                default:
                    key = keyCode;
                    break;
            }
            return key;
        }
        public void ReloadPtmManager()
        {
            IKernel kernel = new StandardKernel(new InjectionModules());
            IEventBroker broker = kernel.Get<IEventBroker>();

            mConfig.LoadConfig();
            _ = new PtmManager(broker, mConfig);
        }
        public void ReloadAutoDeafenManager()
        {
            IKernel kernel = new StandardKernel(new InjectionModules());
            IEventBroker broker = kernel.Get<IEventBroker>();

            mConfig.LoadConfig();
            _ = new AutoDeafenManager(broker, mConfig);
        }
        public void audioDevices(object sender, EventArgs e)
        {
            GetProcesses();
            ptmAppListDropdown.Items.Clear();
            autoDeafenListenerDropdown1.Items.Clear();
            autoDeafenAppDropdown1.Items.Clear();
            autoDeafenAppDropdown2.Items.Clear();
            autoDeafenAppDropdown3.Items.Clear();
            autoDeafenAppDropdown4.Items.Clear();
            autoDeafenAppDropdown5.Items.Clear();

            autoDeafenListenerDropdown1.Items.Add("Undefined");
            autoDeafenAppDropdown1.Items.Add("Undefined");
            autoDeafenAppDropdown2.Items.Add("None");
            autoDeafenAppDropdown3.Items.Add("None");
            autoDeafenAppDropdown4.Items.Add("None");
            autoDeafenAppDropdown5.Items.Add("None");


            foreach (Process process in processlist)
            {
                if (AudioManager.GetApplicationVolume(process.Id) != null)
                {
                    //Debug.WriteLine(process.ProcessName + " # " + process.Id);
                    ptmAppListDropdown.Items.Add(process.ProcessName);
                    autoDeafenListenerDropdown1.Items.Add(process.ProcessName);
                    autoDeafenAppDropdown1.Items.Add(process.ProcessName);
                    autoDeafenAppDropdown2.Items.Add(process.ProcessName);
                    autoDeafenAppDropdown3.Items.Add(process.ProcessName);
                    autoDeafenAppDropdown4.Items.Add(process.ProcessName);
                    autoDeafenAppDropdown5.Items.Add(process.ProcessName);
                }
            }
            if (firstAudioScan) {
                try { ptmAppListDropdown.SelectedIndex = ptmAppListDropdown.Items.IndexOf(PTMApplicationName); }
                catch { ptmAppListDropdown.SelectedIndex = 0; }
                try { autoDeafenListenerDropdown1.SelectedIndex = autoDeafenListenerDropdown1.Items.IndexOf(AutoDeafenApplicationName); }
                catch { autoDeafenListenerDropdown1.SelectedIndex = 0; }
                try { autoDeafenAppDropdown1.SelectedIndex = autoDeafenAppDropdown1.Items.IndexOf(AutoDeafenApplication1); }
                catch { autoDeafenAppDropdown1.SelectedIndex = 0; }
                try { autoDeafenAppDropdown2.SelectedIndex = autoDeafenAppDropdown2.Items.IndexOf(AutoDeafenApplication2); }
                catch { autoDeafenAppDropdown2.SelectedIndex = 0; }
                try { autoDeafenAppDropdown3.SelectedIndex = autoDeafenAppDropdown3.Items.IndexOf(AutoDeafenApplication3); }
                catch { autoDeafenAppDropdown3.SelectedIndex = 0; }
                try { autoDeafenAppDropdown4.SelectedIndex = autoDeafenAppDropdown4.Items.IndexOf(AutoDeafenApplication4); }
                catch { autoDeafenAppDropdown4.SelectedIndex = 0; }
                try { autoDeafenAppDropdown5.SelectedIndex = autoDeafenAppDropdown5.Items.IndexOf(AutoDeafenApplication5); }
                catch { autoDeafenAppDropdown5.SelectedIndex = 0; }
            }
        }
        public void PushToDeafenToggle(object sender, EventArgs e)
        {
            if (PushToDeafen.run)
            {
                PushToDeafen.run = false;
                if (AutoDeafen.run == false && AutoVolume.run == false)
                {
                    btnDisableAll.BackColor = System.Drawing.Color.Empty;
                }
                btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
                btnPushToDeafenToggle.Text = "Start";
                PtmManager.mPtmTimer.Stop();
            }
            else if (PushToDeafen.run == false)
            {
                PushToDeafen.run = true;
                btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                btnPushToDeafenToggle.Text = "Stop";
                PtmManager.mPtmTimer.Start();
            }
        }
        public void AutoDeafenToggle(object sender, EventArgs e)
        {
            if (AutoDeafen.run)
            {
                AutoDeafen.run = false;
                if (PushToDeafen.run == false && AutoVolume.run == false)
                {
                    btnDisableAll.BackColor = System.Drawing.Color.Empty;

                }
                try { AudioManager.SetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid1, AutoDeafen.appOriginalVol1); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid2, AutoDeafen.appOriginalVol2); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid3, AutoDeafen.appOriginalVol3); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid4, AutoDeafen.appOriginalVol4); }
                catch { }
                try { AudioManager.SetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid5, AutoDeafen.appOriginalVol5); }
                catch { }
                btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
                btnAutoDeafenToggle.Text = "Start";
                AutoDeafenManager.mOutputTimer.Stop();
            }
            else if (AutoDeafen.run == false)
            {
                if (AutoDeafenApplication1 == "Undefined")
                {
                    if (AutoDeafenAutoRunStarted)
                    {
                        AutoDeafenAutoRunStarted = false;
                        checkBox2.Checked = false;
                        return;
                    }
                    MessageBox.Show("Error: You must define one or more application to deafen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AutoDeafenApplicationName == "Undefined")
                {
                    if (AutoDeafenAutoRunStarted)
                    {
                        AutoDeafenAutoRunStarted = false;
                        checkBox2.Checked = false;
                        return;
                    }
                    MessageBox.Show("Error: You must define a listener application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AutoDeafen.run = true;

                try { AutoDeafen.appOriginalVol1 = AudioManager.GetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid1) / 100; }
                catch { }
                try { AutoDeafen.appOriginalVol2 = AudioManager.GetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid2) / 100; }
                catch { }
                try { AutoDeafen.appOriginalVol3 = AudioManager.GetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid3) / 100; }
                catch { }
                try { AutoDeafen.appOriginalVol4 = AudioManager.GetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid4) / 100; }
                catch { }
                try { AutoDeafen.appOriginalVol5 = AudioManager.GetApplicationVolume(AutoDeafen.AutoDeafenApplicationPid5) / 100; }
                catch { }


                btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                btnAutoDeafenToggle.Text = "Stop";
                AutoDeafenManager.mOutputTimer.Start();
                AutoDeafenManager.mOutput = false;
            }
        }
        public void AutoVolumeToggle(object sender, EventArgs e)
        {
            if (AutoVolume.run)
            {
                AutoVolume.run = false;
                if (AutoDeafen.run == false && PushToDeafen.run == false)
                {
                    btnDisableAll.BackColor = System.Drawing.Color.Empty;
                }
            }
            else if (AutoVolume.run == false)
            {
                AutoVolume.run = true;
                btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            }
        }
        public void GetProcesses()
        {
            processlist = Process.GetProcesses();
        }

        private void appVolume_Scroll(object sender, EventArgs e)
        {
            mConfig.AppVolume = (float)appVolume.Value / 100;
            volumeLabel.Text = appVolume.Value + "%";
            mConfig.SaveConfig();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mConfig.PTMAutoRun = checkBox1.Checked;
            mConfig.SaveConfig();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mConfig.AutoDeafenAutoRun = checkBox2.Checked;
            mConfig.SaveConfig();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
