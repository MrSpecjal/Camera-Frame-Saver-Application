namespace CameraSaver
{
    partial class CameraSaver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraSaver));
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.Capture_button = new System.Windows.Forms.Button();
            this.cameraDevices = new System.Windows.Forms.ComboBox();
            this.formats = new System.Windows.Forms.ComboBox();
            this.preview = new System.Windows.Forms.PictureBox();
            this.captured = new System.Windows.Forms.PictureBox();
            this.Frames = new System.Windows.Forms.DataGridView();
            this.framesToCapture = new System.Windows.Forms.NumericUpDown();
            this.CaptureAll_button = new System.Windows.Forms.Button();
            this.savingMode = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFramesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleFrameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.currentCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDevices = new System.Windows.Forms.ToolStripComboBox();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormats = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraTab = new System.Windows.Forms.TabControl();
            this.cameraPageName = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.savingInterval = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesToCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cameraTab.SuspendLayout();
            this.cameraPageName.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.AccessibleName = "";
            this.Start_button.Location = new System.Drawing.Point(23, 26);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(210, 23);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(23, 84);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(210, 23);
            this.Stop_button.TabIndex = 1;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Location = new System.Drawing.Point(23, 55);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(210, 23);
            this.Pause_button.TabIndex = 2;
            this.Pause_button.Text = "Pause";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // Capture_button
            // 
            this.Capture_button.Location = new System.Drawing.Point(23, 155);
            this.Capture_button.Name = "Capture_button";
            this.Capture_button.Size = new System.Drawing.Size(210, 23);
            this.Capture_button.TabIndex = 3;
            this.Capture_button.Text = "Capture Single Frame";
            this.Capture_button.UseVisualStyleBackColor = true;
            this.Capture_button.Click += new System.EventHandler(this.Capture_button_Click);
            // 
            // cameraDevices
            // 
            this.cameraDevices.FormattingEnabled = true;
            this.cameraDevices.Location = new System.Drawing.Point(25, 42);
            this.cameraDevices.Name = "cameraDevices";
            this.cameraDevices.Size = new System.Drawing.Size(210, 21);
            this.cameraDevices.TabIndex = 5;
            this.cameraDevices.SelectedIndexChanged += new System.EventHandler(this.cameraDevices_SelectedIndexChanged);
            this.cameraDevices.SelectedValueChanged += new System.EventHandler(this.cameraDevices_SelectedValueChanged);
            // 
            // formats
            // 
            this.formats.FormattingEnabled = true;
            this.formats.Items.AddRange(new object[] {
            "*.bmp",
            "*.gif",
            "*.ico",
            "*.jpeg",
            "*.png",
            "*.tiff"});
            this.formats.Location = new System.Drawing.Point(106, 136);
            this.formats.Name = "formats";
            this.formats.Size = new System.Drawing.Size(129, 21);
            this.formats.TabIndex = 6;
            this.formats.SelectedIndexChanged += new System.EventHandler(this.formats_SelectedIndexChanged);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview.BackgroundImage")));
            this.preview.Location = new System.Drawing.Point(38, 26);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(320, 320);
            this.preview.TabIndex = 7;
            this.preview.TabStop = false;
            // 
            // captured
            // 
            this.captured.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.captured.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("captured.BackgroundImage")));
            this.captured.InitialImage = null;
            this.captured.Location = new System.Drawing.Point(394, 26);
            this.captured.Name = "captured";
            this.captured.Size = new System.Drawing.Size(320, 320);
            this.captured.TabIndex = 8;
            this.captured.TabStop = false;
            // 
            // Frames
            // 
            this.Frames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Frames.Location = new System.Drawing.Point(10, 455);
            this.Frames.Name = "Frames";
            this.Frames.Size = new System.Drawing.Size(976, 218);
            this.Frames.TabIndex = 10;
            // 
            // framesToCapture
            // 
            this.framesToCapture.Location = new System.Drawing.Point(106, 197);
            this.framesToCapture.Name = "framesToCapture";
            this.framesToCapture.Size = new System.Drawing.Size(126, 20);
            this.framesToCapture.TabIndex = 11;
            // 
            // CaptureAll_button
            // 
            this.CaptureAll_button.Location = new System.Drawing.Point(23, 223);
            this.CaptureAll_button.Name = "CaptureAll_button";
            this.CaptureAll_button.Size = new System.Drawing.Size(209, 23);
            this.CaptureAll_button.TabIndex = 12;
            this.CaptureAll_button.Text = "Capture All Frames";
            this.CaptureAll_button.UseVisualStyleBackColor = true;
            this.CaptureAll_button.Click += new System.EventHandler(this.CaptureAll_button_Click);
            // 
            // savingMode
            // 
            this.savingMode.FormattingEnabled = true;
            this.savingMode.Items.AddRange(new object[] {
            "All cameras",
            "Selected camera"});
            this.savingMode.Location = new System.Drawing.Point(25, 91);
            this.savingMode.Name = "savingMode";
            this.savingMode.Size = new System.Drawing.Size(210, 21);
            this.savingMode.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureAndSaveToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearCurrentToolStripMenuItem,
            this.saveCurrentToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // captureAndSaveToolStripMenuItem
            // 
            this.captureAndSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allFramesToolStripMenuItem1,
            this.singleFrameToolStripMenuItem1});
            this.captureAndSaveToolStripMenuItem.Name = "captureAndSaveToolStripMenuItem";
            this.captureAndSaveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.captureAndSaveToolStripMenuItem.Text = "Capture and save";
            // 
            // allFramesToolStripMenuItem1
            // 
            this.allFramesToolStripMenuItem1.Name = "allFramesToolStripMenuItem1";
            this.allFramesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.allFramesToolStripMenuItem1.Text = "All Frames";
            // 
            // singleFrameToolStripMenuItem1
            // 
            this.singleFrameToolStripMenuItem1.Name = "singleFrameToolStripMenuItem1";
            this.singleFrameToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.singleFrameToolStripMenuItem1.Text = "Single Frame";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // clearCurrentToolStripMenuItem
            // 
            this.clearCurrentToolStripMenuItem.Name = "clearCurrentToolStripMenuItem";
            this.clearCurrentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clearCurrentToolStripMenuItem.Text = "Clear current list";
            this.clearCurrentToolStripMenuItem.Click += new System.EventHandler(this.clear_Click);
            // 
            // saveCurrentToolStripMenuItem
            // 
            this.saveCurrentToolStripMenuItem.Name = "saveCurrentToolStripMenuItem";
            this.saveCurrentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveCurrentToolStripMenuItem.Text = "Save current list";
            this.saveCurrentToolStripMenuItem.Click += new System.EventHandler(this.save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator5,
            this.captureToolStripMenuItem,
            this.captureAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.currentCameraToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startToolStripMenuItem.Text = "Start/Play";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.Capture_button_Click);
            // 
            // captureAllToolStripMenuItem
            // 
            this.captureAllToolStripMenuItem.Name = "captureAllToolStripMenuItem";
            this.captureAllToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.captureAllToolStripMenuItem.Text = "Capture All";
            this.captureAllToolStripMenuItem.Click += new System.EventHandler(this.CaptureAll_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // currentCameraToolStripMenuItem
            // 
            this.currentCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDevices});
            this.currentCameraToolStripMenuItem.Name = "currentCameraToolStripMenuItem";
            this.currentCameraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentCameraToolStripMenuItem.Text = "Current Camera";
            // 
            // menuDevices
            // 
            this.menuDevices.Name = "menuDevices";
            this.menuDevices.Size = new System.Drawing.Size(121, 23);
            this.menuDevices.SelectedIndexChanged += new System.EventHandler(this.menuDevices_SelectedIndexChanged);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormats});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // menuFormats
            // 
            this.menuFormats.Items.AddRange(new object[] {
            "*.bmp",
            "*.gif",
            "*.ico",
            "*.jpeg",
            "*.png",
            "*.tif"});
            this.menuFormats.Name = "menuFormats";
            this.menuFormats.Size = new System.Drawing.Size(121, 23);
            this.menuFormats.SelectedIndexChanged += new System.EventHandler(this.menuFormats_SelectedIndexChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator4,
            this.authorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(109, 6);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(738, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 389);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Stop_button);
            this.tabPage1.Controls.Add(this.framesToCapture);
            this.tabPage1.Controls.Add(this.Start_button);
            this.tabPage1.Controls.Add(this.Pause_button);
            this.tabPage1.Controls.Add(this.CaptureAll_button);
            this.tabPage1.Controls.Add(this.Capture_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.AccessibleName = "";
            this.clear.Location = new System.Drawing.Point(297, 429);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(210, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.AccessibleName = "";
            this.save.Location = new System.Drawing.Point(81, 429);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(210, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Capture Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Camera Control";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cameraDevices);
            this.tabPage2.Controls.Add(this.savingMode);
            this.tabPage2.Controls.Add(this.formats);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings & Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Curent Saving Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Saving Format:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Curent Device:";
            // 
            // cameraTab
            // 
            this.cameraTab.Controls.Add(this.cameraPageName);
            this.cameraTab.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cameraTab.Location = new System.Drawing.Point(0, 27);
            this.cameraTab.Name = "cameraTab";
            this.cameraTab.SelectedIndex = 0;
            this.cameraTab.Size = new System.Drawing.Size(758, 389);
            this.cameraTab.TabIndex = 17;
            // 
            // cameraPageName
            // 
            this.cameraPageName.Controls.Add(this.captured);
            this.cameraPageName.Controls.Add(this.preview);
            this.cameraPageName.Location = new System.Drawing.Point(4, 22);
            this.cameraPageName.Name = "cameraPageName";
            this.cameraPageName.Padding = new System.Windows.Forms.Padding(3);
            this.cameraPageName.Size = new System.Drawing.Size(750, 363);
            this.cameraPageName.TabIndex = 1;
            this.cameraPageName.Text = "Current Camera: NaN";
            this.cameraPageName.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Captured:";
            // 
            // savingInterval
            // 
            this.savingInterval.Tick += new System.EventHandler(this.savingInterval_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Frames to save:";
            // 
            // CameraSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(998, 681);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cameraTab);
            this.Controls.Add(this.Frames);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CameraSaver";
            this.Text = "Camera Saver";
            this.Load += new System.EventHandler(this.CameraSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesToCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.cameraTab.ResumeLayout(false);
            this.cameraPageName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button Capture_button;
        private System.Windows.Forms.ComboBox cameraDevices;
        private System.Windows.Forms.ComboBox formats;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.PictureBox captured;
        private System.Windows.Forms.DataGridView Frames;
        private System.Windows.Forms.NumericUpDown framesToCapture;
        private System.Windows.Forms.Button CaptureAll_button;
        private System.Windows.Forms.ComboBox savingMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFramesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singleFrameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem currentCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menuFormats;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl cameraTab;
        private System.Windows.Forms.TabPage cameraPageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripComboBox menuDevices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.Timer savingInterval;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ToolStripMenuItem captureAllToolStripMenuItem;
        private System.Windows.Forms.Label label7;
    }
}