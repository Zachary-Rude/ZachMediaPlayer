using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Media_Player
{
	public partial class SettingsForm : Form
	{
		bool checkCancel = true;
		public SettingsForm()
		{
			InitializeComponent();
			SetTreeViewTheme(treeView1.Handle);
			btnCancel.Enabled = true;

			var isRunningInVS = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("VisualStudioEdition"));
			if (isRunningInVS)
			{
				ini = new IniFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "..\\..\\Inno", "preferences.ini"));
			}
			else
			{
				ini = new IniFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs\\ZachMediaPlayer\\preferences.ini"));
			}

			try
			{
				// General tab
				chkMinimizePause.Checked = bool.Parse(ini.Read("PauseMinimized", "General"));
				chkDisplayTitle.Checked = bool.Parse(ini.Read("EnableTitleDisplay", "General"));
				cbPosition.SelectedIndex = int.Parse(ini.Read("TitleDisplayPosition", "General"));
				chkTaskbarProgress.Checked = bool.Parse(ini.Read("TaskbarProgress", "General"));
				lbPosition.Enabled = chkDisplayTitle.Checked;
				cbPosition.Enabled = chkDisplayTitle.Checked;

				// Audio tab
				tbVolume.Value = int.Parse(ini.Read("DefaultVolume", "Audio"));
				numGain.Value = (decimal)float.Parse(ini.Read("Gain", "Audio"));
				//cbStereo.SelectedIndex = int.Parse(ini.Read("StereoMode", "Audio"));
				chkTimeStretch.Checked = bool.Parse(ini.Read("TimeStretch", "Audio"));

				// MIDI tab
				if (string.IsNullOrEmpty(ini.Read("SoundFont", "Audio.MIDI")) || string.IsNullOrWhiteSpace(ini.Read("SoundFont", "Audio.MIDI")))
					txtSoundFontFile.Text = "";
				else
					txtSoundFontFile.Text = ini.Read("SoundFont", "Audio.MIDI");
				chkChorus.Checked = bool.Parse(ini.Read("SynthChorus", "Audio.MIDI"));
				numSynthGain.Value = (decimal)float.Parse(ini.Read("SynthGain", "Audio.MIDI"));
				numPolyphony.Value = int.Parse(ini.Read("SynthPolyphony", "Audio.MIDI"));
				chkReverb.Checked = bool.Parse(ini.Read("SynthReverb", "Audio.MIDI"));
				numSynthSampleRate.Value = int.Parse(ini.Read("SynthSampleRate", "Audio.MIDI"));

				// Video tab
				chkEnableVideo.Checked = bool.Parse(ini.Read("Enable", "Video"));
				//chkFullscreenVideo.Checked = bool.Parse(ini.Read("PlayVideosInFullScreen", "Video"));
				//chkGrayscale.Checked = bool.Parse(ini.Read("Grayscale", "Video"));
				chkFrameDropping.Checked = bool.Parse(ini.Read("DropFrames", "Video"));
				chkDisableScreensaver.Checked = bool.Parse(ini.Read("DisableScreensaver", "Video"));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		[DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
		private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

		public static void SetTreeViewTheme(IntPtr treeHandle)
		{
			SetWindowTheme(treeHandle, "explorer", null);
		}

		private void saveSettings()
		{
			// General tab
			ini.Write("PauseMinimized", chkMinimizePause.Checked.ToString(), "General");
			ini.Write("EnableTitleDisplay", chkDisplayTitle.Checked.ToString(), "General");
			ini.Write("TitleDisplayPosition", cbPosition.SelectedIndex.ToString(), "General");
			ini.Write("TaskbarProgress", chkTaskbarProgress.Checked.ToString(), "General");

			// Audio tab
			ini.Write("DefaultVolume", tbVolume.Value.ToString(), "Audio");
			ini.Write("Gain", numGain.Value.ToString(), "Audio");
			ini.Write("TimeStretch", chkTimeStretch.Checked.ToString(), "Audio");

			// MIDI tab
			if (string.IsNullOrEmpty(txtSoundFontFile.Text) || string.IsNullOrWhiteSpace(txtSoundFontFile.Text))
				ini.Write("SoundFont", " ", "Audio.MIDI");
			else
				ini.Write("SoundFont", txtSoundFontFile.Text, "Audio.MIDI");

			ini.Write("SynthChorus", chkChorus.Checked.ToString(), "Audio.MIDI");
			ini.Write("SynthGain", numGain.Value.ToString(), "Audio.MIDI");
			ini.Write("SynthPolyphony", numPolyphony.Value.ToString(), "Audio.MIDI");
			ini.Write("SynthChorus", chkReverb.Checked.ToString(), "Audio.MIDI");
			ini.Write("SynthSampleRate", numSynthSampleRate.Value.ToString(), "Audio.MIDI");

			// Video tab
			ini.Write("Enable", chkEnableVideo.Checked.ToString(), "Video");
			//ini.Write("PlayVideosInFullScreen", chkFullscreenVideo.Checked.ToString(), "Video");
			//ini.Write("Grayscale", chkGrayscale.Checked.ToString(), "Video");
			ini.Write("DropFrames", chkFrameDropping.Checked.ToString(), "Video");
			ini.Write("DisableScreensaver", chkDisableScreensaver.Checked.ToString(), "Video");
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			saveSettings();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TreeViewHitTestInfo hit = treeView1.HitTest(e.Location);
			if (hit.Location != TreeViewHitTestLocations.PlusMinus)
			{
				checkCancel = false;
				tabControl1.SelectTab((string)e.Node.Tag);
			}
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
			tabControl1.Selecting += this.tabControl1_Selecting;
		}

		private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
		{
			e.Cancel = checkCancel;
			checkCancel = true;
		}

		private void tbVolume_ValueChanged(object sender, EventArgs e)
		{
			numVolumeDisplay.Value = tbVolume.Value;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "SoundFont Files|*.sf2|All Files|*.*" })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					txtSoundFontFile.Text = ofd.FileName;
				}
			}
		}

		private void chkDisplayTitle_CheckedChanged(object sender, EventArgs e)
		{
			lbPosition.Enabled = chkDisplayTitle.Checked;
			cbPosition.Enabled = chkDisplayTitle.Checked;
		}

		private IniFile ini;
	}
}
