using System;
using System.Drawing;
using System.Windows.Forms;

namespace AfvCompanion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.KeyPreview = true;
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new AfvCompanion.TransparentClickLabel();
            Form1.appListDropdown = new System.Windows.Forms.ComboBox();
            Form1.btnAutoDeafenToggle = new AfvCompanion.FlatButton();
            Form1.btnAppListRefresh = new AfvCompanion.FlatButton();
            Form1.btnPushToDeafenToggle = new AfvCompanion.FlatButton();
            this.btnClose = new AfvCompanion.FlatButton();
            Form1.btnDisableAll = new AfvCompanion.FlatButton();
            this.btnMinimize = new AfvCompanion.FlatButton();
            this.btnSettings = new AfvCompanion.FlatButton();
            this.btnSetPTM = new AfvCompanion.FlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTabs = new AfvCompanion.TransparentClickPanel();
            this.tabControl = new AfvCompanion.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlToolbar = new AfvCompanion.TransparentClickPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            #region menuBar
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimize.Clicked = false;
            this.btnMinimize.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMinimize.Location = new System.Drawing.Point(534, 19);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Pushed = false;
            this.btnMinimize.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnMinimize.Size = new System.Drawing.Size(20, 23);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "–";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(94)))), ((int)(((byte)(57)))));
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Clicked = false;
            this.btnClose.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(560, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Pushed = false;
            this.btnClose.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Size = new System.Drawing.Size(20, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSettings.Clicked = false;
            this.btnSettings.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(10, 19);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Pushed = false;
            this.btnSettings.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            // 
            // btnDisableAll
            // 
            Form1.btnDisableAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            Form1.btnDisableAll.Clicked = false;
            Form1.btnDisableAll.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnDisableAll.Cursor = System.Windows.Forms.Cursors.Hand;
            Form1.btnDisableAll.DisabledTextColor = System.Drawing.Color.DarkGray;
            Form1.btnDisableAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Form1.btnDisableAll.ForeColor = System.Drawing.Color.White;
            Form1.btnDisableAll.Location = new System.Drawing.Point(95, 19);
            Form1.btnDisableAll.Name = "btnSettings";
            Form1.btnDisableAll.Pushed = false;
            Form1.btnDisableAll.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnDisableAll.Size = new System.Drawing.Size(75, 23);
            Form1.btnDisableAll.TabIndex = 4;
            Form1.btnDisableAll.Text = "Disable All";
            Form1.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_click);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BorderColor = System.Drawing.Color.Empty;
            this.label.Font = new System.Drawing.Font("Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label.HasBorder = false;
            this.label.Location = new System.Drawing.Point(175, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 15);
            this.label.TabIndex = 5;
            this.label.Text = "AFV Companion";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.pnlToolbar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlToolbar.Controls.Add(this.btnSettings);
            this.pnlToolbar.Controls.Add(Form1.btnDisableAll);
            this.pnlToolbar.Controls.Add(this.label);
            this.pnlToolbar.Controls.Add(this.btnMinimize);
            this.pnlToolbar.Controls.Add(this.btnClose);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(600, 60);
            this.pnlToolbar.TabIndex = 1;
            #endregion
            #region notifyIcon
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "systemTrayElement";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(168, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Open Application";
            this.toolStripMenuItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem1_MouseClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem2_MouseClick);
            #endregion
            #region tabs
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabs.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTabs.Controls.Add(this.tabControl);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Padding = new System.Windows.Forms.Padding(0);
            this.pnlTabs.Size = new System.Drawing.Size(400, 500);
            this.pnlTabs.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(132, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(580, 380);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(Form1.appListDropdown);
            this.tabPage1.Controls.Add(Form1.btnAppListRefresh);
            this.tabPage1.Controls.Add(Form1.btnPushToDeafenToggle);
            this.tabPage1.Controls.Add(this.btnSetPTM);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(572, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Push To Deafen";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabPage2.Controls.Add(Form1.btnAutoDeafenToggle);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(572, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto Deafen";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(572, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Auto Volume";
            #endregion
            #region page1 items
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(PushToDeafen.toggle);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(175, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 82);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.assignPTM_click);
            // 
            // btnSetPTM
            // 
            this.btnSetPTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSetPTM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSetPTM.Clicked = false;
            this.btnSetPTM.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSetPTM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetPTM.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnSetPTM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPTM.ForeColor = System.Drawing.Color.White;
            this.btnSetPTM.Location = new System.Drawing.Point(10, 130);
            this.btnSetPTM.Name = "btnSetPTM";
            this.btnSetPTM.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSetPTM.Size = new System.Drawing.Size(264, 22);
            this.btnSetPTM.TabIndex = 0;
            this.btnSetPTM.Text = "Set New PTT Key or Button";
            this.btnSetPTM.Click += new System.EventHandler(this.assignPTM_click);
            // 
            // appListDropdown
            //
            Form1.appListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            //Form1.appListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //Form1.appListDropdown.FormattingEnabled = true;
            Form1.appListDropdown.ForeColor = Color.White;
            Form1.appListDropdown.Location = new System.Drawing.Point(10, 100);
            Form1.appListDropdown.Name = "appListDropdown";
            Form1.appListDropdown.Size = new System.Drawing.Size(264, 25);
            Form1.appListDropdown.TabIndex = 0;
            Form1.appListDropdown.SelectedIndexChanged += new System.EventHandler(this.appListDropdown_SelectedIndexChanged);
            // 
            // btnAppListRefresh
            //
            Form1.btnAppListRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            Form1.btnAppListRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            Form1.btnAppListRefresh.Clicked = false;
            Form1.btnAppListRefresh.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnAppListRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            Form1.btnAppListRefresh.DisabledTextColor = System.Drawing.Color.DarkGray;
            Form1.btnAppListRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Form1.btnAppListRefresh.ForeColor = System.Drawing.Color.White;
            Form1.btnAppListRefresh.Location = new System.Drawing.Point(280, 100);
            Form1.btnAppListRefresh.Name = "autoDeafenToggle";
            Form1.btnAppListRefresh.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnAppListRefresh.Size = new System.Drawing.Size(75, 20);
            Form1.btnAppListRefresh.TabIndex = 0;
            Form1.btnAppListRefresh.Text = "Refresh";
            Form1.btnAppListRefresh.Click += new System.EventHandler(AudioManager.audioDevices);
            // 
            // btnPushToDeafenToggle
            //
            Form1.btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            Form1.btnPushToDeafenToggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            Form1.btnPushToDeafenToggle.Clicked = false;
            Form1.btnPushToDeafenToggle.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnPushToDeafenToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            Form1.btnPushToDeafenToggle.DisabledTextColor = System.Drawing.Color.DarkGray;
            Form1.btnPushToDeafenToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Form1.btnPushToDeafenToggle.ForeColor = System.Drawing.Color.White;
            Form1.btnPushToDeafenToggle.Location = new System.Drawing.Point(7, 352);
            Form1.btnPushToDeafenToggle.Name = "btnPushToDeafenToggle";
            Form1.btnPushToDeafenToggle.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnPushToDeafenToggle.Size = new System.Drawing.Size(380, 50);
            Form1.btnPushToDeafenToggle.TabIndex = 0;
            Form1.btnPushToDeafenToggle.Text = "Start";
            Form1.btnPushToDeafenToggle.Click += new System.EventHandler(PushToDeafen.toggle);
            #endregion
            #region page2 items
            // 
            // autoDeafenToggle
            //
            Form1.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            Form1.btnAutoDeafenToggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            Form1.btnAutoDeafenToggle.Clicked = false;
            Form1.btnAutoDeafenToggle.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnAutoDeafenToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            Form1.btnAutoDeafenToggle.DisabledTextColor = System.Drawing.Color.DarkGray;
            Form1.btnAutoDeafenToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Form1.btnAutoDeafenToggle.ForeColor = System.Drawing.Color.White;
            Form1.btnAutoDeafenToggle.Location = new System.Drawing.Point(7, 352);
            Form1.btnAutoDeafenToggle.Name = "autoDeafenToggle";
            Form1.btnAutoDeafenToggle.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            Form1.btnAutoDeafenToggle.Size = new System.Drawing.Size(380, 50);
            Form1.btnAutoDeafenToggle.TabIndex = 0;
            Form1.btnAutoDeafenToggle.Text = "Start";
            Form1.btnAutoDeafenToggle.Click += new System.EventHandler(AutoDeafen.toggle);
            #endregion
            #region page3 items

            #endregion
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenu1.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Focus();
        }

        #endregion
        public static System.Windows.Forms.ComboBox appListDropdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public static FlatButton btnAutoDeafenToggle;
        public static FlatButton btnAppListRefresh;
        public static FlatButton btnPushToDeafenToggle;
        private FlatButton btnClose;
        public static FlatButton btnDisableAll;
        private FlatButton btnMinimize;
        private FlatButton btnSettings;
        private FlatButton btnSetPTM;
        private TransparentClickLabel label;
        private ContextMenuStrip contextMenu1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private TransparentClickPanel pnlTabs;
        private TransparentClickPanel pnlToolbar;
        private CustomTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}