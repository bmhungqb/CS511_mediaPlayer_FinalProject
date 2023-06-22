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
        int Id = 0;
        MediaPlayer.API.ZingMp3Api zingMp3Api;
        MediaPlayer.API.Utils Utils;
        Song currentSong = new Song();
        public uct_song(int id,Song dataSong)
        {
            InitializeComponent();
            pt_thumb.BringToFront();
            currentSong = dataSong;
            Id = id;
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
            lb_id.Text = Id.ToString();
            lb_song.Text = currentSong.title;
            lb_singer.Text = currentSong.artistsNames;
            lb_album.Text = currentSong.album.title;
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
