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
    public partial class uct_playlist : UserControl
    {
        MediaPlayer.API.APIMusic apiMusic = new APIMusic();
        public uct_playlist(string y)
        {
            InitializeComponent();
            name.Text = y;
        }
        public void OpenUserControlB()
        {
            // Thực hiện các hành động cần thiết khi mở UserControlB
        }

       
        private void uct_playlist_Load(object sender, EventArgs e)
        {
            //uct_song song = new uct_song();
            //song.Location = new Point(13, 437);
            ////panel1.Controls.Clear();
            //guna2CustomGradientPanel1.Controls.Add(song);
            //song.BringToFront();
            DS_SearchMusic listSong = apiMusic.searchMusic("Đen", "song", 10);
            int id = 1;
            int time=0;
            foreach (Song song in listSong.Songs)
            {
                uct_song new_Song = new uct_song(id,song);
                flowLayoutPanel1.Controls.Add(new_Song);
                id++;
                time += int.Parse(song.duration);
            }
            int minutes = time / 60;
            int seconds = time % 60;

            string formattedTime = $"{minutes} min {seconds.ToString("D2")} secs ";
            label3.Text = id.ToString() + " songs,  " + formattedTime;
        }

        private void search_textbox_IconLeftClick_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            search_textbox.Visible = false;
            search_textbox.Text = "Search in playlist";
            pictureBox5.BringToFront();
            search_textbox.SendToBack();
        }

        private void search_textbox_DoubleClick_1(object sender, EventArgs e)
        {
            search_textbox.Text = string.Empty;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            search_textbox.Visible = true;
            pictureBox5.SendToBack();
            search_textbox.BringToFront();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)//back
        {
            this.Hide();
        }
    }
}
