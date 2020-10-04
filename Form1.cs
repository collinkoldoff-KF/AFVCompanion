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
        public static string PTMApplicationName = "Undefined";
        public static string AutoDeafenApplicationName = "Undefined";
        public static string AutoDeafenApplication1 = "Undefined";
        public static string AutoDeafenApplication2 = "None";
        public static string AutoDeafenApplication3 = "None";
        public static string AutoDeafenApplication4 = "None";
        public static string AutoDeafenApplication5 = "None";

        private readonly IAppConfig mConfig;
        private readonly DirectInput mDirectInput;
        private readonly List<Joystick> mPtmDevices = new List<Joystick>();
        private readonly Timer mPtmDevicePollTimer;
        private readonly List<PTMConfiguration> mIgnoreList = new List<PTMConfiguration>();
        private PTMConfiguration mNewPtmConfiguration;
        private bool mScanning;

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
            AudioManager.audioDevices(null, null);
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
            mConfig.PTMApplication = appListDropdown.SelectedItem.ToString();
            mConfig.SaveConfig();
            PTMApplicationPid = Process.GetProcessesByName(appListDropdown.SelectedItem.ToString())[0].Id;
        }

        private void appListDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication = appListDropdown2.SelectedItem.ToString();
                mConfig.SaveConfig();
                //PTMApplicationPid = Process.GetProcessesByName(appListDropdown2.SelectedItem.ToString())[0].Id;
            }
            catch { }
        }
        private void appListDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication1 = appListDropdown3.SelectedItem.ToString();
                mConfig.SaveConfig();
                //PTMApplicationPid = Process.GetProcessesByName(appListDropdown3.SelectedItem.ToString())[0].Id;
            }
            catch { }
        }
        private void appListDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication2 = appListDropdown4.SelectedItem.ToString();
                mConfig.SaveConfig();
                //PTMApplicationPid = Process.GetProcessesByName(appListDropdown4.SelectedItem.ToString())[0].Id;
            } 
            catch { }
        }
        private void appListDropdown5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication3 = appListDropdown5.SelectedItem.ToString();
                mConfig.SaveConfig();
                //PTMApplicationPid = Process.GetProcessesByName(appListDropdown5.SelectedItem.ToString())[0].Id;
            }
            catch { }
        }
        private void appListDropdown6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication4 = appListDropdown6.SelectedItem.ToString();
                mConfig.SaveConfig();
                //PTMApplicationPid = Process.GetProcessesByName(appListDropdown6.SelectedItem.ToString())[0].Id;
            }
            catch { }
        }
        private void appListDropdown7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mConfig.LoadConfig();
                mConfig.AutoDeafenApplication5 = appListDropdown7.SelectedItem.ToString();
                mConfig.SaveConfig();
                //PTMApplicationPid = Process.GetProcessesByName(appListDropdown7.SelectedItem.ToString())[0].Id;
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mNewPtmConfiguration = mConfig.PTMConfiguration;
            if (appListDropdown.SelectedItem != null)
                PTMApplicationPid = Process.GetProcessesByName(appListDropdown.SelectedItem.ToString())[0].Id;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                Focus();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
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
            this.WindowState = FormWindowState.Normal;
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
            //tabControl.SelectedTab.ForeColor = Color.Silver;
            //tabControl.Refresh();
        }
        private void btnDisableAll_click(object sender, EventArgs e)
        {
            PushToDeafen.run = false;
            AutoDeafen.run = false;
            AutoVolume.run = false;
            PushToDeafen.unMuteApplication();
            btnDisableAll.BackColor = System.Drawing.Color.Empty;
            btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            btnPushToDeafenToggle.Text = "Start";
            btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            btnAutoDeafenToggle.Text = "Start";
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
                if (mNewPttConfiguration != null)
                {
                    mIgnoreList.Add(mNewPttConfiguration);
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
                //lblPTTValue.Text = "Waiting for button or key press...";
            }
            else
            {
                if (mNewPtmConfiguration != null)
                {
                    btnSetPTM.Text = "Set a Different PTM Key or Button";
                    btnSetPTM.Text = mNewPtmConfiguration.ToString();
                }
                else
                {
                    btnSetPTM.Text = "Set New PTM Key or Button";
                    //lblPTTValue.Text = mConfig.PTTConfiguration.ToString();
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

            PtmManager ptmManager = new PtmManager(broker, mConfig);
        }
        public void ReloadAutoDeafenManager()
        {
            IKernel kernel = new StandardKernel(new InjectionModules());
            IEventBroker broker = kernel.Get<IEventBroker>();

            mConfig.LoadConfig();

            AutoDeafenManager autoDeafenManager = new AutoDeafenManager(broker, mConfig);
        }
    }
}
