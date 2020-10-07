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
            this.label = new AfvCompanion.TransparentClickLabel();
            this.appListDropdown = new System.Windows.Forms.ComboBox();
            this.appListDropdown2 = new System.Windows.Forms.ComboBox();
            this.appListDropdown3 = new System.Windows.Forms.ComboBox();
            this.appListDropdown4 = new System.Windows.Forms.ComboBox();
            this.appListDropdown5 = new System.Windows.Forms.ComboBox();
            this.appListDropdown6 = new System.Windows.Forms.ComboBox();
            this.appListDropdown7 = new System.Windows.Forms.ComboBox();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.appVolume = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlToolbar = new AfvCompanion.TransparentClickPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.contextMenu1.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appVolume)).BeginInit();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BorderColor = System.Drawing.Color.Empty;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label.HasBorder = false;
            this.label.Location = new System.Drawing.Point(150, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 16);
            this.label.TabIndex = 5;
            this.label.Text = "AFV Companion";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // appListDropdown
            // 
            this.appListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown.ForeColor = System.Drawing.Color.White;
            this.appListDropdown.Location = new System.Drawing.Point(9, 87);
            this.appListDropdown.Name = "appListDropdown";
            this.appListDropdown.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown.TabIndex = 0;
            this.appListDropdown.SelectedIndexChanged += new System.EventHandler(this.appListDropdown_SelectedIndexChanged);
            // 
            // appListDropdown2
            // 
            this.appListDropdown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown2.ForeColor = System.Drawing.Color.White;
            this.appListDropdown2.Location = new System.Drawing.Point(9, 9);
            this.appListDropdown2.Name = "appListDropdown2";
            this.appListDropdown2.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown2.TabIndex = 0;
            this.appListDropdown2.SelectedIndexChanged += new System.EventHandler(this.appListDropdown2_SelectedIndexChanged);
            // 
            // appListDropdown3
            // 
            this.appListDropdown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown3.ForeColor = System.Drawing.Color.White;
            this.appListDropdown3.Location = new System.Drawing.Point(9, 30);
            this.appListDropdown3.Name = "appListDropdown3";
            this.appListDropdown3.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown3.TabIndex = 0;
            this.appListDropdown3.SelectedIndexChanged += new System.EventHandler(this.appListDropdown3_SelectedIndexChanged);
            // 
            // appListDropdown4
            // 
            this.appListDropdown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown4.ForeColor = System.Drawing.Color.White;
            this.appListDropdown4.Location = new System.Drawing.Point(9, 52);
            this.appListDropdown4.Name = "appListDropdown4";
            this.appListDropdown4.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown4.TabIndex = 0;
            this.appListDropdown4.SelectedIndexChanged += new System.EventHandler(this.appListDropdown4_SelectedIndexChanged);
            // 
            // appListDropdown5
            // 
            this.appListDropdown5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown5.ForeColor = System.Drawing.Color.White;
            this.appListDropdown5.Location = new System.Drawing.Point(9, 74);
            this.appListDropdown5.Name = "appListDropdown5";
            this.appListDropdown5.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown5.TabIndex = 0;
            this.appListDropdown5.SelectedIndexChanged += new System.EventHandler(this.appListDropdown5_SelectedIndexChanged);
            // 
            // appListDropdown6
            // 
            this.appListDropdown6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown6.ForeColor = System.Drawing.Color.White;
            this.appListDropdown6.Location = new System.Drawing.Point(9, 95);
            this.appListDropdown6.Name = "appListDropdown6";
            this.appListDropdown6.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown6.TabIndex = 0;
            this.appListDropdown6.SelectedIndexChanged += new System.EventHandler(this.appListDropdown6_SelectedIndexChanged);
            // 
            // appListDropdown7
            // 
            this.appListDropdown7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown7.ForeColor = System.Drawing.Color.White;
            this.appListDropdown7.Location = new System.Drawing.Point(9, 117);
            this.appListDropdown7.Name = "appListDropdown7";
            this.appListDropdown7.Size = new System.Drawing.Size(227, 21);
            this.appListDropdown7.TabIndex = 0;
            this.appListDropdown7.SelectedIndexChanged += new System.EventHandler(this.appListDropdown7_SelectedIndexChanged);
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
            this.btnAppListRefresh.Location = new System.Drawing.Point(240, 87);
            this.btnAppListRefresh.Name = "btnAppListRefresh";
            this.btnAppListRefresh.Pushed = false;
            this.btnAppListRefresh.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh.Size = new System.Drawing.Size(64, 20);
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
            this.btnAppListRefresh2.Location = new System.Drawing.Point(240, 87);
            this.btnAppListRefresh2.Name = "btnAppListRefresh2";
            this.btnAppListRefresh2.Pushed = false;
            this.btnAppListRefresh2.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh2.Size = new System.Drawing.Size(64, 17);
            this.btnAppListRefresh2.TabIndex = 0;
            this.btnAppListRefresh2.Text = "Refresh";
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
            this.btnSetPTM.Location = new System.Drawing.Point(9, 113);
            this.btnSetPTM.Name = "btnSetPTM";
            this.btnSetPTM.Pushed = false;
            this.btnSetPTM.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSetPTM.Size = new System.Drawing.Size(226, 19);
            this.btnSetPTM.TabIndex = 0;
            this.btnSetPTM.Text = "Set New PTT Key or Button";
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
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.appListDropdown);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Auto Run";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.appVolume);
            this.tabPage2.Controls.Add(this.appListDropdown2);
            this.tabPage2.Controls.Add(this.appListDropdown3);
            this.tabPage2.Controls.Add(this.appListDropdown4);
            this.tabPage2.Controls.Add(this.appListDropdown5);
            this.tabPage2.Controls.Add(this.appListDropdown6);
            this.tabPage2.Controls.Add(this.appListDropdown7);
            this.tabPage2.Controls.Add(this.btnAppListRefresh2);
            this.tabPage2.Controls.Add(this.btnAutoDeafenToggle);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(335, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto Deafen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "20%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // appVolume
            // 
            this.appVolume.LargeChange = 10;
            this.appVolume.Location = new System.Drawing.Point(9, 163);
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
            this.pnlToolbar.Controls.Add(this.label);
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 247);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Auto Run";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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

        private System.Windows.Forms.ComboBox appListDropdown;
        private System.Windows.Forms.ComboBox appListDropdown2;
        private System.Windows.Forms.ComboBox appListDropdown3;
        private System.Windows.Forms.ComboBox appListDropdown4;
        private System.Windows.Forms.ComboBox appListDropdown5;
        private System.Windows.Forms.ComboBox appListDropdown6;
        private System.Windows.Forms.ComboBox appListDropdown7;
        private FlatButton btnAutoDeafenToggle;
        private FlatButton btnAppListRefresh;
        private FlatButton btnAppListRefresh2;
        private FlatButton btnPushToDeafenToggle;
        private FlatButton btnClose;
        private FlatButton btnDisableAll;
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
        private TrackBar appVolume;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}