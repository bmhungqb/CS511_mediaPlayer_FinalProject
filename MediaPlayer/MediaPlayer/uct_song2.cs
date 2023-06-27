using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class uct_song2 : UserControl
    {
        public Song currentSong = new Song();
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public string listSong;
        public uct_song2(string path, Song song)
        {
            InitializeComponent();
            currentSong = song;
            listSong = path;
        }
        public static string ConvertToMinutesAndSeconds(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = $"{minutes}:{seconds.ToString("D2")}";

            return formattedTime;
        }
        private async void uct_song2_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            string res = await zingMp3Api.GetInfoSong(currentSong.songId);
            currentSong = Utils.getInfoSong(res);
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);
            lb_song.Text = currentSong.title;
            lb_singer.Text = currentSong.artistsNames;
            lb_time.Text = ConvertToMinutesAndSeconds(currentSong.duration);
        }

        private void pt_thumb_Click(object sender, EventArgs e)
        {
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.testPlayMusic(currentSong);
        }
        public event EventHandler DelSongRequested;
        private void btn_del_Click(object sender, EventArgs e)
        {
            
            DelSongRequested?.Invoke(this, EventArgs.Empty);
            //update
        }
    }
}
