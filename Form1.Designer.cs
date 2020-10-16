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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolbarLabel = new AfvCompanion.TransparentClickLabel();
            this.ptmAppListDropdown = new System.Windows.Forms.ComboBox();
            this.autoDeafenListenerDropdown1 = new System.Windows.Forms.ComboBox();
            this.autoDeafenAppDropdown1 = new System.Windows.Forms.ComboBox();
            this.autoDeafenAppDropdown2 = new System.Windows.Forms.ComboBox();
            this.autoDeafenAppDropdown3 = new System.Windows.Forms.ComboBox();
            this.autoDeafenAppDropdown4 = new System.Windows.Forms.ComboBox();
            this.autoDeafenAppDropdown5 = new System.Windows.Forms.ComboBox();
            this.btnAutoDeafenToggle = new AfvCompanion.FlatButton();
            this.btnAppListRefresh = new AfvCompanion.FlatButton();
            this.btnPushToDeafenToggle = new AfvCompanion.FlatButton();
            this.btnAppListRefresh2 = new AfvCompanion.FlatButton();
            this.btnClose = new AfvCompanion.FlatButton();
            this.btnDisableAll = new AfvCompanion.FlatButton();
            this.btnMinimize = new AfvCompanion.FlatButton();
            this.btnSettings = new AfvCompanion.FlatButton();
            this.btnSetPTM = new AfvCompanion.FlatButton();
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTabs = new AfvCompanion.TransparentClickPanel();
            this.tabControl = new AfvCompanion.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptmBtnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.appVolume = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlToolbar = new AfvCompanion.TransparentClickPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenu1.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appVolume)).BeginInit();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarLabel
            // 
            this.toolbarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarLabel.AutoSize = true;
            this.toolbarLabel.BorderColor = System.Drawing.Color.Empty;
            this.toolbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toolbarLabel.HasBorder = false;
            this.toolbarLabel.Location = new System.Drawing.Point(150, 20);
            this.toolbarLabel.Name = "toolbarLabel";
            this.toolbarLabel.Size = new System.Drawing.Size(106, 16);
            this.toolbarLabel.TabIndex = 5;
            this.toolbarLabel.Text = "AFV Companion";
            this.toolbarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptmAppListDropdown
            // 
            this.ptmAppListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ptmAppListDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ptmAppListDropdown.ForeColor = System.Drawing.Color.White;
            this.ptmAppListDropdown.Location = new System.Drawing.Point(9, 20);
            this.ptmAppListDropdown.Name = "ptmAppListDropdown";
            this.ptmAppListDropdown.Size = new System.Drawing.Size(227, 21);
            this.ptmAppListDropdown.TabIndex = 0;
            this.ptmAppListDropdown.SelectedIndexChanged += new System.EventHandler(this.appListDropdown_SelectedIndexChanged);
            // 
            // autoDeafenListenerDropdown1
            // 
            this.autoDeafenListenerDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.autoDeafenListenerDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoDeafenListenerDropdown1.ForeColor = System.Drawing.Color.White;
            this.autoDeafenListenerDropdown1.Location = new System.Drawing.Point(9, 27);
            this.autoDeafenListenerDropdown1.Name = "autoDeafenListenerDropdown1";
            this.autoDeafenListenerDropdown1.Size = new System.Drawing.Size(227, 21);
            this.autoDeafenListenerDropdown1.TabIndex = 0;
            this.autoDeafenListenerDropdown1.SelectedIndexChanged += new System.EventHandler(this.appListDropdown2_SelectedIndexChanged);
            // 
            // autoDeafenAppDropdown1
            // 
            this.autoDeafenAppDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.autoDeafenAppDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoDeafenAppDropdown1.ForeColor = System.Drawing.Color.White;
            this.autoDeafenAppDropdown1.Location = new System.Drawing.Point(9, 71);
            this.autoDeafenAppDropdown1.Name = "autoDeafenAppDropdown1";
            this.autoDeafenAppDropdown1.Size = new System.Drawing.Size(227, 21);
            this.autoDeafenAppDropdown1.TabIndex = 0;
            this.autoDeafenAppDropdown1.SelectedIndexChanged += new System.EventHandler(this.appListDropdown3_SelectedIndexChanged);
            // 
            // autoDeafenAppDropdown2
            // 
            this.autoDeafenAppDropdown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.autoDeafenAppDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoDeafenAppDropdown2.ForeColor = System.Drawing.Color.White;
            this.autoDeafenAppDropdown2.Location = new System.Drawing.Point(9, 98);
            this.autoDeafenAppDropdown2.Name = "autoDeafenAppDropdown2";
            this.autoDeafenAppDropdown2.Size = new System.Drawing.Size(227, 21);
            this.autoDeafenAppDropdown2.TabIndex = 0;
            this.autoDeafenAppDropdown2.SelectedIndexChanged += new System.EventHandler(this.appListDropdown4_SelectedIndexChanged);
            // 
            // autoDeafenAppDropdown3
            // 
            this.autoDeafenAppDropdown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.autoDeafenAppDropdown3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoDeafenAppDropdown3.ForeColor = System.Drawing.Color.White;
            this.autoDeafenAppDropdown3.Location = new System.Drawing.Point(9, 125);
            this.autoDeafenAppDropdown3.Name = "autoDeafenAppDropdown3";
            this.autoDeafenAppDropdown3.Size = new System.Drawing.Size(227, 21);
            this.autoDeafenAppDropdown3.TabIndex = 0;
            this.autoDeafenAppDropdown3.SelectedIndexChanged += new System.EventHandler(this.appListDropdown5_SelectedIndexChanged);
            // 
            // autoDeafenAppDropdown4
            // 
            this.autoDeafenAppDropdown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.autoDeafenAppDropdown4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoDeafenAppDropdown4.ForeColor = System.Drawing.Color.White;
            this.autoDeafenAppDropdown4.Location = new System.Drawing.Point(9, 152);
            this.autoDeafenAppDropdown4.Name = "autoDeafenAppDropdown4";
            this.autoDeafenAppDropdown4.Size = new System.Drawing.Size(227, 21);
            this.autoDeafenAppDropdown4.TabIndex = 0;
            this.autoDeafenAppDropdown4.SelectedIndexChanged += new System.EventHandler(this.appListDropdown6_SelectedIndexChanged);
            // 
            // autoDeafenAppDropdown5
            // 
            this.autoDeafenAppDropdown5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.autoDeafenAppDropdown5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoDeafenAppDropdown5.ForeColor = System.Drawing.Color.White;
            this.autoDeafenAppDropdown5.Location = new System.Drawing.Point(9, 179);
            this.autoDeafenAppDropdown5.Name = "autoDeafenAppDropdown5";
            this.autoDeafenAppDropdown5.Size = new System.Drawing.Size(227, 21);
            this.autoDeafenAppDropdown5.TabIndex = 0;
            this.autoDeafenAppDropdown5.SelectedIndexChanged += new System.EventHandler(this.appListDropdown7_SelectedIndexChanged);
            // 
            // btnAutoDeafenToggle
            // 
            this.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAutoDeafenToggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAutoDeafenToggle.Clicked = false;
            this.btnAutoDeafenToggle.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAutoDeafenToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoDeafenToggle.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnAutoDeafenToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDeafenToggle.ForeColor = System.Drawing.Color.White;
            this.btnAutoDeafenToggle.Location = new System.Drawing.Point(6, 305);
            this.btnAutoDeafenToggle.Name = "btnAutoDeafenToggle";
            this.btnAutoDeafenToggle.Pushed = false;
            this.btnAutoDeafenToggle.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAutoDeafenToggle.Size = new System.Drawing.Size(326, 43);
            this.btnAutoDeafenToggle.TabIndex = 0;
            this.btnAutoDeafenToggle.Text = "Start";
            this.btnAutoDeafenToggle.Click += new System.EventHandler(this.AutoDeafenToggle);
            // 
            // btnAppListRefresh
            // 
            this.btnAppListRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAppListRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAppListRefresh.Clicked = false;
            this.btnAppListRefresh.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppListRefresh.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnAppListRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppListRefresh.ForeColor = System.Drawing.Color.White;
            this.btnAppListRefresh.Location = new System.Drawing.Point(240, 20);
            this.btnAppListRefresh.Name = "btnAppListRefresh";
            this.btnAppListRefresh.Pushed = false;
            this.btnAppListRefresh.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh.Size = new System.Drawing.Size(64, 21);
            this.btnAppListRefresh.TabIndex = 0;
            this.btnAppListRefresh.Text = "Refresh";
            this.btnAppListRefresh.Click += new System.EventHandler(this.audioDevices);
            // 
            // btnPushToDeafenToggle
            // 
            this.btnPushToDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPushToDeafenToggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPushToDeafenToggle.Clicked = false;
            this.btnPushToDeafenToggle.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPushToDeafenToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPushToDeafenToggle.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnPushToDeafenToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushToDeafenToggle.ForeColor = System.Drawing.Color.White;
            this.btnPushToDeafenToggle.Location = new System.Drawing.Point(6, 305);
            this.btnPushToDeafenToggle.Name = "btnPushToDeafenToggle";
            this.btnPushToDeafenToggle.Pushed = false;
            this.btnPushToDeafenToggle.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPushToDeafenToggle.Size = new System.Drawing.Size(326, 43);
            this.btnPushToDeafenToggle.TabIndex = 0;
            this.btnPushToDeafenToggle.Text = "Start";
            this.btnPushToDeafenToggle.Click += new System.EventHandler(this.PushToDeafenToggle);
            // 
            // btnAppListRefresh2
            // 
            this.btnAppListRefresh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAppListRefresh2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAppListRefresh2.Clicked = false;
            this.btnAppListRefresh2.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppListRefresh2.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnAppListRefresh2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppListRefresh2.ForeColor = System.Drawing.Color.White;
            this.btnAppListRefresh2.Location = new System.Drawing.Point(258, 27);
            this.btnAppListRefresh2.Name = "btnAppListRefresh2";
            this.btnAppListRefresh2.Pushed = false;
            this.btnAppListRefresh2.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh2.Size = new System.Drawing.Size(64, 21);
            this.btnAppListRefresh2.TabIndex = 0;
            this.btnAppListRefresh2.Text = "Refresh All";
            this.btnAppListRefresh2.Click += new System.EventHandler(this.audioDevices);
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
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(309, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Pushed = false;
            this.btnClose.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Size = new System.Drawing.Size(17, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDisableAll.Clicked = false;
            this.btnDisableAll.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnDisableAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisableAll.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnDisableAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableAll.ForeColor = System.Drawing.Color.White;
            this.btnDisableAll.Location = new System.Drawing.Point(81, 16);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Pushed = false;
            this.btnDisableAll.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnDisableAll.Size = new System.Drawing.Size(64, 20);
            this.btnDisableAll.TabIndex = 4;
            this.btnDisableAll.Text = "Disable All";
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimize.Clicked = false;
            this.btnMinimize.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMinimize.Location = new System.Drawing.Point(287, 16);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Pushed = false;
            this.btnMinimize.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnMinimize.Size = new System.Drawing.Size(17, 20);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "–";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnSettings.Location = new System.Drawing.Point(9, 16);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Pushed = false;
            this.btnSettings.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSettings.Size = new System.Drawing.Size(64, 20);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
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
            this.btnSetPTM.Location = new System.Drawing.Point(9, 71);
            this.btnSetPTM.Name = "btnSetPTM";
            this.btnSetPTM.Pushed = false;
            this.btnSetPTM.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSetPTM.Size = new System.Drawing.Size(226, 19);
            this.btnSetPTM.TabIndex = 0;
            this.btnSetPTM.Text = "Set New PTM Key or Button";
            this.btnSetPTM.Click += new System.EventHandler(this.assignPTM_click);
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
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabs.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTabs.Controls.Add(this.tabControl);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabs.Location = new System.Drawing.Point(0, 52);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(343, 381);
            this.pnlTabs.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(132, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(343, 381);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ptmBtnLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.ptmAppListDropdown);
            this.tabPage1.Controls.Add(this.btnAppListRefresh);
            this.tabPage1.Controls.Add(this.btnPushToDeafenToggle);
            this.tabPage1.Controls.Add(this.btnSetPTM);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(335, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Push To Deafen";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Push To Mute (PTM) Device Configuration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Push To Mute Application:";
            // 
            // ptmBtnLabel
            // 
            this.ptmBtnLabel.AutoSize = true;
            this.ptmBtnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptmBtnLabel.Location = new System.Drawing.Point(129, 93);
            this.ptmBtnLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ptmBtnLabel.Name = "ptmBtnLabel";
            this.ptmBtnLabel.Size = new System.Drawing.Size(37, 13);
            this.ptmBtnLabel.TabIndex = 3;
            this.ptmBtnLabel.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current PTM Assignment:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Auto Start";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.volumeLabel);
            this.tabPage2.Controls.Add(this.appVolume);
            this.tabPage2.Controls.Add(this.autoDeafenListenerDropdown1);
            this.tabPage2.Controls.Add(this.autoDeafenAppDropdown1);
            this.tabPage2.Controls.Add(this.autoDeafenAppDropdown2);
            this.tabPage2.Controls.Add(this.autoDeafenAppDropdown3);
            this.tabPage2.Controls.Add(this.autoDeafenAppDropdown4);
            this.tabPage2.Controls.Add(this.autoDeafenAppDropdown5);
            this.tabPage2.Controls.Add(this.btnAppListRefresh2);
            this.tabPage2.Controls.Add(this.btnAutoDeafenToggle);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(335, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto Deafen";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 273);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Auto Start";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(298, 228);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(27, 13);
            this.volumeLabel.TabIndex = 2;
            this.volumeLabel.Text = "20%";
            this.volumeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // appVolume
            // 
            this.appVolume.LargeChange = 10;
            this.appVolume.Location = new System.Drawing.Point(5, 228);
            this.appVolume.Maximum = 100;
            this.appVolume.Name = "appVolume";
            this.appVolume.Size = new System.Drawing.Size(295, 45);
            this.appVolume.SmallChange = 5;
            this.appVolume.TabIndex = 10;
            this.appVolume.TickFrequency = 10;
            this.appVolume.Value = 20;
            this.appVolume.Scroll += new System.EventHandler(this.appVolume_Scroll);
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
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.pnlToolbar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlToolbar.Controls.Add(this.btnSettings);
            this.pnlToolbar.Controls.Add(this.btnDisableAll);
            this.pnlToolbar.Controls.Add(this.toolbarLabel);
            this.pnlToolbar.Controls.Add(this.btnMinimize);
            this.pnlToolbar.Controls.Add(this.btnClose);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(343, 52);
            this.pnlToolbar.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AFVCompanion";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Auto Deafen Listener Application";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Auto Deafen Applications";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(343, 433);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenu1.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appVolume)).EndInit();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox ptmAppListDropdown;
        private System.Windows.Forms.ComboBox autoDeafenListenerDropdown1;
        private System.Windows.Forms.ComboBox autoDeafenAppDropdown1;
        private System.Windows.Forms.ComboBox autoDeafenAppDropdown2;
        private System.Windows.Forms.ComboBox autoDeafenAppDropdown3;
        private System.Windows.Forms.ComboBox autoDeafenAppDropdown4;
        private System.Windows.Forms.ComboBox autoDeafenAppDropdown5;
        private FlatButton btnAutoDeafenToggle;
        private FlatButton btnAppListRefresh;
        private FlatButton btnAppListRefresh2;
        private FlatButton btnPushToDeafenToggle;
        private FlatButton btnClose;
        private FlatButton btnDisableAll;
        private FlatButton btnMinimize;
        private FlatButton btnSettings;
        private FlatButton btnSetPTM;
        private TransparentClickLabel toolbarLabel;
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
        private TrackBar appVolume;
        private Label volumeLabel;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label ptmBtnLabel;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}