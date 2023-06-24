using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.API;
namespace MediaPlayer
{
    public partial class uct_song : UserControl
    {
        string ID = null;
        MediaPlayer.API.ZingMp3Api zingMp3Ap = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        Song currentSong = new Song();
        public uct_song(string id, Song song)
        {
            InitializeComponent();
            pt_thumb.BringToFront();
            currentSong = song;
            ID= id;
        }
        public static string ConvertToMinutesAndSeconds(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = $"{minutes}:{seconds.ToString("D2")}";

            return formattedTime;
        }
        private void uct_song_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            lb_id.Text = ID;
            lb_song.Text = currentSong.title;
            lb_singer.Text = currentSong.artistsNames;
         //   lb_album.Text = currentSong.totalLike.ToString();
            lb_time.Text = ConvertToMinutesAndSeconds(currentSong.duration);
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)//
        {
            pt_thumb.SendToBack();
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pt_thumb.BringToFront();
        }

        private void pt_thumb_Click(object sender, EventArgs e)
        {
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.testPlayMusic(currentSong);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            btn_tym.Checked = !btn_tym.Checked;
        }
    }
}
