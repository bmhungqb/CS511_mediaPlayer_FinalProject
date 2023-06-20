using Guna.UI2.WinForms;
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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MediaPlayer
{
    public partial class uctsearch : UserControl
    {
        MediaPlayer.API.APIMusic apiMusic = new APIMusic();
        public uctsearch()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        string type_search = "artist,song,key,code";
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            tb_search.Text= string.Empty;
        }

        //private void guna2Button1_Click(object sender, EventArgs e)//all
        //{
        //    btn_all.FillColor = Color.White;
        //    btn_all.ForeColor = Color.Black;
        //    btn_song.FillColor = SystemColors.WindowFrame;
        //    btn_song.ForeColor = Color.White;
        //    btn_artist.FillColor = SystemColors.WindowFrame;
        //    btn_artist.ForeColor = Color.White;
        //    btn_playlist.FillColor = SystemColors.WindowFrame;
        //    btn_playlist.ForeColor = Color.White;
        //}

        //private void guna2Button2_Click(object sender, EventArgs e)//songs
        //{
        //    btn_song.FillColor = Color.White;
        //    btn_song.ForeColor = Color.Black;
        //    btn_all.FillColor = SystemColors.WindowFrame;
        //    btn_all.ForeColor = Color.White;
        //    btn_artist.FillColor = SystemColors.WindowFrame;
        //    btn_artist.ForeColor = Color.White;
        //    btn_playlist.FillColor = SystemColors.WindowFrame;
        //    btn_playlist.ForeColor = Color.White;
        //}

        //private void guna2Button3_Click(object sender, EventArgs e)//artists
        //{
        //    btn_artist.FillColor = Color.White;
        //    btn_artist.ForeColor = Color.Black;
        //    btn_song.FillColor = SystemColors.WindowFrame;
        //    btn_song.ForeColor = Color.White;
        //    btn_all.FillColor = SystemColors.WindowFrame;
        //    btn_all.ForeColor = Color.White;
        //    btn_playlist.FillColor = SystemColors.WindowFrame;
        //    btn_playlist.ForeColor = Color.White;
        //}

        //private void guna2Button4_Click(object sender, EventArgs e)//playlists
        //{
        //    btn_playlist.FillColor = Color.White;
        //    btn_playlist.ForeColor = Color.Black;
        //    btn_song.FillColor = SystemColors.WindowFrame;
        //    btn_song.ForeColor = Color.White;
        //    btn_artist.FillColor = SystemColors.WindowFrame;
        //    btn_artist.ForeColor = Color.White;
        //    btn_all.FillColor = SystemColors.WindowFrame;
        //    btn_all.ForeColor = Color.White;
        //}
        private void btn_Click_Type_Search(object sender, EventArgs e)
        {
            Guna2Button button = sender as Guna2Button;
            button.Checked = true;
            switch(button.Name)
            {
                case "btn_all":
                    type_search = "artist,song,key,code";
                    btn_song.Checked = false;
                    btn_artist.Checked = false;
                    btn_playlist.Checked = false;
                    break;
                case "btn_song":
                    type_search = "song";
                    btn_all.Checked = false;
                    btn_artist.Checked = false;
                    btn_playlist.Checked = false;
                    break;
                case "btn_artist":
                    //type_search = "artist";
                    type_search = "song";
                    btn_song.Checked = false;
                    btn_all.Checked = false;
                    btn_playlist.Checked = false;
                    break;
                case "btn_playlist":
                    type_search = "artist,song,key,code";
                    btn_song.Checked = false;
                    btn_artist.Checked = false;
                    btn_all.Checked = false;
                    break;
            }
            SearchMusic();

        }
        private void DeleteUctSongs()
        {
            var utcSongs = flowLayoutSearch.Controls.OfType<uct_song>().ToList();
            foreach (var utcSong in utcSongs)
            {
                flowLayoutSearch.Controls.Remove(utcSong);
                utcSong.Dispose();
            }
        }
        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchMusic();
            }
        }
        private void SearchMusic()
        {
            DeleteUctSongs();

            DS_SearchMusic res_searchMusic = apiMusic.searchMusic(tb_search.Text, type_search, 10);
            int id = 0;
            int time = 0;
            foreach (Song song in res_searchMusic.Songs)
            {
                id++;
                uct_song new_Song = new uct_song(id, song);
                flowLayoutSearch.Controls.Add(new_Song);
                time += int.Parse(song.duration);
            }
        }
    }
}
