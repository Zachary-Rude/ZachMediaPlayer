namespace Media_Player
{
    partial class SettingsForm
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
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("General");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("MIDI");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Audio", new System.Windows.Forms.TreeNode[] {
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Video");
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpGeneral = new System.Windows.Forms.TabPage();
			this.chkTaskbarProgress = new System.Windows.Forms.CheckBox();
			this.chkMinimizePause = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbGeneral = new System.Windows.Forms.Label();
			this.gbTitle = new System.Windows.Forms.GroupBox();
			this.cbPosition = new System.Windows.Forms.ComboBox();
			this.lbPosition = new System.Windows.Forms.Label();
			this.chkDisplayTitle = new System.Windows.Forms.CheckBox();
			this.tpAudio = new System.Windows.Forms.TabPage();
			this.lbGain = new System.Windows.Forms.Label();
			this.numGain = new System.Windows.Forms.NumericUpDown();
			this.lbAudioFilter = new System.Windows.Forms.Label();
			this.cbAudioFilter = new System.Windows.Forms.ComboBox();
			this.chkTimeStretch = new System.Windows.Forms.CheckBox();
			this.numVolumeDisplay = new System.Windows.Forms.NumericUpDown();
			this.tbVolume = new System.Windows.Forms.TrackBar();
			this.lbDefaultVolume = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbAudio = new System.Windows.Forms.Label();
			this.tpMIDI = new System.Windows.Forms.TabPage();
			this.lbSynthSampleRate = new System.Windows.Forms.Label();
			this.numSynthSampleRate = new System.Windows.Forms.NumericUpDown();
			this.chkReverb = new System.Windows.Forms.CheckBox();
			this.lbPolyphony = new System.Windows.Forms.Label();
			this.numPolyphony = new System.Windows.Forms.NumericUpDown();
			this.lbSynthGain = new System.Windows.Forms.Label();
			this.numSynthGain = new System.Windows.Forms.NumericUpDown();
			this.chkChorus = new System.Windows.Forms.CheckBox();
			this.txtSoundFontFile = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.lbSoundFont = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbMIDI = new System.Windows.Forms.Label();
			this.tpVideo = new System.Windows.Forms.TabPage();
			this.chkDisableScreensaver = new System.Windows.Forms.CheckBox();
			this.chkFrameDropping = new System.Windows.Forms.CheckBox();
			this.chkEnableVideo = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbVideo = new System.Windows.Forms.Label();
			this.lbNote = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpGeneral.SuspendLayout();
			this.gbTitle.SuspendLayout();
			this.tpAudio.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numGain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numVolumeDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
			this.tpMIDI.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSynthSampleRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPolyphony)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSynthGain)).BeginInit();
			this.tpVideo.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOk.Location = new System.Drawing.Point(560, 462);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.TabStop = false;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(641, 462);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(704, 444);
			this.splitContainer1.SplitterDistance = 179;
			this.splitContainer1.TabIndex = 4;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.HideSelection = false;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode5.Name = "Node0";
			treeNode5.Tag = "tpGeneral";
			treeNode5.Text = "General";
			treeNode6.Name = "Node3";
			treeNode6.Tag = "tpMIDI";
			treeNode6.Text = "MIDI";
			treeNode7.Name = "Node1";
			treeNode7.Tag = "tpAudio";
			treeNode7.Text = "Audio";
			treeNode8.Name = "Node4";
			treeNode8.Tag = "tpVideo";
			treeNode8.Text = "Video";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode8});
			this.treeView1.Size = new System.Drawing.Size(179, 444);
			this.treeView1.TabIndex = 0;
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(521, 444);
			this.panel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpGeneral);
			this.tabControl1.Controls.Add(this.tpAudio);
			this.tabControl1.Controls.Add(this.tpMIDI);
			this.tabControl1.Controls.Add(this.tpVideo);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ItemSize = new System.Drawing.Size(61, 20);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(519, 442);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.TabStop = false;
			// 
			// tpGeneral
			// 
			this.tpGeneral.AutoScroll = true;
			this.tpGeneral.Controls.Add(this.chkTaskbarProgress);
			this.tpGeneral.Controls.Add(this.chkMinimizePause);
			this.tpGeneral.Controls.Add(this.label1);
			this.tpGeneral.Controls.Add(this.lbGeneral);
			this.tpGeneral.Controls.Add(this.gbTitle);
			this.tpGeneral.Location = new System.Drawing.Point(4, 24);
			this.tpGeneral.Name = "tpGeneral";
			this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tpGeneral.Size = new System.Drawing.Size(511, 414);
			this.tpGeneral.TabIndex = 0;
			this.tpGeneral.Text = "General";
			// 
			// chkTaskbarProgress
			// 
			this.chkTaskbarProgress.AutoSize = true;
			this.chkTaskbarProgress.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTaskbarProgress.Location = new System.Drawing.Point(10, 72);
			this.chkTaskbarProgress.Name = "chkTaskbarProgress";
			this.chkTaskbarProgress.Size = new System.Drawing.Size(156, 20);
			this.chkTaskbarProgress.TabIndex = 5;
			this.chkTaskbarProgress.Text = "Enable taskbar progress";
			this.chkTaskbarProgress.UseVisualStyleBackColor = true;
			// 
			// chkMinimizePause
			// 
			this.chkMinimizePause.AutoSize = true;
			this.chkMinimizePause.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkMinimizePause.Location = new System.Drawing.Point(10, 46);
			this.chkMinimizePause.Name = "chkMinimizePause";
			this.chkMinimizePause.Size = new System.Drawing.Size(190, 20);
			this.chkMinimizePause.TabIndex = 4;
			this.chkMinimizePause.Text = "Pause media when minimized";
			this.chkMinimizePause.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(10, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(482, 2);
			this.label1.TabIndex = 3;
			// 
			// lbGeneral
			// 
			this.lbGeneral.AutoSize = true;
			this.lbGeneral.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGeneral.Location = new System.Drawing.Point(10, 7);
			this.lbGeneral.Name = "lbGeneral";
			this.lbGeneral.Size = new System.Drawing.Size(174, 30);
			this.lbGeneral.TabIndex = 2;
			this.lbGeneral.Text = "General Settings";
			// 
			// gbTitle
			// 
			this.gbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbTitle.Controls.Add(this.cbPosition);
			this.gbTitle.Controls.Add(this.lbPosition);
			this.gbTitle.Controls.Add(this.chkDisplayTitle);
			this.gbTitle.Location = new System.Drawing.Point(10, 98);
			this.gbTitle.Name = "gbTitle";
			this.gbTitle.Size = new System.Drawing.Size(495, 87);
			this.gbTitle.TabIndex = 1;
			this.gbTitle.TabStop = false;
			this.gbTitle.Text = "On-Screen Display";
			// 
			// cbPosition
			// 
			this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbPosition.FormattingEnabled = true;
			this.cbPosition.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right",
            "Top",
            "Top Left",
            "Top Right",
            "Bottom",
            "Bottom Left",
            "Bottom Right"});
			this.cbPosition.Location = new System.Drawing.Point(94, 47);
			this.cbPosition.Name = "cbPosition";
			this.cbPosition.Size = new System.Drawing.Size(121, 23);
			this.cbPosition.TabIndex = 2;
			// 
			// lbPosition
			// 
			this.lbPosition.AutoSize = true;
			this.lbPosition.Location = new System.Drawing.Point(38, 50);
			this.lbPosition.Name = "lbPosition";
			this.lbPosition.Size = new System.Drawing.Size(50, 15);
			this.lbPosition.TabIndex = 1;
			this.lbPosition.Text = "Position";
			// 
			// chkDisplayTitle
			// 
			this.chkDisplayTitle.AutoSize = true;
			this.chkDisplayTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkDisplayTitle.Location = new System.Drawing.Point(7, 23);
			this.chkDisplayTitle.Name = "chkDisplayTitle";
			this.chkDisplayTitle.Size = new System.Drawing.Size(195, 20);
			this.chkDisplayTitle.TabIndex = 0;
			this.chkDisplayTitle.Text = "Show media title on video start";
			this.chkDisplayTitle.UseVisualStyleBackColor = true;
			this.chkDisplayTitle.CheckedChanged += new System.EventHandler(this.chkDisplayTitle_CheckedChanged);
			// 
			// tpAudio
			// 
			this.tpAudio.Controls.Add(this.lbGain);
			this.tpAudio.Controls.Add(this.numGain);
			this.tpAudio.Controls.Add(this.lbAudioFilter);
			this.tpAudio.Controls.Add(this.cbAudioFilter);
			this.tpAudio.Controls.Add(this.chkTimeStretch);
			this.tpAudio.Controls.Add(this.numVolumeDisplay);
			this.tpAudio.Controls.Add(this.tbVolume);
			this.tpAudio.Controls.Add(this.lbDefaultVolume);
			this.tpAudio.Controls.Add(this.label2);
			this.tpAudio.Controls.Add(this.lbAudio);
			this.tpAudio.Location = new System.Drawing.Point(4, 24);
			this.tpAudio.Name = "tpAudio";
			this.tpAudio.Padding = new System.Windows.Forms.Padding(3);
			this.tpAudio.Size = new System.Drawing.Size(511, 414);
			this.tpAudio.TabIndex = 1;
			this.tpAudio.Text = "Audio";
			// 
			// lbGain
			// 
			this.lbGain.AutoSize = true;
			this.lbGain.Location = new System.Drawing.Point(10, 132);
			this.lbGain.Name = "lbGain";
			this.lbGain.Size = new System.Drawing.Size(31, 15);
			this.lbGain.TabIndex = 18;
			this.lbGain.Text = "Gain";
			// 
			// numGain
			// 
			this.numGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numGain.DecimalPlaces = 2;
			this.numGain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numGain.Location = new System.Drawing.Point(398, 130);
			this.numGain.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numGain.Name = "numGain";
			this.numGain.Size = new System.Drawing.Size(92, 23);
			this.numGain.TabIndex = 17;
			this.numGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbAudioFilter
			// 
			this.lbAudioFilter.AutoSize = true;
			this.lbAudioFilter.Location = new System.Drawing.Point(10, 104);
			this.lbAudioFilter.Name = "lbAudioFilter";
			this.lbAudioFilter.Size = new System.Drawing.Size(33, 15);
			this.lbAudioFilter.TabIndex = 16;
			this.lbAudioFilter.Text = "Filter";
			// 
			// cbAudioFilter
			// 
			this.cbAudioFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbAudioFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAudioFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbAudioFilter.FormattingEnabled = true;
			this.cbAudioFilter.Items.AddRange(new object[] {
            "Stereo widen"});
			this.cbAudioFilter.Location = new System.Drawing.Point(369, 101);
			this.cbAudioFilter.Name = "cbAudioFilter";
			this.cbAudioFilter.Size = new System.Drawing.Size(121, 23);
			this.cbAudioFilter.TabIndex = 15;
			// 
			// chkTimeStretch
			// 
			this.chkTimeStretch.AutoSize = true;
			this.chkTimeStretch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTimeStretch.Location = new System.Drawing.Point(10, 75);
			this.chkTimeStretch.Name = "chkTimeStretch";
			this.chkTimeStretch.Size = new System.Drawing.Size(183, 20);
			this.chkTimeStretch.TabIndex = 14;
			this.chkTimeStretch.Text = "Enable time stretching audio";
			this.chkTimeStretch.UseVisualStyleBackColor = true;
			// 
			// numVolumeDisplay
			// 
			this.numVolumeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numVolumeDisplay.Location = new System.Drawing.Point(426, 46);
			this.numVolumeDisplay.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
			this.numVolumeDisplay.Name = "numVolumeDisplay";
			this.numVolumeDisplay.ReadOnly = true;
			this.numVolumeDisplay.Size = new System.Drawing.Size(64, 23);
			this.numVolumeDisplay.TabIndex = 9;
			this.numVolumeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbVolume
			// 
			this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbVolume.Location = new System.Drawing.Point(104, 45);
			this.tbVolume.Maximum = 125;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new System.Drawing.Size(316, 45);
			this.tbVolume.TabIndex = 8;
			this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
			// 
			// lbDefaultVolume
			// 
			this.lbDefaultVolume.AutoSize = true;
			this.lbDefaultVolume.Location = new System.Drawing.Point(10, 46);
			this.lbDefaultVolume.Name = "lbDefaultVolume";
			this.lbDefaultVolume.Size = new System.Drawing.Size(88, 15);
			this.lbDefaultVolume.TabIndex = 7;
			this.lbDefaultVolume.Text = "Default volume";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(10, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(480, 2);
			this.label2.TabIndex = 5;
			// 
			// lbAudio
			// 
			this.lbAudio.AutoSize = true;
			this.lbAudio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAudio.Location = new System.Drawing.Point(10, 7);
			this.lbAudio.Name = "lbAudio";
			this.lbAudio.Size = new System.Drawing.Size(159, 30);
			this.lbAudio.TabIndex = 4;
			this.lbAudio.Text = "Audio Settings";
			// 
			// tpMIDI
			// 
			this.tpMIDI.Controls.Add(this.lbSynthSampleRate);
			this.tpMIDI.Controls.Add(this.numSynthSampleRate);
			this.tpMIDI.Controls.Add(this.chkReverb);
			this.tpMIDI.Controls.Add(this.lbPolyphony);
			this.tpMIDI.Controls.Add(this.numPolyphony);
			this.tpMIDI.Controls.Add(this.lbSynthGain);
			this.tpMIDI.Controls.Add(this.numSynthGain);
			this.tpMIDI.Controls.Add(this.chkChorus);
			this.tpMIDI.Controls.Add(this.txtSoundFontFile);
			this.tpMIDI.Controls.Add(this.btnBrowse);
			this.tpMIDI.Controls.Add(this.lbSoundFont);
			this.tpMIDI.Controls.Add(this.label3);
			this.tpMIDI.Controls.Add(this.lbMIDI);
			this.tpMIDI.Location = new System.Drawing.Point(4, 24);
			this.tpMIDI.Name = "tpMIDI";
			this.tpMIDI.Size = new System.Drawing.Size(511, 414);
			this.tpMIDI.TabIndex = 2;
			this.tpMIDI.Text = "MIDI";
			// 
			// lbSynthSampleRate
			// 
			this.lbSynthSampleRate.AutoSize = true;
			this.lbSynthSampleRate.Location = new System.Drawing.Point(10, 188);
			this.lbSynthSampleRate.Name = "lbSynthSampleRate";
			this.lbSynthSampleRate.Size = new System.Drawing.Size(69, 15);
			this.lbSynthSampleRate.TabIndex = 18;
			this.lbSynthSampleRate.Text = "Sample rate";
			// 
			// numSynthSampleRate
			// 
			this.numSynthSampleRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numSynthSampleRate.Location = new System.Drawing.Point(398, 186);
			this.numSynthSampleRate.Maximum = new decimal(new int[] {
            96000,
            0,
            0,
            0});
			this.numSynthSampleRate.Minimum = new decimal(new int[] {
            22050,
            0,
            0,
            0});
			this.numSynthSampleRate.Name = "numSynthSampleRate";
			this.numSynthSampleRate.Size = new System.Drawing.Size(92, 23);
			this.numSynthSampleRate.TabIndex = 17;
			this.numSynthSampleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSynthSampleRate.Value = new decimal(new int[] {
            22050,
            0,
            0,
            0});
			// 
			// chkReverb
			// 
			this.chkReverb.AutoSize = true;
			this.chkReverb.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkReverb.Location = new System.Drawing.Point(10, 160);
			this.chkReverb.Name = "chkReverb";
			this.chkReverb.Size = new System.Drawing.Size(103, 20);
			this.chkReverb.TabIndex = 16;
			this.chkReverb.Text = "Enable reverb";
			this.chkReverb.UseVisualStyleBackColor = true;
			// 
			// lbPolyphony
			// 
			this.lbPolyphony.AutoSize = true;
			this.lbPolyphony.Location = new System.Drawing.Point(10, 133);
			this.lbPolyphony.Name = "lbPolyphony";
			this.lbPolyphony.Size = new System.Drawing.Size(64, 15);
			this.lbPolyphony.TabIndex = 15;
			this.lbPolyphony.Text = "Polyphony";
			// 
			// numPolyphony
			// 
			this.numPolyphony.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numPolyphony.Location = new System.Drawing.Point(398, 131);
			this.numPolyphony.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numPolyphony.Name = "numPolyphony";
			this.numPolyphony.Size = new System.Drawing.Size(92, 23);
			this.numPolyphony.TabIndex = 14;
			this.numPolyphony.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbSynthGain
			// 
			this.lbSynthGain.AutoSize = true;
			this.lbSynthGain.Location = new System.Drawing.Point(10, 104);
			this.lbSynthGain.Name = "lbSynthGain";
			this.lbSynthGain.Size = new System.Drawing.Size(82, 15);
			this.lbSynthGain.TabIndex = 13;
			this.lbSynthGain.Text = "Synthesis gain";
			// 
			// numSynthGain
			// 
			this.numSynthGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numSynthGain.DecimalPlaces = 2;
			this.numSynthGain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numSynthGain.Location = new System.Drawing.Point(398, 102);
			this.numSynthGain.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numSynthGain.Name = "numSynthGain";
			this.numSynthGain.Size = new System.Drawing.Size(92, 23);
			this.numSynthGain.TabIndex = 12;
			this.numSynthGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkChorus
			// 
			this.chkChorus.AutoSize = true;
			this.chkChorus.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkChorus.Location = new System.Drawing.Point(10, 76);
			this.chkChorus.Name = "chkChorus";
			this.chkChorus.Size = new System.Drawing.Size(106, 20);
			this.chkChorus.TabIndex = 11;
			this.chkChorus.Text = "Enable chorus";
			this.chkChorus.UseVisualStyleBackColor = true;
			// 
			// txtSoundFontFile
			// 
			this.txtSoundFontFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoundFontFile.Location = new System.Drawing.Point(196, 47);
			this.txtSoundFontFile.Name = "txtSoundFontFile";
			this.txtSoundFontFile.Size = new System.Drawing.Size(213, 23);
			this.txtSoundFontFile.TabIndex = 10;
			this.txtSoundFontFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnBrowse.Location = new System.Drawing.Point(415, 46);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 9;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// lbSoundFont
			// 
			this.lbSoundFont.AutoSize = true;
			this.lbSoundFont.Location = new System.Drawing.Point(12, 50);
			this.lbSoundFont.Name = "lbSoundFont";
			this.lbSoundFont.Size = new System.Drawing.Size(84, 15);
			this.lbSoundFont.TabIndex = 8;
			this.lbSoundFont.Text = "SoundFont file";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(10, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(480, 2);
			this.label3.TabIndex = 7;
			// 
			// lbMIDI
			// 
			this.lbMIDI.AutoSize = true;
			this.lbMIDI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMIDI.Location = new System.Drawing.Point(10, 7);
			this.lbMIDI.Name = "lbMIDI";
			this.lbMIDI.Size = new System.Drawing.Size(148, 30);
			this.lbMIDI.TabIndex = 6;
			this.lbMIDI.Text = "MIDI Settings";
			// 
			// tpVideo
			// 
			this.tpVideo.Controls.Add(this.chkDisableScreensaver);
			this.tpVideo.Controls.Add(this.chkFrameDropping);
			this.tpVideo.Controls.Add(this.chkEnableVideo);
			this.tpVideo.Controls.Add(this.label4);
			this.tpVideo.Controls.Add(this.lbVideo);
			this.tpVideo.Location = new System.Drawing.Point(4, 24);
			this.tpVideo.Name = "tpVideo";
			this.tpVideo.Size = new System.Drawing.Size(511, 414);
			this.tpVideo.TabIndex = 3;
			this.tpVideo.Text = "Video";
			// 
			// chkDisableScreensaver
			// 
			this.chkDisableScreensaver.AutoSize = true;
			this.chkDisableScreensaver.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkDisableScreensaver.Location = new System.Drawing.Point(10, 98);
			this.chkDisableScreensaver.Name = "chkDisableScreensaver";
			this.chkDisableScreensaver.Size = new System.Drawing.Size(134, 20);
			this.chkDisableScreensaver.TabIndex = 11;
			this.chkDisableScreensaver.Text = "Disable screensaver";
			this.chkDisableScreensaver.UseVisualStyleBackColor = true;
			// 
			// chkFrameDropping
			// 
			this.chkFrameDropping.AutoSize = true;
			this.chkFrameDropping.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkFrameDropping.Location = new System.Drawing.Point(10, 72);
			this.chkFrameDropping.Name = "chkFrameDropping";
			this.chkFrameDropping.Size = new System.Drawing.Size(117, 20);
			this.chkFrameDropping.TabIndex = 10;
			this.chkFrameDropping.Text = "Frame dropping";
			this.chkFrameDropping.UseVisualStyleBackColor = true;
			// 
			// chkEnableVideo
			// 
			this.chkEnableVideo.AutoSize = true;
			this.chkEnableVideo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkEnableVideo.Location = new System.Drawing.Point(10, 46);
			this.chkEnableVideo.Name = "chkEnableVideo";
			this.chkEnableVideo.Size = new System.Drawing.Size(99, 20);
			this.chkEnableVideo.TabIndex = 7;
			this.chkEnableVideo.Text = "Enable video";
			this.chkEnableVideo.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(10, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(482, 2);
			this.label4.TabIndex = 5;
			// 
			// lbVideo
			// 
			this.lbVideo.AutoSize = true;
			this.lbVideo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbVideo.Location = new System.Drawing.Point(10, 7);
			this.lbVideo.Name = "lbVideo";
			this.lbVideo.Size = new System.Drawing.Size(156, 30);
			this.lbVideo.TabIndex = 4;
			this.lbVideo.Text = "Video Settings";
			// 
			// lbNote
			// 
			this.lbNote.AutoSize = true;
			this.lbNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNote.Location = new System.Drawing.Point(317, 466);
			this.lbNote.Name = "lbNote";
			this.lbNote.Size = new System.Drawing.Size(237, 15);
			this.lbNote.TabIndex = 19;
			this.lbNote.Text = "Note: Most options require a restart to apply";
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(728, 497);
			this.Controls.Add(this.lbNote);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tpGeneral.ResumeLayout(false);
			this.tpGeneral.PerformLayout();
			this.gbTitle.ResumeLayout(false);
			this.gbTitle.PerformLayout();
			this.tpAudio.ResumeLayout(false);
			this.tpAudio.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numGain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numVolumeDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
			this.tpMIDI.ResumeLayout(false);
			this.tpMIDI.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSynthSampleRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPolyphony)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSynthGain)).EndInit();
			this.tpVideo.ResumeLayout(false);
			this.tpVideo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpGeneral;
		private System.Windows.Forms.GroupBox gbTitle;
		private System.Windows.Forms.Label lbGeneral;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkMinimizePause;
		private System.Windows.Forms.CheckBox chkDisplayTitle;
		private System.Windows.Forms.ComboBox cbPosition;
		private System.Windows.Forms.Label lbPosition;
		private System.Windows.Forms.TabPage tpMIDI;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbMIDI;
		private System.Windows.Forms.Label lbSoundFont;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtSoundFontFile;
		private System.Windows.Forms.CheckBox chkChorus;
		private System.Windows.Forms.NumericUpDown numSynthGain;
		private System.Windows.Forms.Label lbSynthGain;
		private System.Windows.Forms.Label lbPolyphony;
		private System.Windows.Forms.NumericUpDown numPolyphony;
		private System.Windows.Forms.CheckBox chkReverb;
		private System.Windows.Forms.Label lbSynthSampleRate;
		private System.Windows.Forms.NumericUpDown numSynthSampleRate;
		private System.Windows.Forms.TabPage tpVideo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbVideo;
		private System.Windows.Forms.CheckBox chkEnableVideo;
		private System.Windows.Forms.CheckBox chkFrameDropping;
		private System.Windows.Forms.CheckBox chkDisableScreensaver;
		private System.Windows.Forms.TabPage tpAudio;
		private System.Windows.Forms.CheckBox chkTimeStretch;
		private System.Windows.Forms.NumericUpDown numVolumeDisplay;
		private System.Windows.Forms.TrackBar tbVolume;
		private System.Windows.Forms.Label lbDefaultVolume;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbAudio;
		private System.Windows.Forms.ComboBox cbAudioFilter;
		private System.Windows.Forms.Label lbAudioFilter;
		private System.Windows.Forms.Label lbGain;
		private System.Windows.Forms.NumericUpDown numGain;
		private System.Windows.Forms.Label lbNote;
		private System.Windows.Forms.CheckBox chkTaskbarProgress;
	}
}