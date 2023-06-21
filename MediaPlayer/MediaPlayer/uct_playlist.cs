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
            guna2CustomGradientPanel2.Width = 1370;
        }

       
        private void uct_playlist_Load(object sender, EventArgs e)
        {
            mediaPlayer main = this.ParentForm as mediaPlayer;
            DS_SearchMusic res_searchMusic = apiMusic.searchMusic(name.Text, "artist,song", 10);
            main.setCurrentListSong(res_searchMusic.Songs);
            int id = 0;
            int time = 0;
            foreach (Song song in res_searchMusic.Songs)
            {
                id++;
                uct_song new_Song = new uct_song(id, song);
                flowLayoutPanel1.Controls.Add(new_Song);
                time += int.Parse(song.duration);
            }
            int minutes = time / 60;
            int seconds = time % 60;

            string formattedTime = $"{minutes} min {seconds.ToString("D2")} secs ";
            label3.Text = id.ToString() + " songs,  " + formattedTime;
            // get avatar artist 
            if (res_searchMusic.Artists.Count > 0)
            {
                Artist artist = res_searchMusic.Artists[0];
                pic_thumb_artist.Image = apiMusic.getImage(artist.thumb);
            }
            //apiMusic.getLyrics("https://static-zmp3.zmdcdn.me/lyrics/2/b/8/f/2b8f4c339157d10a8c1ab80fa8d25424.lrc");
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
