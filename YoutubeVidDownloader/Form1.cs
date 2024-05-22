using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVidDownloader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VidURLTextBox.Text = "Insert video URL";
            VidURLTextBox.ForeColor = Color.Gray;
            outputSelect.SelectedIndex = 0;
        }

        private void VidURLTextBox_Enter(object sender, EventArgs e)
        {
            if (VidURLTextBox.Text == "Insert video URL" && VidURLTextBox.ForeColor == Color.Gray)
            {
                VidURLTextBox.Text = "";
                VidURLTextBox.ForeColor = Color.Black;
            }
        }

        private void VidURLTextBox_Leave(object sender, EventArgs e)
        {
            if (VidURLTextBox.Text == "")
            {
                VidURLTextBox.Text = "Insert video URL";
                VidURLTextBox.ForeColor = Color.Gray;
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            var youtube = new YoutubeClient();

            var videoUrl = VidURLTextBox.Text;
            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            
            if(outputSelect.SelectedIndex == 0) //Audio and Video
            {
                var streamInfo = streamManifest.GetMuxedStreams().TryGetWithHighestVideoQuality();
            } else if (outputSelect.SelectedIndex == 1) { //Video only
                var streamInfo = streamManifest.GetVideoOnlyStreams().TryGetWithHighestVideoQuality();
            } else { //Audio only
                var streamInfo = streamManifest.GetAudioOnlyStreams().TryGetWithHighestBitrate();
            }

            ytThumb.Load(video.Thumbnails.TryGetWithHighestResolution().Url);
            vidTitle.Text = video.Title;

            

            
        }
    }
}
