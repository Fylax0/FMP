using System.Text.RegularExpressions;
using System.Windows.Forms.Design;
using VisioForge.Core.MediaPlayer;
using VisioForge.Core.Types;
using VisioForge.Core.Types.Events;
using VisioForge.Core.Types.MediaPlayer;
using VisioForge.Core.UI;
using VisioForge.DotNet.MediaPlayer;
namespace ApinProject
{
    public partial class Form1 : Form
    {

        private VisioForge.DotNet.MediaPlayer.MediaPlayerCore MediaPlayer1;
        public Form1()
        {
            InitializeComponent();
        }
        private OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
        };
        private void CreateEngine()
        {
            MediaPlayer1 = new VisioForge.DotNet.MediaPlayer.MediaPlayerCore();
            MediaPlayer1.OnStop += MediaPlayer1_OnStop;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateEngine();
            listbox1_Load1();
        }
        private void listbox1_Load1()
        {
            listBox1.Items.Clear();
            MediaPlayer1.Playlist_Clear();
            foreach (var file in Directory.GetFiles("Music"))
            {
                string fileName = file;
                fileName = file.Substring(file.LastIndexOf('\\') + 1);
                fileName = fileName.Remove(fileName.Length - 4);
                listBox1.Items.Add(fileName);
                MediaPlayer1.Playlist_Add(file);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                listBox1_Load(sender, e);
            }

        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaPlayer1.Playlist_SetPosition(listBox1.SelectedIndex);
            await StopAsync();
            playButton_DoubleClick(sender, e);
        }
        private void listBox1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MediaPlayer1.Playlist_Clear();
            foreach (string item in ofd.FileNames)
            {
                listBox1.Items.Add(item.Substring(item.LastIndexOf('\\') + 1));
                MediaPlayer1.Playlist_Add(item);
            }
        }

        private void MediaPlayer1_OnStop(object sender, StopEventArgs e)
        {
            Invoke((Action)(() => tbTimeline.Value = 0));
        }

        private void previousTrackButton_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Playlist_PlayPrevious();
            label1.Text = SetSongName();
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
        }

        private async void playButton_DoubleClick(object sender, EventArgs e)
        {
            MediaPlayer1.Audio_PlayAudio = true;

            MediaPlayer1.Source_Mode = MediaPlayerSourceMode.File_DS;
            MediaPlayer1.Audio_OutputDevice = "Default DirectSound Device";

            MediaPlayer1.Video_Renderer.VideoRenderer = VideoRendererMode.None;

            MediaPlayer1.Info_UseLibMediaInfo = true;

            await MediaPlayer1.PlayAsync();

            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
            label1.Text = SetSongName();
            timer1.Enabled = true;


        }
        private async void playButton_Click(object sender, EventArgs e)
        {
            await MediaPlayer1.PauseAsync();
            label1.Text = SetSongName();

        }
        private void nextTrackButton_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Playlist_PlayNext();
            label1.Text = SetSongName();
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
        }
        private async void tbTimeline_Scroll(object sender, EventArgs e)
        {
            if (Convert.ToInt32(timer1.Tag) == 0)
            {
                await MediaPlayer1.Position_Set_TimeAsync(TimeSpan.FromSeconds(tbTimeline.Value));
            }
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tag = 1;
            tbTimeline.Maximum = (int)(await MediaPlayer1.Duration_TimeAsync()).TotalSeconds;

            int value = (int)(await MediaPlayer1.Position_Get_TimeAsync()).TotalSeconds;
            if ((value > 0) && (value < tbTimeline.Maximum))
            {
                tbTimeline.Value = value;
            }

            lbTime.Text = MediaPlayer1.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayer1.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum);

            timer1.Tag = 0;
            if (tbTimeline.Value >= tbTimeline.Maximum)
            {
                MediaPlayer1.Playlist_PlayNext();
                label1.Text = SetSongName();
                MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
            }
        }
        private async Task StopAsync()
        {
            await MediaPlayer1.StopAsync();

            timer1.Enabled = false;

            tbTimeline.Value = 0;
        }
        private void tbVolume1_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
        }
        private async void btStop_Click(object sender, EventArgs e)
        {
            await StopAsync();
        }
        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await StopAsync();
        }

        private string SetSongName()
        {
            string songName = MediaPlayer1.Playlist_GetFilename(MediaPlayer1.Playlist_GetPosition());
            songName = songName.Substring(songName.LastIndexOf('\\') + 1);
            songName = songName.Remove(songName.Length - 4);
            return songName;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "Music");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listbox1_Load1();
        }
    }
}

