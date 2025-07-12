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
using System.Diagnostics;
using LibVLCSharp.Shared;
using LibVLCSharp.Shared.Structures;
using LibVLCSharp.WinForms;
using System.Threading;
using TagLib;

namespace Media_Player
{
	[DisplayName("MediaPlayer")]
	[Description("Provides a graphical user interface for playing media files.")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(MediaPlayer), "baseline_play_arrow_black_16dp.bmp")]
	public partial class MediaPlayer : UserControl
	{
		public LibVLC libVLC;

		[Category("Media Player")]
		[Description("The audio volume for the player.")]
		[DefaultValue(100)]
		public int Volume { get; set; } = 100;

		[Category("Media Player")]
		[Description("Indicates whether media playback has been stopped.")]
		public bool Stopped { get { return _stopped; } }
		private bool _stopped = true;

		[Category("Media Player")]
		[Description("The path or URL of the media currently opened in the player.")]
		public string CurrentMedia { get { return _currentMedia; } }
		private string _currentMedia = null;
		private string _previousMedia = null; // Used for when the media is stopped

		[Category("Media Player")]
		[Description("Indicates whether the player is currently playing any media.")]
		public bool IsPlaying { get { return InternalPlayer.MediaPlayer.IsPlaying; } }

		[Category("Media Player")]
		[Description("Indicates whether media playback is paused.")]
		public bool IsPaused {
			get
			{
				return _isPaused;
			}
			private set
			{
				if (value != _isPaused)
				{
					_isPaused = value;
				}
			}
		}
		private bool _isPaused = false;

		[Category("Appearance")]
		[Description("Indicates whether the media controls are visible.")]
		[DefaultValue(true)]
		public bool ShowControls { get; set; } = true;

		private bool _showRemainingTime = false;

		private bool _rewinding = false;

		private bool _fastForward = false;

		public event EventHandler Paused;

		private int _previousVolume;

		List<string> playlist = new List<string>();

		public MediaPlayer()
		{
			InitializeComponent();
			var isRunningInVS = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("VisualStudioEdition"));
			IniFile ini;
			if (isRunningInVS)
			{
				ini = new IniFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "..\\..\\Inno", "preferences.ini"));
			}
			else
			{
				ini = new IniFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs\\ZachMediaPlayer\\preferences.ini"));
			}
			string[] options = new string[] {
				// Audio section
				(ini.Read("TimeStretch", "Audio") == "True" ? "--audio-time-stretch" : "--no-audio-time-stretch"),
				$"--gain={ini.Read("Gain", "Audio")}",
				// MIDI Section
				(!string.IsNullOrWhiteSpace(ini.Read("SoundFont", "Audio.MIDI")) ? $"--soundfont={ini.Read("SoundFont", "Audio.MIDI").Replace("\\", "\\\\")}" : ""),
				(ini.Read("SynthChorus", "Audio.MIDI") == "True" ? "--synth-chorus" : "--no-synth-chorus"),
				$"--synth-gain={ini.Read("SynthGain", "Audio.MIDI")}",
				$"--synth-polyphony={ini.Read("SynthPolyphony", "Audio.MIDI")}",
				(ini.Read("SynthReverb", "Audio.MIDI") == "True" ? "--synth-reverb" : "--no-synth-reverb"),
				$"--synth-sample-rate={ini.Read("SynthSampleRate", "Audio.MIDI")}",
				// Video section
				(ini.Read("Enable", "Video") == "True" ? "--video" : "--no-video"),
				(ini.Read("DisableScreensaver", "Video") == "True" ? "--disable-screensaver" : "--no-disable-screensaver")
			};
			libVLC = new LibVLC(options);
			InternalPlayer.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libVLC);
			playButtonTimer.Start();
			InternalPlayer.MediaPlayer.Stopped += InternalPlayer_Stopped;
			InternalPlayer.MediaPlayer.Playing += InternalPlayer_Playing;
			InternalPlayer.MediaPlayer.EndReached += InternalPlayer_EndReached;
			InternalPlayer.MediaPlayer.SetVideoTitleDisplay(bool.Parse(ini.Read("EnableTitleDisplay", "General")) ? (Position)int.Parse(ini.Read("TitleDisplayPosition", "General")) : Position.Disable, 3000);
			pictureBox2.Parent = InternalPlayer;
			pictureBox2.BackColor = Color.Transparent;
			pictureBox2.Dock = DockStyle.Fill;
		}

		private void InternalPlayer_EndReached(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(_ => Stop());
		}
		protected void OnPaused(EventArgs e)
		{
			EventHandler handler = Paused;
			if (handler != null)
				handler(this, e);
		}

		protected void OnPaused()
		{
			OnPaused(new EventArgs());
		}


		public void UpdateSettings()
		{
			var isRunningInVS = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("VisualStudioEdition"));
			IniFile ini;
			if (isRunningInVS)
			{
				ini = new IniFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "preferences.ini"));
			}
			else
			{
				ini = new IniFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs\\ZachMediaPlayer\\preferences.ini"));
			}
			InternalPlayer.MediaPlayer.SetVideoTitleDisplay(ini.Read("EnableTitleDisplay", "General") == "True" ? (Position)int.Parse(ini.Read("TitleDisplayPosition", "General")) : Position.Disable, 3000);

			// Audio section
			InternalPlayer.MediaPlayer.Media.AddOption(ini.Read("TimeStretch", "Audio") == "True" ? ":audio-time-stretch" : ":no-audio-time-stretch");
			InternalPlayer.MediaPlayer.Media.AddOption($":gain={ini.Read("Gain", "Audio")}");

			// MIDI section
			InternalPlayer.MediaPlayer.Media.AddOption($":soundfont={ini.Read("SoundFont", "Audio.MIDI")}");
		}

		/// <summary>
		/// Opens a media file.
		/// </summary>
		/// <param name="path">The file path of the media.</param>
		public void OpenMedia(string path, FromType type = FromType.FromPath)
		{
			if (System.IO.File.Exists(path))
			{
				InternalPlayer.MediaPlayer.Play(new Media(libVLC, path, type));
				_currentMedia = path;
				UpdateSettings();
				InternalPlayer.MediaPlayer.Media.Parse(MediaParseOptions.ParseLocal);
				InternalPlayer.MediaPlayer.Media.ParsedChanged += Media_ParsedChanged;
			}
			else
			{
				throw new FileNotFoundException();
			}
		}

		public void Media_ParsedChanged(object sender, MediaParsedChangedEventArgs e)
		{
			if (e.ParsedStatus == MediaParsedStatus.Done)
			{
				this.BeginInvoke(new Action(() =>
				{
					long duration = InternalPlayer.MediaPlayer.Length;
					if (duration == 0)
					{
						foreach (ChapterDescription chapter in InternalPlayer.MediaPlayer.FullChapterDescriptions())
						{
							//MessageBox.Show(chapter.Duration.ToString());
							duration += chapter.Duration;
						}
					}
					TimeSpan time = TimeSpan.FromMilliseconds(duration);
					tbSeek.Maximum = (int)time.TotalMilliseconds;
					//MessageBox.Show($"{tbSeek.Maximum}");
					lblTotalTime.Text = time.ToString(time.Hours >= 1 ? @"h':'mm':'ss" : @"m':'ss");
					lblTotalTime.Refresh();
					IsPaused = false;
					OnPaused();
					_stopped = false;
					toolTip1.SetToolTip(btnPlay, IsPaused ? "Play" : "Pause");
					Debug.WriteLine(string.Format("{0}:{1}", time.Minutes, time.Seconds.ToString().PadLeft(2, '0')));
					TagLib.File file;
					bool artRetrieved = false;
					bool isVideo = false;
					foreach (var track in InternalPlayer.MediaPlayer.Media.Tracks)
					{
						if (track.TrackType == TrackType.Video)
						{
							isVideo = true;
							break;
						}
					}
					//MessageBox.Show(isVideo.ToString());
					if (!isVideo)
					{
						try
						{
							file = TagLib.File.Create(_currentMedia);
							if (file.Tag.Pictures.Length >= 1)
							{
								var bin = file.Tag.Pictures[0].Data.Data;
								pictureBox2.Image = Image.FromStream(new MemoryStream(bin));
								var imageSize = pictureBox2.Image.Size;
								var fitSize = pictureBox2.ClientSize;
								pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
								artRetrieved = true;
							}
						}
						catch (TagLib.CorruptFileException)
						{
							if (!string.IsNullOrEmpty(InternalPlayer.MediaPlayer.Media.Meta(MetadataType.ArtworkURL)))
							{
								string artworkPath = new Uri(InternalPlayer.MediaPlayer.Media.Meta(MetadataType.ArtworkURL)).LocalPath;
								if (System.IO.File.Exists(artworkPath))
									pictureBox2.LoadAsync(artworkPath);
							}
							else
							{
								pictureBox2.Image = Properties.Resources.mediaplayerlogo_small;
								var imageSize = pictureBox2.Image.Size;
								var fitSize = pictureBox2.ClientSize;
								pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
							}
							artRetrieved = true;
						}
						if (!artRetrieved)
						{
							if (!string.IsNullOrEmpty(InternalPlayer.MediaPlayer.Media.Meta(MetadataType.ArtworkURL)))
							{
								string artworkPath = new Uri(InternalPlayer.MediaPlayer.Media.Meta(MetadataType.ArtworkURL)).LocalPath;
								if (System.IO.File.Exists(artworkPath))
									pictureBox2.LoadAsync(artworkPath);
							}
							else
							{
								pictureBox2.Image = Properties.Resources.mediaplayerlogo_small;
								var imageSize = pictureBox2.Image.Size;
								var fitSize = pictureBox2.ClientSize;
								pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
							}
							artRetrieved = true;
						}
					}
					IniFile ini;
					//if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("VisualStudioEdition")))
					//{
						//ini = new IniFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "preferences.ini"));
					//}
					//else
					//{
						ini = new IniFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs\\Media Player\\preferences.ini"));
					//}
					timer1.Stop();
					timer1.Start();
				}));
			}
		}

		/// <summary>
		/// Plays the currently open media.
		/// </summary>
		public void Play()
		{
			if (!_stopped)
			{
				InternalPlayer.MediaPlayer.Play();
				IsPaused = false;
				OnPaused();
			}
			else
			{
				if (!string.IsNullOrEmpty(_previousMedia))
				{
					OpenMedia(_previousMedia);
				}
			}
		}

		/// <summary>
		/// Pauses the currently open media.
		/// </summary>
		public void Pause()
		{
			InternalPlayer.MediaPlayer.Pause();
			IsPaused = true;
			OnPaused();
		}

		/// <summary>
		/// Stops the currently open media.
		/// </summary>
		public void Stop()
		{
			if (!_stopped)
			{
				InternalPlayer.MediaPlayer.Stop();
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			if (!_stopped)
			{
				InternalPlayer.MediaPlayer.SeekTo(TimeSpan.FromMilliseconds(tbSeek.Value));
			}
		}

		private void tbVolume_Scroll(object sender, EventArgs e)
		{
			Volume = tbVolume.Value;
			toolTip1.SetToolTip(tbVolume, $"Volume: {Volume}%");
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (!_stopped)
			{
				Debug.WriteLine(tbSeek.Maximum);
				if (tbSeek.Maximum > 0)
				{
					try
					{
						tbSeek.Value = (int)InternalPlayer.MediaPlayer.Time;
					}
					catch
					{
						tbSeek.Value = 0;
					}
					lblCurrentTime.Text = TimeSpan.FromMilliseconds(InternalPlayer.MediaPlayer.Time).ToString(TimeSpan.FromMilliseconds(tbSeek.Maximum).Hours >= 1 ? @"h':'mm':'ss" : @"m':'ss");
				}
				else
				{
					lblCurrentTime.Text = "0:00";
				}
				if (_showRemainingTime)
					lblTotalTime.Text = TimeSpan.FromMilliseconds(tbSeek.Maximum - InternalPlayer.MediaPlayer.Time).ToString(TimeSpan.FromMilliseconds(tbSeek.Maximum).Hours >= 1 ? @"'-'h':'mm':'ss" : @"'-'m':'ss");
				else
					lblTotalTime.Text = TimeSpan.FromMilliseconds(tbSeek.Maximum).ToString(TimeSpan.FromMilliseconds(tbSeek.Maximum).Hours >= 1 ? @"h':'mm':'ss" : @"m':'ss");
			}
			else
			{
				tbSeek.Value = 0;
				tbSeek.Maximum = 0;
			}
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			if (!_stopped)
			{
				IsPaused ^= true;
				OnPaused();
				InternalPlayer.MediaPlayer.SetRate(1.0f);
				InternalPlayer.MediaPlayer.SetPause(IsPaused);
				toolTip1.SetToolTip(btnPlay, IsPaused ? "Play" : "Pause");
			}
			else
			{
				if (!string.IsNullOrEmpty(_previousMedia))
				{
					OpenMedia(_previousMedia);
				}
			}
		}

		private void InternalPlayer_Stopped(object sender, EventArgs e)
		{
			_stopped = true;
			var imageSize = Properties.Resources.mediaplayerlogo_small.Size;
			var fitSize = pictureBox2.ClientSize;
			pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
			pictureBox2.Image = Properties.Resources.mediaplayerlogo_small;
			timer1.Stop();
			tbSeek.Value = 0;
			tbSeek.Maximum = 0;
			lblCurrentTime.Text = "-:--";
			lblTotalTime.Text = "-:--";
			_previousMedia = _currentMedia;
			_currentMedia = null;
			toolTip1.SetToolTip(btnPlay, "Play");
		}

		private void InternalPlayer_Playing(object sender, EventArgs e)
		{
			_stopped = false;
		}

		private void playButtonTimer_Tick(object sender, EventArgs e)
		{
			btnPlay.Image = InternalPlayer.MediaPlayer.IsPlaying ? Properties.Resources.baseline_pause_black_24dp : Properties.Resources.baseline_play_arrow_black_24dp;
			Debug.WriteLine(TimeSpan.FromMilliseconds(InternalPlayer.MediaPlayer.Time).ToString(TimeSpan.FromMilliseconds(tbSeek.Maximum).Hours >= 1 ? @"h':'mm':'ss" : @"m':'ss"));
			InternalPlayer.MediaPlayer.Volume = Volume;

			pictureBox1.Image = Volume > 50 ? Properties.Resources.baseline_volume_up_black_24dp : (Volume <= 50 && Volume > 0 ? Properties.Resources.baseline_volume_down_24dp_000000 : Properties.Resources.baseline_volume_off_24dp_000000);

			InternalPlayer.Anchor = ShowControls ? AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right : AnchorStyles.None;
			InternalPlayer.Dock = ShowControls ? DockStyle.None : DockStyle.Fill;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			if (!_stopped)
			{
				InternalPlayer.MediaPlayer.Stop();
			}
		}

		private void button_Enter(object sender, EventArgs e)
		{
			InternalPlayer.Focus();
		}

		private void lblTotalTime_Click(object sender, EventArgs e)
		{
			if (!_stopped)
			{
				_showRemainingTime ^= true;
				if (_showRemainingTime)
					lblTotalTime.Text = TimeSpan.FromMilliseconds(tbSeek.Maximum - InternalPlayer.MediaPlayer.Time).ToString(TimeSpan.FromMilliseconds(tbSeek.Maximum).Hours >= 1 ? @"'-'h':'mm':'ss" : @"'-'m':'ss");
				else
					lblTotalTime.Text = TimeSpan.FromMilliseconds(tbSeek.Maximum).ToString(TimeSpan.FromMilliseconds(tbSeek.Maximum).Hours >= 1 ? @"h':'mm':'ss" : @"m':'ss");
			}
		}

		private void btnFastForward_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !_stopped)
			{
				_fastForward = true;
				fastForward();
			}
		}

		private void btnFastForward_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !_stopped)
			{
				_fastForward = false;
			}
		}

		private void btnRewind_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !_stopped)
			{
				_rewinding = true;
				rewind();
			}
		}

		private void rewind()
		{
			float deltaStep = 60000f / tbSeek.Maximum;
			float backwardStep = deltaStep * 0.0000015f;
			Task.Run(() =>
			{
				Thread.Sleep(500);
				while (_rewinding)
				{
					InternalPlayer.Invoke((MethodInvoker)delegate
					{
						int previousTime = (int)InternalPlayer.MediaPlayer.Time - 10;
						if (previousTime <= 0)
						{
							InternalPlayer.MediaPlayer.Time = 0;
						}
						else
						{
							InternalPlayer.MediaPlayer.Time -= 10;
						}
					});
				}
			});
		}

		private void fastForward()
		{
			float deltaStep = 60000f / tbSeek.Maximum;
			float backwardStep = deltaStep * 0.0000015f;
			int maxTime = tbSeek.Maximum;
			Task.Run(() =>
			{
				Thread.Sleep(500);
				while (_fastForward)
				{
					this.Invoke((MethodInvoker)delegate
					{
						int nextTime = (int)InternalPlayer.MediaPlayer.Time + 10;
						if (nextTime >= maxTime)
						{
							InternalPlayer.MediaPlayer.Stop();
							_fastForward = false;
						}
						else
						{
							InternalPlayer.MediaPlayer.Time += 10;
						}
					});
				}
			});
		}

		private void btnRewind_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !_stopped)
			{
				_rewinding = false;
			}
		}

		private void pictureBox2_Resize(object sender, EventArgs e)
		{
			var imageSize = pictureBox2.Image.Size;
			var fitSize = pictureBox2.ClientSize;
			pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
		}

		private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			var imageSize = pictureBox2.Image.Size;
			var fitSize = pictureBox2.ClientSize;
			pictureBox2.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (Volume == 0)
			{
				if (_previousVolume == 0)
				{
					_previousVolume = 1;
				}
				Volume = _previousVolume;
			}
			else
			{
				_previousVolume = Volume;
				Volume = 0;
			}
			tbVolume.Value = Volume;
			toolTip1.SetToolTip(tbVolume, $"Volume: {Volume}%");
		}
	}
}
