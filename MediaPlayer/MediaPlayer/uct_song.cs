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
        MediaPlayer.API.DataStructure song = new DataStructure();
        MediaPlayer.API.APIMusic apimusic = new APIMusic();
        public uct_song(int id,DataStructure dataSong)
        {
            InitializeComponent();
            pt_thumb.BringToFront();
            song = dataSong;
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
            lb_song.Text = song.name;
            lb_singer.Text = song.artist;
            lb_album.Text = song.albumName;
            lb_time.Text = ConvertToMinutesAndSeconds(int.Parse(song.duration));
            pt_thumb.Image = apimusic.getImage(song.thumb);
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
            main.testPlayMusic(song);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            btn_tym.Checked = !btn_tym.Checked;
        }
    }
}
