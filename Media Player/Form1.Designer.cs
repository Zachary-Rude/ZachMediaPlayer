namespace Media_Player
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItemFullScreen = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.playPauseMenuItem = new System.Windows.Forms.MenuItem();
			this.stopMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItemSettings = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.vistaMenu1 = new wyDay.Controls.VistaMenu(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.vistaMenu1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6,
            this.menuItem5,
            this.menuItem7,
            this.menuItem9});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem8,
            this.menuItem3,
            this.menuItem22,
            this.menuItem23,
            this.menuItem4});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.vistaMenu1.SetImage(this.menuItem2, global::Media_Player.Properties.Resources.baseline_file_open_black_24dp);
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItem2.Text = "&Open File...";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem8
			// 
			this.vistaMenu1.SetImage(this.menuItem8, global::Media_Player.Properties.Resources.album_16dp_000000);
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "Open &DVD...";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click_1);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// menuItem4
			// 
			this.vistaMenu1.SetImage(this.menuItem4, global::Media_Player.Properties.Resources.baseline_close_black_24dp);
			this.menuItem4.Index = 5;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlQ;
			this.menuItem4.Text = "E&xit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFullScreen});
			this.menuItem6.Text = "&View";
			// 
			// menuItemFullScreen
			// 
			this.vistaMenu1.SetImage(this.menuItemFullScreen, global::Media_Player.Properties.Resources.baseline_fullscreen_black_24dp);
			this.menuItemFullScreen.Index = 0;
			this.menuItemFullScreen.Shortcut = System.Windows.Forms.Shortcut.F11;
			this.menuItemFullScreen.Text = "&Fullscreen";
			this.menuItemFullScreen.Click += new System.EventHandler(this.menuItemFullScreen_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.playPauseMenuItem,
            this.stopMenuItem,
            this.menuItem13,
            this.menuItem14});
			this.menuItem5.Text = "P&layback";
			// 
			// playPauseMenuItem
			// 
			this.vistaMenu1.SetImage(this.playPauseMenuItem, global::Media_Player.Properties.Resources.baseline_play_arrow_black_16dp);
			this.playPauseMenuItem.Index = 0;
			this.playPauseMenuItem.Text = "&Play";
			this.playPauseMenuItem.Click += new System.EventHandler(this.playPauseMenuItem_Click);
			// 
			// stopMenuItem
			// 
			this.stopMenuItem.Enabled = false;
			this.vistaMenu1.SetImage(this.stopMenuItem, global::Media_Player.Properties.Resources.baseline_stop_black_16dp);
			this.stopMenuItem.Index = 1;
			this.stopMenuItem.Text = "&Stop";
			this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "-";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem16,
            this.menuItem17,
            this.menuItem18,
            this.menuItem19,
            this.menuItem20,
            this.menuItem21});
			this.menuItem14.Text = "Sp&eed";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.RadioCheck = true;
			this.menuItem15.Text = "0.25x";
			this.menuItem15.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.RadioCheck = true;
			this.menuItem16.Text = "0.5x";
			this.menuItem16.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 2;
			this.menuItem17.RadioCheck = true;
			this.menuItem17.Text = "0.75x";
			this.menuItem17.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Checked = true;
			this.menuItem18.Index = 3;
			this.menuItem18.RadioCheck = true;
			this.menuItem18.Text = "1x";
			this.menuItem18.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 4;
			this.menuItem19.RadioCheck = true;
			this.menuItem19.Text = "1.25x";
			this.menuItem19.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 5;
			this.menuItem20.RadioCheck = true;
			this.menuItem20.Text = "1.5x";
			this.menuItem20.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 6;
			this.menuItem21.RadioCheck = true;
			this.menuItem21.Text = "2x";
			this.menuItem21.Click += new System.EventHandler(this.speedMenu_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSettings});
			this.menuItem7.Text = "&Tools";
			// 
			// menuItemSettings
			// 
			this.vistaMenu1.SetImage(this.menuItemSettings, global::Media_Player.Properties.Resources.baseline_settings_black_24dp);
			this.menuItemSettings.Index = 0;
			this.menuItemSettings.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.menuItemSettings.Text = "&Settings";
			this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 4;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem11,
            this.menuItem12});
			this.menuItem9.Text = "&Help";
			// 
			// menuItem10
			// 
			this.vistaMenu1.SetImage(this.menuItem10, global::Media_Player.Properties.Resources.baseline_help_black_24dp);
			this.menuItem10.Index = 0;
			this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItem10.Text = "View the &Wiki";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.Text = "-";
			// 
			// menuItem12
			// 
			this.vistaMenu1.SetImage(this.menuItem12, global::Media_Player.Properties.Resources.baseline_info_black_24dp);
			this.menuItem12.Index = 2;
			this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.ShiftF1;
			this.menuItem12.Text = "&About";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// vistaMenu1
			// 
			this.vistaMenu1.ContainerControl = this;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem24});
			this.menuItem22.Text = "&Recent Files";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 4;
			this.menuItem23.Text = "-";
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 0;
			this.menuItem24.Text = "Clear";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(530, 418);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(546, 457);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ZachMediaPlayer";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.vistaMenu1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem playPauseMenuItem;
        private System.Windows.Forms.MenuItem stopMenuItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItemSettings;
        private System.Windows.Forms.MenuItem menuItemFullScreen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private wyDay.Controls.VistaMenu vistaMenu1;
        private MediaPlayer Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
	}
}

