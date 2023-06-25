using AxWMPLib;
using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer
{
    public partial class uct_video : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public Song currentSong = new Song();
        public uct_video()
        {
            InitializeComponent();
            playVideo(null);
        }
        public async void playVideo(Song song)
        {
            string res = await zingMp3Api.GetVideo("ZWADIOCC");
            Video video = Utils.getVideo(res);
            player.URL = video.linkFileTempVideo;
            //lb_title.Text = song.title;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
