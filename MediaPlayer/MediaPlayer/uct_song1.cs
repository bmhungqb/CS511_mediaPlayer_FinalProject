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
using MediaPlayer.API;

namespace MediaPlayer
{
    public partial class uct_song1 : UserControl
    {
        public Song currentSong = new Song();
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public string listSong;
        public uct_song1(string path, Song song)
        {
            InitializeComponent();
            currentSong = song;
            listSong = path;
        }
        private async void uct_song1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            string res = await zingMp3Api.GetInfoSong(currentSong.songId);
            currentSong = Utils.getInfoSong(res);
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);
            lb_song.Text = currentSong.title;
            lb_singer.Text = currentSong.artistsNames;
        }

        private void pt_thumb_Click(object sender, EventArgs e)
        {
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.testPlayMusic(currentSong);
        }
        public event EventHandler AddMusicRequested;
        private void btn_add_Click(object sender, EventArgs e)//add music
        {
            string[] lines = File.ReadAllLines(listSong);
            if (Array.IndexOf(lines, currentSong.songId) != -1)
            {
                MessageBox.Show("This song has been added already!");
            }
            else
            {
                File.AppendAllText(listSong, currentSong.songId + "\n");
                AddMusicRequested?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
