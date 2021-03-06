﻿namespace ArkController
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLogSave = new System.Windows.Forms.Button();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.textBoxSendText = new System.Windows.Forms.TextBox();
            this.openFileDialogInstall = new System.Windows.Forms.OpenFileDialog();
            this.listViewPackage = new System.Windows.Forms.ListView();
            this.columnHeaderPackageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.PToolStripMenuItemPackageInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPackageDump = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKillAllProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogcat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHideApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUnhideApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPullApk = new System.Windows.Forms.ToolStripMenuItem();
            this.PToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUninstall = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPackageList = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.toolStripKibot = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxDeviceList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRestartAdb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.tabControlHomePage = new System.Windows.Forms.TabControl();
            this.tabPageDeviceInfo = new System.Windows.Forms.TabPage();
            this.tabPageKeyboard = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonVolumeUp = new System.Windows.Forms.Button();
            this.buttonVolumeDown = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.tabPagePackage = new System.Windows.Forms.TabPage();
            this.buttonTabInstall = new System.Windows.Forms.Button();
            this.comboBoxPackageType = new System.Windows.Forms.ComboBox();
            this.tabPageProcess = new System.Windows.Forms.TabPage();
            this.buttonCpuAndMem = new System.Windows.Forms.Button();
            this.comboBoxProcess = new System.Windows.Forms.ComboBox();
            this.checkBoxProcess = new System.Windows.Forms.CheckBox();
            this.textBoxProcessFilter = new System.Windows.Forms.TextBox();
            this.buttonProcessList = new System.Windows.Forms.Button();
            this.listViewProcessList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemMeminfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOutputHprof = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKillProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeviceDetect = new System.Windows.Forms.Button();
            this.buttonSystemSetting = new System.Windows.Forms.Button();
            this.buttonDeviceInfo = new System.Windows.Forms.Button();
            this.buttonDeveloper = new System.Windows.Forms.Button();
            this.buttonWifi = new System.Windows.Forms.Button();
            this.buttonDeviceSetting = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonScreenShot = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonRestartAdb = new System.Windows.Forms.Button();
            this.buttonLogcat = new System.Windows.Forms.Button();
            this.buttonScreenRecord = new System.Windows.Forms.Button();
            this.buttonPackageInfo = new System.Windows.Forms.Button();
            this.buttonPackageDump = new System.Windows.Forms.Button();
            this.buttonSystemProp = new System.Windows.Forms.Button();
            this.buttonMemInfo = new System.Windows.Forms.Button();
            this.buttonCpu = new System.Windows.Forms.Button();
            this.buttonScreenSize = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonFileManager = new System.Windows.Forms.Button();
            this.buttonAppManager = new System.Windows.Forms.Button();
            this.buttonDumpsys = new System.Windows.Forms.Button();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设备信息IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeviceRefreash = new System.Windows.Forms.ToolStripMenuItem();
            this.运行信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeviceInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.deviceInfoInputMethodControlTab = new ArkController.Component.DeviceInfoControl();
            this.keyboardControl1 = new ArkController.Component.KeyboardControl();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripListview.SuspendLayout();
            this.toolStripKibot.SuspendLayout();
            this.tabControlHomePage.SuspendLayout();
            this.tabPageDeviceInfo.SuspendLayout();
            this.tabPageKeyboard.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagePackage.SuspendLayout();
            this.tabPageProcess.SuspendLayout();
            this.contextMenuStripProcess.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLogSave);
            this.groupBox2.Controls.Add(this.buttonLogClear);
            this.groupBox2.Controls.Add(this.textBoxLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 621);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1107, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行日志";
            // 
            // buttonLogSave
            // 
            this.buttonLogSave.BackgroundImage = global::ArkController.Properties.Resources.save;
            this.buttonLogSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogSave.Location = new System.Drawing.Point(4, 56);
            this.buttonLogSave.Name = "buttonLogSave";
            this.buttonLogSave.Size = new System.Drawing.Size(30, 30);
            this.buttonLogSave.TabIndex = 1;
            this.buttonLogSave.UseVisualStyleBackColor = true;
            this.buttonLogSave.Click += new System.EventHandler(this.buttonLogSave_Click);
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.BackgroundImage = global::ArkController.Properties.Resources.empty_trash;
            this.buttonLogClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogClear.Location = new System.Drawing.Point(4, 20);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(30, 30);
            this.buttonLogClear.TabIndex = 1;
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.buttonLogClear_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLog.Location = new System.Drawing.Point(40, 20);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(1056, 114);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(1017, 475);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(75, 23);
            this.buttonSendText.TabIndex = 7;
            this.buttonSendText.Text = "发送文本";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // textBoxSendText
            // 
            this.textBoxSendText.Location = new System.Drawing.Point(7, 477);
            this.textBoxSendText.Name = "textBoxSendText";
            this.textBoxSendText.Size = new System.Drawing.Size(995, 21);
            this.textBoxSendText.TabIndex = 6;
            this.textBoxSendText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendText_KeyDown);
            // 
            // openFileDialogInstall
            // 
            this.openFileDialogInstall.FileName = "openFileDialog1";
            // 
            // listViewPackage
            // 
            this.listViewPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPackageName,
            this.columnHeaderPath,
            this.columnHeaderType,
            this.columnHeaderInstall});
            this.listViewPackage.ContextMenuStrip = this.contextMenuStripListview;
            this.listViewPackage.FullRowSelect = true;
            this.listViewPackage.GridLines = true;
            this.listViewPackage.Location = new System.Drawing.Point(7, 44);
            this.listViewPackage.MultiSelect = false;
            this.listViewPackage.Name = "listViewPackage";
            this.listViewPackage.Size = new System.Drawing.Size(1086, 464);
            this.listViewPackage.TabIndex = 2;
            this.listViewPackage.UseCompatibleStateImageBehavior = false;
            this.listViewPackage.View = System.Windows.Forms.View.Details;
            this.listViewPackage.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPackage_ColumnClick);
            this.listViewPackage.Resize += new System.EventHandler(this.listViewPackage_Resize);
            // 
            // columnHeaderPackageName
            // 
            this.columnHeaderPackageName.Text = "包名";
            this.columnHeaderPackageName.Width = 40;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "程序路径";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "类型";
            // 
            // columnHeaderInstall
            // 
            this.columnHeaderInstall.Text = "安装者";
            // 
            // contextMenuStripListview
            // 
            this.contextMenuStripListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDetail,
            this.toolStripMenuItemClearData,
            this.PToolStripMenuItemPackageInfo,
            this.toolStripMenuItemPackageDump,
            this.toolStripMenuItemKillAllProcess,
            this.toolStripMenuItemLogcat,
            this.toolStripMenuItemHideApp,
            this.toolStripMenuItemUnhideApp,
            this.toolStripMenuItemPullApk,
            this.PToolStripMenuItemCopy,
            this.toolStripMenuItemUninstall});
            this.contextMenuStripListview.Name = "contextMenuStripListview";
            this.contextMenuStripListview.Size = new System.Drawing.Size(190, 246);
            this.contextMenuStripListview.Text = "删除";
            // 
            // ToolStripMenuItemDetail
            // 
            this.ToolStripMenuItemDetail.Name = "ToolStripMenuItemDetail";
            this.ToolStripMenuItemDetail.Size = new System.Drawing.Size(189, 22);
            this.ToolStripMenuItemDetail.Text = "打开应用详细信息(&D)";
            this.ToolStripMenuItemDetail.Click += new System.EventHandler(this.ToolStripMenuItemDetail_Click);
            // 
            // toolStripMenuItemClearData
            // 
            this.toolStripMenuItemClearData.Name = "toolStripMenuItemClearData";
            this.toolStripMenuItemClearData.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemClearData.Text = "清空设备应用数据(&A)";
            this.toolStripMenuItemClearData.Click += new System.EventHandler(this.toolStripMenuItemClearData_Click);
            // 
            // PToolStripMenuItemPackageInfo
            // 
            this.PToolStripMenuItemPackageInfo.Name = "PToolStripMenuItemPackageInfo";
            this.PToolStripMenuItemPackageInfo.Size = new System.Drawing.Size(189, 22);
            this.PToolStripMenuItemPackageInfo.Text = "本地显示应用信息(&P)";
            this.PToolStripMenuItemPackageInfo.Click += new System.EventHandler(this.PToolStripMenuItemPackageInfo_Click);
            // 
            // toolStripMenuItemPackageDump
            // 
            this.toolStripMenuItemPackageDump.Name = "toolStripMenuItemPackageDump";
            this.toolStripMenuItemPackageDump.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemPackageDump.Text = "显示应用系统状态(&B)";
            this.toolStripMenuItemPackageDump.Click += new System.EventHandler(this.toolStripMenuItemPackageDump_Click);
            // 
            // toolStripMenuItemKillAllProcess
            // 
            this.toolStripMenuItemKillAllProcess.Name = "toolStripMenuItemKillAllProcess";
            this.toolStripMenuItemKillAllProcess.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemKillAllProcess.Text = "结束应用所有进程(&S)";
            this.toolStripMenuItemKillAllProcess.Click += new System.EventHandler(this.toolStripMenuItemKillAllProcess_Click);
            // 
            // toolStripMenuItemLogcat
            // 
            this.toolStripMenuItemLogcat.Name = "toolStripMenuItemLogcat";
            this.toolStripMenuItemLogcat.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemLogcat.Text = "显示应用Logcat(&L)";
            this.toolStripMenuItemLogcat.Click += new System.EventHandler(this.toolStripMenuItemLogcat_Click);
            // 
            // toolStripMenuItemHideApp
            // 
            this.toolStripMenuItemHideApp.Name = "toolStripMenuItemHideApp";
            this.toolStripMenuItemHideApp.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemHideApp.Text = "隐藏设备应用(&H)";
            this.toolStripMenuItemHideApp.Click += new System.EventHandler(this.toolStripMenuItemHideApp_Click);
            // 
            // toolStripMenuItemUnhideApp
            // 
            this.toolStripMenuItemUnhideApp.Name = "toolStripMenuItemUnhideApp";
            this.toolStripMenuItemUnhideApp.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemUnhideApp.Text = "恢复设备应用(&U)";
            this.toolStripMenuItemUnhideApp.Visible = false;
            this.toolStripMenuItemUnhideApp.Click += new System.EventHandler(this.toolStripMenuItemUnhideApp_Click);
            // 
            // toolStripMenuItemPullApk
            // 
            this.toolStripMenuItemPullApk.Name = "toolStripMenuItemPullApk";
            this.toolStripMenuItemPullApk.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemPullApk.Text = "导出安装程序(&O)";
            this.toolStripMenuItemPullApk.Click += new System.EventHandler(this.toolStripMenuItemPullApk_Click);
            // 
            // PToolStripMenuItemCopy
            // 
            this.PToolStripMenuItemCopy.Name = "PToolStripMenuItemCopy";
            this.PToolStripMenuItemCopy.Size = new System.Drawing.Size(189, 22);
            this.PToolStripMenuItemCopy.Text = "复制(&C)";
            this.PToolStripMenuItemCopy.Click += new System.EventHandler(this.PToolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItemUninstall
            // 
            this.toolStripMenuItemUninstall.Name = "toolStripMenuItemUninstall";
            this.toolStripMenuItemUninstall.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemUninstall.Text = "卸载(&U)";
            this.toolStripMenuItemUninstall.Click += new System.EventHandler(this.toolStripMenuItemUninstall_Click);
            // 
            // buttonPackageList
            // 
            this.buttonPackageList.Location = new System.Drawing.Point(7, 15);
            this.buttonPackageList.Name = "buttonPackageList";
            this.buttonPackageList.Size = new System.Drawing.Size(77, 23);
            this.buttonPackageList.TabIndex = 15;
            this.buttonPackageList.Text = "程序列表";
            this.buttonPackageList.UseVisualStyleBackColor = true;
            this.buttonPackageList.Click += new System.EventHandler(this.buttonPackageList_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFilter.Location = new System.Drawing.Point(99, 17);
            this.textBoxFilter.MaxLength = 255;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(182, 21);
            this.textBoxFilter.TabIndex = 17;
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Checked = true;
            this.checkBoxFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilter.Location = new System.Drawing.Point(290, 19);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFilter.TabIndex = 16;
            this.checkBoxFilter.Text = "过滤";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // toolStripKibot
            // 
            this.toolStripKibot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripComboBoxDeviceList,
            this.toolStripButtonRefresh,
            this.toolStripButtonRestartAdb,
            this.toolStripSeparator1,
            this.toolStripButtonAbout});
            this.toolStripKibot.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripKibot.Location = new System.Drawing.Point(0, 25);
            this.toolStripKibot.Name = "toolStripKibot";
            this.toolStripKibot.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripKibot.Size = new System.Drawing.Size(1131, 25);
            this.toolStripKibot.TabIndex = 6;
            this.toolStripKibot.Text = "电池电量";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripLabel1.Text = "设备列表";
            // 
            // toolStripComboBoxDeviceList
            // 
            this.toolStripComboBoxDeviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxDeviceList.DropDownWidth = 150;
            this.toolStripComboBoxDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxDeviceList.Items.AddRange(new object[] {
            "没有设备"});
            this.toolStripComboBoxDeviceList.Name = "toolStripComboBoxDeviceList";
            this.toolStripComboBoxDeviceList.Size = new System.Drawing.Size(150, 25);
            this.toolStripComboBoxDeviceList.ToolTipText = "设备列表";
            this.toolStripComboBoxDeviceList.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxDeviceList_SelectedIndexChanged);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::ArkController.Properties.Resources.update;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonRefresh.Text = "toolStripButton1";
            this.toolStripButtonRefresh.ToolTipText = "刷新设备列表";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripButtonRestartAdb
            // 
            this.toolStripButtonRestartAdb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRestartAdb.Image = global::ArkController.Properties.Resources.usb;
            this.toolStripButtonRestartAdb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRestartAdb.Name = "toolStripButtonRestartAdb";
            this.toolStripButtonRestartAdb.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonRestartAdb.Text = "重启adb";
            this.toolStripButtonRestartAdb.Click += new System.EventHandler(this.buttonRestartAdb_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonAbout.Text = "关于";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // tabControlHomePage
            // 
            this.tabControlHomePage.Controls.Add(this.tabPageDeviceInfo);
            this.tabControlHomePage.Controls.Add(this.tabPageKeyboard);
            this.tabControlHomePage.Controls.Add(this.tabPagePackage);
            this.tabControlHomePage.Controls.Add(this.tabPageProcess);
            this.tabControlHomePage.Controls.Add(this.tabPageControl);
            this.tabControlHomePage.ImageList = this.imageListTabs;
            this.tabControlHomePage.ItemSize = new System.Drawing.Size(60, 40);
            this.tabControlHomePage.Location = new System.Drawing.Point(12, 53);
            this.tabControlHomePage.Name = "tabControlHomePage";
            this.tabControlHomePage.SelectedIndex = 0;
            this.tabControlHomePage.ShowToolTips = true;
            this.tabControlHomePage.Size = new System.Drawing.Size(1107, 562);
            this.tabControlHomePage.TabIndex = 7;
            this.tabControlHomePage.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlHomePage_Selected);
            // 
            // tabPageDeviceInfo
            // 
            this.tabPageDeviceInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageDeviceInfo.Controls.Add(this.deviceInfoInputMethodControlTab);
            this.tabPageDeviceInfo.ImageKey = "info.png";
            this.tabPageDeviceInfo.Location = new System.Drawing.Point(4, 44);
            this.tabPageDeviceInfo.Name = "tabPageDeviceInfo";
            this.tabPageDeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceInfo.Size = new System.Drawing.Size(1099, 514);
            this.tabPageDeviceInfo.TabIndex = 0;
            this.tabPageDeviceInfo.Text = "设备信息";
            this.tabPageDeviceInfo.ToolTipText = "显示当前设备的基本信息";
            this.tabPageDeviceInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageKeyboard
            // 
            this.tabPageKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageKeyboard.Controls.Add(this.keyboardControl1);
            this.tabPageKeyboard.Controls.Add(this.groupBox4);
            this.tabPageKeyboard.Controls.Add(this.groupBox3);
            this.tabPageKeyboard.Controls.Add(this.groupBox1);
            this.tabPageKeyboard.Controls.Add(this.buttonSendText);
            this.tabPageKeyboard.Controls.Add(this.textBoxSendText);
            this.tabPageKeyboard.Controls.Add(this.buttonBack);
            this.tabPageKeyboard.Controls.Add(this.buttonMenu);
            this.tabPageKeyboard.Controls.Add(this.buttonHome);
            this.tabPageKeyboard.ImageKey = "Keyboard.png";
            this.tabPageKeyboard.Location = new System.Drawing.Point(4, 44);
            this.tabPageKeyboard.Name = "tabPageKeyboard";
            this.tabPageKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyboard.Size = new System.Drawing.Size(1099, 514);
            this.tabPageKeyboard.TabIndex = 1;
            this.tabPageKeyboard.Text = "按键控制";
            this.tabPageKeyboard.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonVolumeUp);
            this.groupBox4.Controls.Add(this.buttonVolumeDown);
            this.groupBox4.Location = new System.Drawing.Point(829, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 95);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "声音";
            // 
            // buttonVolumeUp
            // 
            this.buttonVolumeUp.BackgroundImage = global::ArkController.Properties.Resources.volume_up;
            this.buttonVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolumeUp.Location = new System.Drawing.Point(170, 20);
            this.buttonVolumeUp.Name = "buttonVolumeUp";
            this.buttonVolumeUp.Size = new System.Drawing.Size(60, 60);
            this.buttonVolumeUp.TabIndex = 2;
            this.buttonVolumeUp.Tag = "24";
            this.toolTipButton.SetToolTip(this.buttonVolumeUp, "声音大");
            this.buttonVolumeUp.UseVisualStyleBackColor = true;
            this.buttonVolumeUp.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonVolumeDown
            // 
            this.buttonVolumeDown.AccessibleDescription = "";
            this.buttonVolumeDown.BackgroundImage = global::ArkController.Properties.Resources.volume_down;
            this.buttonVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolumeDown.Location = new System.Drawing.Point(29, 18);
            this.buttonVolumeDown.Name = "buttonVolumeDown";
            this.buttonVolumeDown.Size = new System.Drawing.Size(60, 60);
            this.buttonVolumeDown.TabIndex = 3;
            this.buttonVolumeDown.Tag = "25";
            this.toolTipButton.SetToolTip(this.buttonVolumeDown, "声音小");
            this.buttonVolumeDown.UseVisualStyleBackColor = true;
            this.buttonVolumeDown.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonReboot);
            this.groupBox3.Controls.Add(this.buttonPower);
            this.groupBox3.Location = new System.Drawing.Point(829, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 97);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 电源";
            // 
            // buttonReboot
            // 
            this.buttonReboot.BackgroundImage = global::ArkController.Properties.Resources.rebot;
            this.buttonReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReboot.Location = new System.Drawing.Point(170, 20);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(60, 60);
            this.buttonReboot.TabIndex = 5;
            this.toolTipButton.SetToolTip(this.buttonReboot, "重启");
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.BackgroundImage = global::ArkController.Properties.Resources.power;
            this.buttonPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPower.Location = new System.Drawing.Point(29, 20);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(60, 60);
            this.buttonPower.TabIndex = 4;
            this.buttonPower.Tag = "26";
            this.toolTipButton.SetToolTip(this.buttonPower, "电源");
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCenter);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Location = new System.Drawing.Point(830, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackgroundImage = global::ArkController.Properties.Resources.rounded;
            this.buttonCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCenter.Location = new System.Drawing.Point(100, 94);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(60, 60);
            this.buttonCenter.TabIndex = 2;
            this.buttonCenter.Tag = "23";
            this.toolTipButton.SetToolTip(this.buttonCenter, "确定");
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::ArkController.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(100, 23);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 60);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Tag = "19";
            this.toolTipButton.SetToolTip(this.buttonUp, "方向上");
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::ArkController.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(100, 168);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 60);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Tag = "20";
            this.toolTipButton.SetToolTip(this.buttonDown, "方向下");
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::ArkController.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(171, 94);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 60);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Tag = "22";
            this.toolTipButton.SetToolTip(this.buttonRight, "方向右");
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::ArkController.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(30, 94);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Tag = "21";
            this.toolTipButton.SetToolTip(this.buttonLeft, "方向左");
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::ArkController.Properties.Resources.back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(28, 31);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 60);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Tag = "4";
            this.toolTipButton.SetToolTip(this.buttonBack, "返回");
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackgroundImage = global::ArkController.Properties.Resources.menu;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.Location = new System.Drawing.Point(184, 31);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(60, 60);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Tag = "82";
            this.toolTipButton.SetToolTip(this.buttonMenu, "菜单");
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::ArkController.Properties.Resources.home;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Location = new System.Drawing.Point(106, 31);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(60, 60);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Tag = "3";
            this.toolTipButton.SetToolTip(this.buttonHome, "主页");
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // tabPagePackage
            // 
            this.tabPagePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPagePackage.Controls.Add(this.buttonTabInstall);
            this.tabPagePackage.Controls.Add(this.comboBoxPackageType);
            this.tabPagePackage.Controls.Add(this.checkBoxFilter);
            this.tabPagePackage.Controls.Add(this.textBoxFilter);
            this.tabPagePackage.Controls.Add(this.listViewPackage);
            this.tabPagePackage.Controls.Add(this.buttonPackageList);
            this.tabPagePackage.ImageKey = "point_list.png";
            this.tabPagePackage.Location = new System.Drawing.Point(4, 44);
            this.tabPagePackage.Name = "tabPagePackage";
            this.tabPagePackage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePackage.Size = new System.Drawing.Size(1099, 514);
            this.tabPagePackage.TabIndex = 2;
            this.tabPagePackage.Text = "程序列表";
            this.tabPagePackage.ToolTipText = "列举出来已经安装程序列表";
            this.tabPagePackage.UseVisualStyleBackColor = true;
            // 
            // buttonTabInstall
            // 
            this.buttonTabInstall.BackgroundImage = global::ArkController.Properties.Resources.plus39;
            this.buttonTabInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTabInstall.Location = new System.Drawing.Point(1053, 3);
            this.buttonTabInstall.Name = "buttonTabInstall";
            this.buttonTabInstall.Size = new System.Drawing.Size(40, 40);
            this.buttonTabInstall.TabIndex = 19;
            this.toolTipButton.SetToolTip(this.buttonTabInstall, "安装新的程序");
            this.buttonTabInstall.UseVisualStyleBackColor = true;
            this.buttonTabInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // comboBoxPackageType
            // 
            this.comboBoxPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPackageType.FormattingEnabled = true;
            this.comboBoxPackageType.Items.AddRange(new object[] {
            "全部应用",
            "内置应用",
            "第三方应用"});
            this.comboBoxPackageType.Location = new System.Drawing.Point(345, 17);
            this.comboBoxPackageType.Name = "comboBoxPackageType";
            this.comboBoxPackageType.Size = new System.Drawing.Size(83, 20);
            this.comboBoxPackageType.TabIndex = 18;
            this.toolTipButton.SetToolTip(this.comboBoxPackageType, "选择显示程序类别");
            // 
            // tabPageProcess
            // 
            this.tabPageProcess.Controls.Add(this.buttonCpuAndMem);
            this.tabPageProcess.Controls.Add(this.comboBoxProcess);
            this.tabPageProcess.Controls.Add(this.checkBoxProcess);
            this.tabPageProcess.Controls.Add(this.textBoxProcessFilter);
            this.tabPageProcess.Controls.Add(this.buttonProcessList);
            this.tabPageProcess.Controls.Add(this.listViewProcessList);
            this.tabPageProcess.ImageKey = "point_list.png";
            this.tabPageProcess.Location = new System.Drawing.Point(4, 44);
            this.tabPageProcess.Name = "tabPageProcess";
            this.tabPageProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcess.Size = new System.Drawing.Size(1099, 514);
            this.tabPageProcess.TabIndex = 4;
            this.tabPageProcess.Text = "进程列表";
            this.tabPageProcess.UseVisualStyleBackColor = true;
            // 
            // buttonCpuAndMem
            // 
            this.buttonCpuAndMem.BackgroundImage = global::ArkController.Properties.Resources.statistics;
            this.buttonCpuAndMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCpuAndMem.Location = new System.Drawing.Point(1056, 3);
            this.buttonCpuAndMem.Name = "buttonCpuAndMem";
            this.buttonCpuAndMem.Size = new System.Drawing.Size(40, 40);
            this.buttonCpuAndMem.TabIndex = 22;
            this.toolTipButton.SetToolTip(this.buttonCpuAndMem, "打开CPU和内存占用统计");
            this.buttonCpuAndMem.UseVisualStyleBackColor = true;
            this.buttonCpuAndMem.Click += new System.EventHandler(this.buttonCpuAndMem_Click);
            // 
            // comboBoxProcess
            // 
            this.comboBoxProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcess.FormattingEnabled = true;
            this.comboBoxProcess.Items.AddRange(new object[] {
            "全部进程",
            "用户进程",
            "系统进程"});
            this.comboBoxProcess.Location = new System.Drawing.Point(345, 17);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(83, 20);
            this.comboBoxProcess.TabIndex = 21;
            this.toolTipButton.SetToolTip(this.comboBoxProcess, "选择显示程序类别");
            // 
            // checkBoxProcess
            // 
            this.checkBoxProcess.AutoSize = true;
            this.checkBoxProcess.Checked = true;
            this.checkBoxProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProcess.Location = new System.Drawing.Point(290, 19);
            this.checkBoxProcess.Name = "checkBoxProcess";
            this.checkBoxProcess.Size = new System.Drawing.Size(48, 16);
            this.checkBoxProcess.TabIndex = 19;
            this.checkBoxProcess.Text = "过滤";
            this.checkBoxProcess.UseVisualStyleBackColor = true;
            // 
            // textBoxProcessFilter
            // 
            this.textBoxProcessFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxProcessFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxProcessFilter.Location = new System.Drawing.Point(99, 17);
            this.textBoxProcessFilter.MaxLength = 255;
            this.textBoxProcessFilter.Name = "textBoxProcessFilter";
            this.textBoxProcessFilter.Size = new System.Drawing.Size(182, 21);
            this.textBoxProcessFilter.TabIndex = 20;
            this.textBoxProcessFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProcessFilter_KeyDown);
            // 
            // buttonProcessList
            // 
            this.buttonProcessList.Location = new System.Drawing.Point(7, 15);
            this.buttonProcessList.Name = "buttonProcessList";
            this.buttonProcessList.Size = new System.Drawing.Size(77, 23);
            this.buttonProcessList.TabIndex = 16;
            this.buttonProcessList.Text = "进程列表";
            this.buttonProcessList.UseVisualStyleBackColor = true;
            this.buttonProcessList.Click += new System.EventHandler(this.buttonProcessList_Click);
            // 
            // listViewProcessList
            // 
            this.listViewProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewProcessList.ContextMenuStrip = this.contextMenuStripProcess;
            this.listViewProcessList.FullRowSelect = true;
            this.listViewProcessList.GridLines = true;
            this.listViewProcessList.Location = new System.Drawing.Point(7, 44);
            this.listViewProcessList.MultiSelect = false;
            this.listViewProcessList.Name = "listViewProcessList";
            this.listViewProcessList.Size = new System.Drawing.Size(1093, 464);
            this.listViewProcessList.TabIndex = 3;
            this.listViewProcessList.UseCompatibleStateImageBehavior = false;
            this.listViewProcessList.View = System.Windows.Forms.View.Details;
            this.listViewProcessList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPackage_ColumnClick);
            this.listViewProcessList.Resize += new System.EventHandler(this.listViewProcessList_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "USER";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PPID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "VSIZE";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "RSS";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NAME";
            // 
            // contextMenuStripProcess
            // 
            this.contextMenuStripProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMeminfo,
            this.toolStripMenuItemOutputHprof,
            this.toolStripMenuItemKillProcess,
            this.toolStripMenuItemCopy});
            this.contextMenuStripProcess.Name = "contextMenuStripProcess";
            this.contextMenuStripProcess.Size = new System.Drawing.Size(191, 92);
            // 
            // toolStripMenuItemMeminfo
            // 
            this.toolStripMenuItemMeminfo.Name = "toolStripMenuItemMeminfo";
            this.toolStripMenuItemMeminfo.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemMeminfo.Text = "进监测程内存占用(&I)";
            this.toolStripMenuItemMeminfo.Click += new System.EventHandler(this.toolStripProcessMenuItem_Click);
            // 
            // toolStripMenuItemOutputHprof
            // 
            this.toolStripMenuItemOutputHprof.Name = "toolStripMenuItemOutputHprof";
            this.toolStripMenuItemOutputHprof.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemOutputHprof.Text = "导出进程内存快照(&O)";
            this.toolStripMenuItemOutputHprof.Click += new System.EventHandler(this.toolStripProcessMenuItem_Click);
            // 
            // toolStripMenuItemKillProcess
            // 
            this.toolStripMenuItemKillProcess.Name = "toolStripMenuItemKillProcess";
            this.toolStripMenuItemKillProcess.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemKillProcess.Text = "结束进程(&K)";
            this.toolStripMenuItemKillProcess.Visible = false;
            this.toolStripMenuItemKillProcess.Click += new System.EventHandler(this.toolStripProcessMenuItem_Click);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemCopy.Text = "复制(&C)";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripProcessMenuItem_Click);
            // 
            // tabPageControl
            // 
            this.tabPageControl.Controls.Add(this.groupBox6);
            this.tabPageControl.Controls.Add(this.groupBox5);
            this.tabPageControl.ImageKey = "system.png";
            this.tabPageControl.Location = new System.Drawing.Point(4, 44);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControl.Size = new System.Drawing.Size(1099, 514);
            this.tabPageControl.TabIndex = 3;
            this.tabPageControl.Text = "系统控制";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel2);
            this.groupBox6.Location = new System.Drawing.Point(11, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1081, 243);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "设备";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSystemSetting, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeviceInfo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeveloper, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonWifi, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeviceDetect, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeviceSetting, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(971, 168);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // buttonDeviceDetect
            // 
            this.buttonDeviceDetect.BackgroundImage = global::ArkController.Properties.Resources.device_hardware;
            this.buttonDeviceDetect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeviceDetect.Location = new System.Drawing.Point(608, 3);
            this.buttonDeviceDetect.Name = "buttonDeviceDetect";
            this.buttonDeviceDetect.Size = new System.Drawing.Size(60, 60);
            this.buttonDeviceDetect.TabIndex = 12;
            this.toolTipButton.SetToolTip(this.buttonDeviceDetect, "打开硬件测试程序");
            this.buttonDeviceDetect.UseVisualStyleBackColor = true;
            this.buttonDeviceDetect.Visible = false;
            this.buttonDeviceDetect.Click += new System.EventHandler(this.buttonDeviceDetect_Click);
            // 
            // buttonSystemSetting
            // 
            this.buttonSystemSetting.BackgroundImage = global::ArkController.Properties.Resources.settings_1;
            this.buttonSystemSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSystemSetting.Location = new System.Drawing.Point(124, 3);
            this.buttonSystemSetting.Name = "buttonSystemSetting";
            this.buttonSystemSetting.Size = new System.Drawing.Size(60, 60);
            this.buttonSystemSetting.TabIndex = 13;
            this.toolTipButton.SetToolTip(this.buttonSystemSetting, "打开系统设置");
            this.buttonSystemSetting.UseVisualStyleBackColor = true;
            this.buttonSystemSetting.Click += new System.EventHandler(this.buttonSystemSetting_Click);
            // 
            // buttonDeviceInfo
            // 
            this.buttonDeviceInfo.BackgroundImage = global::ArkController.Properties.Resources.system_information;
            this.buttonDeviceInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeviceInfo.Location = new System.Drawing.Point(245, 3);
            this.buttonDeviceInfo.Name = "buttonDeviceInfo";
            this.buttonDeviceInfo.Size = new System.Drawing.Size(60, 60);
            this.buttonDeviceInfo.TabIndex = 15;
            this.toolTipButton.SetToolTip(this.buttonDeviceInfo, "打开设备状态信息");
            this.buttonDeviceInfo.UseVisualStyleBackColor = true;
            this.buttonDeviceInfo.Click += new System.EventHandler(this.buttonDeviceInfo_Click);
            // 
            // buttonDeveloper
            // 
            this.buttonDeveloper.BackgroundImage = global::ArkController.Properties.Resources.control_panel;
            this.buttonDeveloper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeveloper.Location = new System.Drawing.Point(366, 3);
            this.buttonDeveloper.Name = "buttonDeveloper";
            this.buttonDeveloper.Size = new System.Drawing.Size(60, 60);
            this.buttonDeveloper.TabIndex = 16;
            this.toolTipButton.SetToolTip(this.buttonDeveloper, "打开开发者选项");
            this.buttonDeveloper.UseVisualStyleBackColor = true;
            this.buttonDeveloper.Click += new System.EventHandler(this.buttonDeveloper_Click);
            // 
            // buttonWifi
            // 
            this.buttonWifi.BackgroundImage = global::ArkController.Properties.Resources.wifi;
            this.buttonWifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWifi.Location = new System.Drawing.Point(487, 3);
            this.buttonWifi.Name = "buttonWifi";
            this.buttonWifi.Size = new System.Drawing.Size(60, 60);
            this.buttonWifi.TabIndex = 16;
            this.buttonWifi.UseVisualStyleBackColor = true;
            this.buttonWifi.Click += new System.EventHandler(this.buttonWifi_Click);
            // 
            // buttonDeviceSetting
            // 
            this.buttonDeviceSetting.BackgroundImage = global::ArkController.Properties.Resources.setting_2;
            this.buttonDeviceSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeviceSetting.Location = new System.Drawing.Point(3, 3);
            this.buttonDeviceSetting.Name = "buttonDeviceSetting";
            this.buttonDeviceSetting.Size = new System.Drawing.Size(60, 60);
            this.buttonDeviceSetting.TabIndex = 16;
            this.toolTipButton.SetToolTip(this.buttonDeviceSetting, "启动系统内置界面");
            this.buttonDeviceSetting.UseVisualStyleBackColor = true;
            this.buttonDeviceSetting.Click += new System.EventHandler(this.buttonDeviceSetting_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(11, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1081, 242);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "本地";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.buttonScreenShot, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInstall, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRestartAdb, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLogcat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonScreenRecord, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPackageInfo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPackageDump, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSystemProp, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMemInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCpu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonScreenSize, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCommand, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFileManager, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAppManager, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDumpsys, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 168);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // buttonScreenShot
            // 
            this.buttonScreenShot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonScreenShot.BackgroundImage")));
            this.buttonScreenShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonScreenShot.Location = new System.Drawing.Point(3, 3);
            this.buttonScreenShot.Name = "buttonScreenShot";
            this.buttonScreenShot.Size = new System.Drawing.Size(60, 60);
            this.buttonScreenShot.TabIndex = 9;
            this.toolTipButton.SetToolTip(this.buttonScreenShot, "屏幕截图");
            this.buttonScreenShot.UseVisualStyleBackColor = true;
            this.buttonScreenShot.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.AllowDrop = true;
            this.buttonInstall.BackgroundImage = global::ArkController.Properties.Resources.plus39;
            this.buttonInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInstall.Location = new System.Drawing.Point(850, 3);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(60, 60);
            this.buttonInstall.TabIndex = 14;
            this.toolTipButton.SetToolTip(this.buttonInstall, "安装程序");
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            this.buttonInstall.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonInstall_DragDrop);
            this.buttonInstall.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonInstall_DragEnter);
            // 
            // buttonRestartAdb
            // 
            this.buttonRestartAdb.BackgroundImage = global::ArkController.Properties.Resources.usb;
            this.buttonRestartAdb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestartAdb.Location = new System.Drawing.Point(729, 3);
            this.buttonRestartAdb.Name = "buttonRestartAdb";
            this.buttonRestartAdb.Size = new System.Drawing.Size(60, 60);
            this.buttonRestartAdb.TabIndex = 11;
            this.toolTipButton.SetToolTip(this.buttonRestartAdb, "重启Adb");
            this.buttonRestartAdb.UseVisualStyleBackColor = true;
            this.buttonRestartAdb.Click += new System.EventHandler(this.buttonRestartAdb_Click);
            // 
            // buttonLogcat
            // 
            this.buttonLogcat.BackgroundImage = global::ArkController.Properties.Resources.log;
            this.buttonLogcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogcat.Location = new System.Drawing.Point(245, 3);
            this.buttonLogcat.Name = "buttonLogcat";
            this.buttonLogcat.Size = new System.Drawing.Size(60, 60);
            this.buttonLogcat.TabIndex = 10;
            this.toolTipButton.SetToolTip(this.buttonLogcat, "打开Logcat监测");
            this.buttonLogcat.UseVisualStyleBackColor = true;
            this.buttonLogcat.Click += new System.EventHandler(this.buttonLogcat_Click);
            // 
            // buttonScreenRecord
            // 
            this.buttonScreenRecord.BackgroundImage = global::ArkController.Properties.Resources.screen_record;
            this.buttonScreenRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonScreenRecord.Location = new System.Drawing.Point(124, 3);
            this.buttonScreenRecord.Name = "buttonScreenRecord";
            this.buttonScreenRecord.Size = new System.Drawing.Size(60, 60);
            this.buttonScreenRecord.TabIndex = 9;
            this.toolTipButton.SetToolTip(this.buttonScreenRecord, "录制屏幕");
            this.buttonScreenRecord.UseVisualStyleBackColor = true;
            this.buttonScreenRecord.Click += new System.EventHandler(this.buttonScreenRecord_Click);
            // 
            // buttonPackageInfo
            // 
            this.buttonPackageInfo.BackgroundImage = global::ArkController.Properties.Resources.app_attention;
            this.buttonPackageInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPackageInfo.Location = new System.Drawing.Point(487, 3);
            this.buttonPackageInfo.Name = "buttonPackageInfo";
            this.buttonPackageInfo.Size = new System.Drawing.Size(60, 60);
            this.buttonPackageInfo.TabIndex = 18;
            this.toolTipButton.SetToolTip(this.buttonPackageInfo, "打开应用信息");
            this.buttonPackageInfo.UseVisualStyleBackColor = true;
            this.buttonPackageInfo.Click += new System.EventHandler(this.buttonPackageInfo_Click);
            // 
            // buttonPackageDump
            // 
            this.buttonPackageDump.BackgroundImage = global::ArkController.Properties.Resources.system_status;
            this.buttonPackageDump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPackageDump.Location = new System.Drawing.Point(608, 3);
            this.buttonPackageDump.Name = "buttonPackageDump";
            this.buttonPackageDump.Size = new System.Drawing.Size(60, 60);
            this.buttonPackageDump.TabIndex = 19;
            this.toolTipButton.SetToolTip(this.buttonPackageDump, "打开应用系统状态");
            this.buttonPackageDump.UseVisualStyleBackColor = true;
            this.buttonPackageDump.Click += new System.EventHandler(this.buttonPackageDump_Click);
            // 
            // buttonSystemProp
            // 
            this.buttonSystemProp.BackgroundImage = global::ArkController.Properties.Resources.system_prop;
            this.buttonSystemProp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSystemProp.Location = new System.Drawing.Point(245, 87);
            this.buttonSystemProp.Name = "buttonSystemProp";
            this.buttonSystemProp.Size = new System.Drawing.Size(60, 60);
            this.buttonSystemProp.TabIndex = 17;
            this.toolTipButton.SetToolTip(this.buttonSystemProp, "打开系统属性");
            this.buttonSystemProp.UseVisualStyleBackColor = true;
            this.buttonSystemProp.Click += new System.EventHandler(this.buttonSystemProp_Click);
            // 
            // buttonMemInfo
            // 
            this.buttonMemInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonMemInfo.BackgroundImage = global::ArkController.Properties.Resources.performance;
            this.buttonMemInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMemInfo.Location = new System.Drawing.Point(124, 87);
            this.buttonMemInfo.Name = "buttonMemInfo";
            this.buttonMemInfo.Size = new System.Drawing.Size(60, 60);
            this.buttonMemInfo.TabIndex = 17;
            this.toolTipButton.SetToolTip(this.buttonMemInfo, "进程内存监测");
            this.buttonMemInfo.UseVisualStyleBackColor = false;
            this.buttonMemInfo.Click += new System.EventHandler(this.buttonMemInfo_Click);
            // 
            // buttonCpu
            // 
            this.buttonCpu.BackColor = System.Drawing.Color.Transparent;
            this.buttonCpu.BackgroundImage = global::ArkController.Properties.Resources.speedometer;
            this.buttonCpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCpu.Location = new System.Drawing.Point(3, 87);
            this.buttonCpu.Name = "buttonCpu";
            this.buttonCpu.Size = new System.Drawing.Size(60, 60);
            this.buttonCpu.TabIndex = 17;
            this.toolTipButton.SetToolTip(this.buttonCpu, "系统进程CPU内存占用");
            this.buttonCpu.UseVisualStyleBackColor = false;
            this.buttonCpu.Click += new System.EventHandler(this.buttonCpu_Click);
            // 
            // buttonScreenSize
            // 
            this.buttonScreenSize.BackgroundImage = global::ArkController.Properties.Resources.screen_scale;
            this.buttonScreenSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonScreenSize.Location = new System.Drawing.Point(366, 87);
            this.buttonScreenSize.Name = "buttonScreenSize";
            this.buttonScreenSize.Size = new System.Drawing.Size(60, 60);
            this.buttonScreenSize.TabIndex = 17;
            this.toolTipButton.SetToolTip(this.buttonScreenSize, "打开屏幕尺寸像素密度");
            this.buttonScreenSize.UseVisualStyleBackColor = true;
            this.buttonScreenSize.Click += new System.EventHandler(this.buttonScreenSize_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.BackgroundImage = global::ArkController.Properties.Resources.cmd;
            this.buttonCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCommand.Location = new System.Drawing.Point(366, 3);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(60, 60);
            this.buttonCommand.TabIndex = 17;
            this.buttonCommand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipButton.SetToolTip(this.buttonCommand, "打开命令行");
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonFileManager
            // 
            this.buttonFileManager.BackgroundImage = global::ArkController.Properties.Resources.file_box;
            this.buttonFileManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFileManager.Location = new System.Drawing.Point(487, 87);
            this.buttonFileManager.Name = "buttonFileManager";
            this.buttonFileManager.Size = new System.Drawing.Size(60, 60);
            this.buttonFileManager.TabIndex = 17;
            this.buttonFileManager.UseVisualStyleBackColor = true;
            this.buttonFileManager.Click += new System.EventHandler(this.buttonFileManager_Click);
            // 
            // buttonAppManager
            // 
            this.buttonAppManager.BackgroundImage = global::ArkController.Properties.Resources.apps;
            this.buttonAppManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAppManager.Location = new System.Drawing.Point(850, 87);
            this.buttonAppManager.Name = "buttonAppManager";
            this.buttonAppManager.Size = new System.Drawing.Size(60, 60);
            this.buttonAppManager.TabIndex = 17;
            this.toolTipButton.SetToolTip(this.buttonAppManager, "应用管理");
            this.buttonAppManager.UseVisualStyleBackColor = true;
            this.buttonAppManager.Visible = false;
            this.buttonAppManager.Click += new System.EventHandler(this.buttonAppManager_Click);
            // 
            // buttonDumpsys
            // 
            this.buttonDumpsys.BackgroundImage = global::ArkController.Properties.Resources.stack;
            this.buttonDumpsys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDumpsys.Location = new System.Drawing.Point(608, 87);
            this.buttonDumpsys.Name = "buttonDumpsys";
            this.buttonDumpsys.Size = new System.Drawing.Size(60, 60);
            this.buttonDumpsys.TabIndex = 17;
            this.toolTipButton.SetToolTip(this.buttonDumpsys, "Dumpsys");
            this.buttonDumpsys.UseVisualStyleBackColor = true;
            this.buttonDumpsys.Click += new System.EventHandler(this.buttonDumpsys_Click);
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "info.png");
            this.imageListTabs.Images.SetKeyName(1, "Keyboard.png");
            this.imageListTabs.Images.SetKeyName(2, "point_list.png");
            this.imageListTabs.Images.SetKeyName(3, "system.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设备信息IToolStripMenuItem,
            this.运行信息ToolStripMenuItem,
            this.窗口WToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设备信息IToolStripMenuItem
            // 
            this.设备信息IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeviceRefreash});
            this.设备信息IToolStripMenuItem.Name = "设备信息IToolStripMenuItem";
            this.设备信息IToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.设备信息IToolStripMenuItem.Text = "设备信息(&I)";
            // 
            // toolStripMenuItemDeviceRefreash
            // 
            this.toolStripMenuItemDeviceRefreash.Name = "toolStripMenuItemDeviceRefreash";
            this.toolStripMenuItemDeviceRefreash.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemDeviceRefreash.Text = "刷新列表(&S)";
            this.toolStripMenuItemDeviceRefreash.Click += new System.EventHandler(this.menu_Click);
            // 
            // 运行信息ToolStripMenuItem
            // 
            this.运行信息ToolStripMenuItem.Name = "运行信息ToolStripMenuItem";
            this.运行信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.运行信息ToolStripMenuItem.Text = "运行信息";
            this.运行信息ToolStripMenuItem.Visible = false;
            // 
            // 窗口WToolStripMenuItem
            // 
            this.窗口WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeviceInfo,
            this.toolStripMenuItemKey,
            this.toolStripMenuItemPackage,
            this.toolStripMenuItemProcess,
            this.toolStripMenuItemSystem});
            this.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem";
            this.窗口WToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.窗口WToolStripMenuItem.Text = "窗口(W)";
            // 
            // toolStripMenuItemDeviceInfo
            // 
            this.toolStripMenuItemDeviceInfo.Name = "toolStripMenuItemDeviceInfo";
            this.toolStripMenuItemDeviceInfo.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItemDeviceInfo.Text = "设备信息(&I)";
            this.toolStripMenuItemDeviceInfo.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripMenuItemKey
            // 
            this.toolStripMenuItemKey.Name = "toolStripMenuItemKey";
            this.toolStripMenuItemKey.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItemKey.Text = "按键控制(&K)";
            this.toolStripMenuItemKey.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripMenuItemPackage
            // 
            this.toolStripMenuItemPackage.Name = "toolStripMenuItemPackage";
            this.toolStripMenuItemPackage.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItemPackage.Text = "程序列表(&L)";
            this.toolStripMenuItemPackage.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripMenuItemProcess
            // 
            this.toolStripMenuItemProcess.Name = "toolStripMenuItemProcess";
            this.toolStripMenuItemProcess.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItemProcess.Text = "进程列表(&P)";
            this.toolStripMenuItemProcess.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripMenuItemSystem
            // 
            this.toolStripMenuItemSystem.Name = "toolStripMenuItemSystem";
            this.toolStripMenuItemSystem.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItemSystem.Text = "系统控制(S)";
            this.toolStripMenuItemSystem.Click += new System.EventHandler(this.menu_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(116, 22);
            this.ToolStripMenuItemAbout.Text = "关于(&A)";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // deviceInfoInputMethodControlTab
            // 
            this.deviceInfoInputMethodControlTab.Location = new System.Drawing.Point(6, 6);
            this.deviceInfoInputMethodControlTab.Name = "deviceInfoInputMethodControlTab";
            this.deviceInfoInputMethodControlTab.Size = new System.Drawing.Size(1087, 505);
            this.deviceInfoInputMethodControlTab.TabIndex = 0;
            // 
            // keyboardControl1
            // 
            this.keyboardControl1.Location = new System.Drawing.Point(7, 120);
            this.keyboardControl1.Name = "keyboardControl1";
            this.keyboardControl1.Size = new System.Drawing.Size(817, 351);
            this.keyboardControl1.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 773);
            this.Controls.Add(this.tabControlHomePage);
            this.Controls.Add(this.toolStripKibot);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "方舟控制器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStripListview.ResumeLayout(false);
            this.toolStripKibot.ResumeLayout(false);
            this.toolStripKibot.PerformLayout();
            this.tabControlHomePage.ResumeLayout(false);
            this.tabPageDeviceInfo.ResumeLayout(false);
            this.tabPageKeyboard.ResumeLayout(false);
            this.tabPageKeyboard.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPagePackage.ResumeLayout(false);
            this.tabPagePackage.PerformLayout();
            this.tabPageProcess.ResumeLayout(false);
            this.tabPageProcess.PerformLayout();
            this.contextMenuStripProcess.ResumeLayout(false);
            this.tabPageControl.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonVolumeDown;
        private System.Windows.Forms.Button buttonVolumeUp;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSendText;
        private System.Windows.Forms.TextBox textBoxSendText;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.OpenFileDialog openFileDialogInstall;
        private System.Windows.Forms.Button buttonDeviceDetect;
        private System.Windows.Forms.Button buttonSystemSetting;
        private System.Windows.Forms.Button buttonLogcat;
        private System.Windows.Forms.Button buttonPackageList;
        private System.Windows.Forms.ListView listViewPackage;
        private System.Windows.Forms.ColumnHeader columnHeaderPackageName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListview;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUninstall;
        private System.Windows.Forms.Button buttonRestartAdb;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDetail;
        private System.Windows.Forms.Button buttonDeviceInfo;
        private System.Windows.Forms.Button buttonDeveloper;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.ToolStripMenuItem PToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStrip toolStripKibot;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripMenuItem PToolStripMenuItemPackageInfo;
        private System.Windows.Forms.Button buttonScreenShot;
        private System.Windows.Forms.TabControl tabControlHomePage;
        private System.Windows.Forms.TabPage tabPageDeviceInfo;
        private System.Windows.Forms.TabPage tabPageKeyboard;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.TabPage tabPagePackage;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设备信息IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageProcess;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDeviceList;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeviceRefreash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 窗口WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeviceInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPackage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSystem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearData;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ComboBox comboBoxPackageType;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderInstall;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogcat;
        private System.Windows.Forms.Button buttonScreenSize;
        private System.Windows.Forms.ListView listViewProcessList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonProcessList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonLogClear;
        private System.Windows.Forms.Button buttonLogSave;
        private System.Windows.Forms.ComboBox comboBoxProcess;
        private System.Windows.Forms.CheckBox checkBoxProcess;
        private System.Windows.Forms.TextBox textBoxProcessFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKillProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMeminfo;
        private System.Windows.Forms.Button buttonMemInfo;
        private System.Windows.Forms.Button buttonTabInstall;
        private System.Windows.Forms.Button buttonSystemProp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHideApp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUnhideApp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPullApk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKillAllProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.Button buttonScreenRecord;
        private System.Windows.Forms.ToolStripButton toolStripButtonRestartAdb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPackageDump;
        private System.Windows.Forms.Button buttonPackageInfo;
        private System.Windows.Forms.Button buttonPackageDump;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOutputHprof;
        private System.Windows.Forms.Button buttonCpu;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonFileManager;
        private System.Windows.Forms.Button buttonAppManager;
        private System.Windows.Forms.Button buttonDumpsys;
        private System.Windows.Forms.Button buttonWifi;
        private System.Windows.Forms.Button buttonDeviceSetting;
        private System.Windows.Forms.Button buttonCpuAndMem;
        private Component.DeviceInfoControl deviceInfoInputMethodControlTab;
        private Component.KeyboardControl keyboardControl1;
    }
}

