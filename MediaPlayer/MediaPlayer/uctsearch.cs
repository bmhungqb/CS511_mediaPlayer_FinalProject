using Guna.UI2.WinForms;
using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            panel2.Visible = false;
        }
        string type_search = "artist,song,key,code";
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            tb_search.Text= string.Empty;
        }
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
                    panel2.Visible = false;
                    break;
                case "btn_song":
                    type_search = "song";
                    btn_all.Checked = false;
                    btn_artist.Checked = false;
                    btn_playlist.Checked = false;
                    panel2.Visible = true;
                    break;
                case "btn_artist":
                    //type_search = "artist";
                    type_search = "song";
                    btn_song.Checked = false;
                    btn_all.Checked = false;
                    btn_playlist.Checked = false;
                    panel2.Visible = false;
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
                if (tb_search.Text == "") return;
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
