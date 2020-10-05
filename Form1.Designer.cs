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
            this.KeyPreview = true;
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
            this.btnDisableAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDisableAll.Clicked = false;
            this.btnDisableAll.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnDisableAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisableAll.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnDisableAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableAll.ForeColor = System.Drawing.Color.White;
            this.btnDisableAll.Location = new System.Drawing.Point(95, 19);
            this.btnDisableAll.Name = "btnSettings";
            this.btnDisableAll.Pushed = false;
            this.btnDisableAll.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnDisableAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisableAll.TabIndex = 4;
            this.btnDisableAll.Text = "Disable All";
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_click);
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
            this.pnlToolbar.Controls.Add(this.btnDisableAll);
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
            this.notifyIcon1.Text = "AFVCompanion";
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
            //this.tabControl.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.appListDropdown);
            this.tabPage1.Controls.Add(this.btnAppListRefresh);
            this.tabPage1.Controls.Add(this.btnPushToDeafenToggle);
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
            this.tabPage2.Controls.Add(this.appListDropdown2);
            this.tabPage2.Controls.Add(this.appListDropdown3);
            this.tabPage2.Controls.Add(this.appListDropdown4);
            this.tabPage2.Controls.Add(this.appListDropdown5);
            this.tabPage2.Controls.Add(this.appListDropdown6);
            this.tabPage2.Controls.Add(this.appListDropdown7);
            this.tabPage2.Controls.Add(this.btnAppListRefresh2);
            this.tabPage2.Controls.Add(this.btnAutoDeafenToggle);
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
            this.appListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown.ForeColor = Color.White;
            this.appListDropdown.Location = new System.Drawing.Point(10, 100);
            this.appListDropdown.Name = "appListDropdown";
            this.appListDropdown.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown.TabIndex = 0;
            this.appListDropdown.SelectedIndexChanged += new System.EventHandler(this.appListDropdown_SelectedIndexChanged);
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
            this.btnAppListRefresh.Location = new System.Drawing.Point(280, 100);
            this.btnAppListRefresh.Name = "autoDeafenToggle";
            this.btnAppListRefresh.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh.Size = new System.Drawing.Size(75, 20);
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
            this.btnPushToDeafenToggle.Location = new System.Drawing.Point(7, 352);
            this.btnPushToDeafenToggle.Name = "btnPushToDeafenToggle";
            this.btnPushToDeafenToggle.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPushToDeafenToggle.Size = new System.Drawing.Size(380, 50);
            this.btnPushToDeafenToggle.TabIndex = 0;
            this.btnPushToDeafenToggle.Text = "Start";
            this.btnPushToDeafenToggle.Click += new System.EventHandler(this.PushToDeafenToggle);
            #endregion
            #region page2 items
            // 
            // appListDropdown2
            //
            this.appListDropdown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown2.ForeColor = Color.White;
            this.appListDropdown2.Location = new System.Drawing.Point(10, 10);
            this.appListDropdown2.Name = "appListDropdown2";
            this.appListDropdown2.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown2.TabIndex = 0;
            this.appListDropdown2.SelectedIndexChanged += new System.EventHandler(this.appListDropdown2_SelectedIndexChanged);
            // 
            // appListDropdown3
            //
            this.appListDropdown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown3.ForeColor = Color.White;
            this.appListDropdown3.Location = new System.Drawing.Point(10, 35);
            this.appListDropdown3.Name = "appListDropdown3";
            this.appListDropdown3.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown3.TabIndex = 0;
            this.appListDropdown3.SelectedIndexChanged += new System.EventHandler(this.appListDropdown3_SelectedIndexChanged);
            // 
            // appListDropdown4
            //
            this.appListDropdown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown4.ForeColor = Color.White;
            this.appListDropdown4.Location = new System.Drawing.Point(10, 60);
            this.appListDropdown4.Name = "appListDropdown4";
            this.appListDropdown4.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown4.TabIndex = 0;
            this.appListDropdown4.SelectedIndexChanged += new System.EventHandler(this.appListDropdown4_SelectedIndexChanged);
            // 
            // appListDropdown5
            //
            this.appListDropdown5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown5.ForeColor = Color.White;
            this.appListDropdown5.Location = new System.Drawing.Point(10, 85);
            this.appListDropdown5.Name = "appListDropdown5";
            this.appListDropdown5.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown5.TabIndex = 0;
            this.appListDropdown5.SelectedIndexChanged += new System.EventHandler(this.appListDropdown5_SelectedIndexChanged);
            // 
            // appListDropdown6
            //
            this.appListDropdown6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown6.ForeColor = Color.White;
            this.appListDropdown6.Location = new System.Drawing.Point(10, 110);
            this.appListDropdown6.Name = "appListDropdown6";
            this.appListDropdown6.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown6.TabIndex = 0;
            this.appListDropdown6.SelectedIndexChanged += new System.EventHandler(this.appListDropdown6_SelectedIndexChanged);
            // 
            // appListDropdown7
            //
            this.appListDropdown7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.appListDropdown7.ForeColor = Color.White;
            this.appListDropdown7.Location = new System.Drawing.Point(10, 135);
            this.appListDropdown7.Name = "appListDropdown7";
            this.appListDropdown7.Size = new System.Drawing.Size(264, 25);
            this.appListDropdown7.TabIndex = 0;
            this.appListDropdown7.SelectedIndexChanged += new System.EventHandler(this.appListDropdown7_SelectedIndexChanged);
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
            this.btnAppListRefresh2.Location = new System.Drawing.Point(280, 100);
            this.btnAppListRefresh2.Name = "autoDeafenToggle";
            this.btnAppListRefresh2.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAppListRefresh2.Size = new System.Drawing.Size(75, 20);
            this.btnAppListRefresh2.TabIndex = 0;
            this.btnAppListRefresh2.Text = "Refresh";
            this.btnAppListRefresh2.Click += new System.EventHandler(this.audioDevices);
            // 
            // autoDeafenToggle
            //
            this.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAutoDeafenToggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAutoDeafenToggle.Clicked = false;
            this.btnAutoDeafenToggle.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAutoDeafenToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoDeafenToggle.DisabledTextColor = System.Drawing.Color.DarkGray;
            this.btnAutoDeafenToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDeafenToggle.ForeColor = System.Drawing.Color.White;
            this.btnAutoDeafenToggle.Location = new System.Drawing.Point(7, 352);
            this.btnAutoDeafenToggle.Name = "autoDeafenToggle";
            this.btnAutoDeafenToggle.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnAutoDeafenToggle.Size = new System.Drawing.Size(380, 50);
            this.btnAutoDeafenToggle.TabIndex = 0;
            this.btnAutoDeafenToggle.Text = "Start";
            this.btnAutoDeafenToggle.Click += new System.EventHandler(AutoDeafenToggle);
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

        private System.Windows.Forms.ComboBox appListDropdown;
        private System.Windows.Forms.ComboBox appListDropdown2;
        private System.Windows.Forms.ComboBox appListDropdown3;
        private System.Windows.Forms.ComboBox appListDropdown4;
        private System.Windows.Forms.ComboBox appListDropdown5;
        private System.Windows.Forms.ComboBox appListDropdown6;
        private System.Windows.Forms.ComboBox appListDropdown7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}