namespace Media_Player
{
    partial class MediaPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tbVolume = new System.Windows.Forms.TrackBar();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblCurrentTime = new System.Windows.Forms.Label();
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.tbSeek = new System.Windows.Forms.TrackBar();
			this.btnRepeat = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnPlaylist = new System.Windows.Forms.Button();
			this.btnFastForward = new System.Windows.Forms.Button();
			this.btnRewind = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.playButtonTimer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.InternalPlayer = new LibVLCSharp.WinForms.VideoView();
			((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSeek)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InternalPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// tbVolume
			// 
			this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbVolume.Location = new System.Drawing.Point(489, 461);
			this.tbVolume.Maximum = 125;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new System.Drawing.Size(79, 45);
			this.tbVolume.TabIndex = 7;
			this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
			this.toolTip1.SetToolTip(this.tbVolume, "Volume");
			this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
			// 
			// lblCurrentTime
			// 
			this.lblCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCurrentTime.AutoSize = true;
			this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentTime.Location = new System.Drawing.Point(3, 7);
			this.lblCurrentTime.Name = "lblCurrentTime";
			this.lblCurrentTime.Size = new System.Drawing.Size(25, 15);
			this.lblCurrentTime.TabIndex = 10;
			this.lblCurrentTime.Text = "-:--";
			this.toolTip1.SetToolTip(this.lblCurrentTime, "Elapsed time");
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblTotalTime.AutoSize = true;
			this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalTime.Location = new System.Drawing.Point(540, 7);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(25, 15);
			this.lblTotalTime.TabIndex = 11;
			this.lblTotalTime.Text = "-:--";
			this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.toolTip1.SetToolTip(this.lblTotalTime, "Total/Remaining time (click to toggle)");
			this.lblTotalTime.Click += new System.EventHandler(this.lblTotalTime_Click);
			// 
			// tbSeek
			// 
			this.tbSeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSeek.AutoSize = false;
			this.tbSeek.Location = new System.Drawing.Point(34, 3);
			this.tbSeek.Maximum = 0;
			this.tbSeek.Name = "tbSeek";
			this.tbSeek.Size = new System.Drawing.Size(500, 24);
			this.tbSeek.TabIndex = 9;
			this.tbSeek.TickStyle = System.Windows.Forms.TickStyle.None;
			this.toolTip1.SetToolTip(this.tbSeek, "Seek");
			this.tbSeek.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// btnRepeat
			// 
			this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRepeat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRepeat.Image = global::Media_Player.Properties.Resources.repeat_24dp_000000;
			this.btnRepeat.Location = new System.Drawing.Point(300, 461);
			this.btnRepeat.Name = "btnRepeat";
			this.btnRepeat.Size = new System.Drawing.Size(33, 33);
			this.btnRepeat.TabIndex = 16;
			this.toolTip1.SetToolTip(this.btnRepeat, "Repeat");
			this.btnRepeat.UseVisualStyleBackColor = true;
			this.btnRepeat.Visible = false;
			this.btnRepeat.Enter += new System.EventHandler(this.button_Enter);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Image = global::Media_Player.Properties.Resources.skip_next_24dp_000000;
			this.btnNext.Location = new System.Drawing.Point(261, 461);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(33, 33);
			this.btnNext.TabIndex = 15;
			this.toolTip1.SetToolTip(this.btnNext, "Next");
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Visible = false;
			this.btnNext.Enter += new System.EventHandler(this.button_Enter);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevious.Image = global::Media_Player.Properties.Resources.skip_previous_24dp_000000;
			this.btnPrevious.Location = new System.Drawing.Point(183, 461);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(33, 33);
			this.btnPrevious.TabIndex = 14;
			this.toolTip1.SetToolTip(this.btnPrevious, "Previous");
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Visible = false;
			this.btnPrevious.Enter += new System.EventHandler(this.button_Enter);
			// 
			// btnPlaylist
			// 
			this.btnPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlaylist.Image = global::Media_Player.Properties.Resources.baseline_playlist_play_24dp_000000;
			this.btnPlaylist.Location = new System.Drawing.Point(222, 461);
			this.btnPlaylist.Name = "btnPlaylist";
			this.btnPlaylist.Size = new System.Drawing.Size(33, 33);
			this.btnPlaylist.TabIndex = 13;
			this.toolTip1.SetToolTip(this.btnPlaylist, "View playlist");
			this.btnPlaylist.UseVisualStyleBackColor = true;
			this.btnPlaylist.Visible = false;
			this.btnPlaylist.Enter += new System.EventHandler(this.button_Enter);
			// 
			// btnFastForward
			// 
			this.btnFastForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFastForward.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFastForward.Image = global::Media_Player.Properties.Resources.fast_forward_24dp_000000;
			this.btnFastForward.Location = new System.Drawing.Point(133, 461);
			this.btnFastForward.Name = "btnFastForward";
			this.btnFastForward.Size = new System.Drawing.Size(33, 33);
			this.btnFastForward.TabIndex = 12;
			this.toolTip1.SetToolTip(this.btnFastForward, "Fast forward");
			this.btnFastForward.UseVisualStyleBackColor = true;
			this.btnFastForward.Enter += new System.EventHandler(this.button_Enter);
			this.btnFastForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFastForward_MouseDown);
			this.btnFastForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFastForward_MouseUp);
			// 
			// btnRewind
			// 
			this.btnRewind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRewind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRewind.Image = global::Media_Player.Properties.Resources.fast_rewind_24dp_000000;
			this.btnRewind.Location = new System.Drawing.Point(55, 461);
			this.btnRewind.Name = "btnRewind";
			this.btnRewind.Size = new System.Drawing.Size(33, 33);
			this.btnRewind.TabIndex = 11;
			this.toolTip1.SetToolTip(this.btnRewind, "Rewind");
			this.btnRewind.UseVisualStyleBackColor = true;
			this.btnRewind.Enter += new System.EventHandler(this.button_Enter);
			this.btnRewind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRewind_MouseDown);
			this.btnRewind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRewind_MouseUp);
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.Image = global::Media_Player.Properties.Resources.baseline_stop_black_24dp;
			this.btnStop.Location = new System.Drawing.Point(94, 461);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(33, 33);
			this.btnStop.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnStop, "Stop");
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			this.btnStop.Enter += new System.EventHandler(this.button_Enter);
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.Image = global::Media_Player.Properties.Resources.baseline_play_arrow_black_24dp;
			this.btnPlay.Location = new System.Drawing.Point(3, 461);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(33, 33);
			this.btnPlay.TabIndex = 3;
			this.toolTip1.SetToolTip(this.btnPlay, "Play");
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			this.btnPlay.Enter += new System.EventHandler(this.button_Enter);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// playButtonTimer
			// 
			this.playButtonTimer.Tick += new System.EventHandler(this.playButtonTimer_Tick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.lblCurrentTime, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbSeek, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTotalTime, 2, 0);
			this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 429);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 26);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::Media_Player.Properties.Resources.baseline_volume_up_black_24dp;
			this.pictureBox1.Location = new System.Drawing.Point(450, 456);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 33);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Media_Player.Properties.Resources.mediaplayerlogo_small;
			this.pictureBox2.Location = new System.Drawing.Point(133, 93);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Size = new System.Drawing.Size(262, 214);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox2_LoadCompleted);
			this.pictureBox2.Resize += new System.EventHandler(this.pictureBox2_Resize);
			// 
			// InternalPlayer
			// 
			this.InternalPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InternalPlayer.BackColor = System.Drawing.Color.Black;
			this.InternalPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.InternalPlayer.Location = new System.Drawing.Point(0, 0);
			this.InternalPlayer.MediaPlayer = null;
			this.InternalPlayer.Name = "InternalPlayer";
			this.InternalPlayer.Size = new System.Drawing.Size(568, 429);
			this.InternalPlayer.TabIndex = 9;
			// 
			// MediaPlayer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnRepeat);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnPlaylist);
			this.Controls.Add(this.btnFastForward);
			this.Controls.Add(this.btnRewind);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.InternalPlayer);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tbVolume);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPlay);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MediaPlayer";
			this.Size = new System.Drawing.Size(568, 497);
			((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSeek)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InternalPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer playButtonTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        public System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnRewind;
		private System.Windows.Forms.Button btnFastForward;
		public System.Windows.Forms.TrackBar tbSeek;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnPlaylist;
		private System.Windows.Forms.Button btnRepeat;
		private System.Windows.Forms.PictureBox pictureBox2;
		public LibVLCSharp.WinForms.VideoView InternalPlayer;
	}
}
