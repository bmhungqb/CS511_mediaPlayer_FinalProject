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
        MediaPlayer.API.ZingMp3Api zingMp3Api= new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public uctsearch()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        string type_search = "artist,song,key,code";
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
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
                if (tb_search.Text == "") return;
                SearchMusic();
            }
        }
        private async void SearchMusic()
        {
            DeleteUctSongs();
            string resSearch = await zingMp3Api.Search(tb_search.Text);
            Search search = new Search();
            search = Utils.handleSearch(resSearch);
            search_all search_All = new search_all(search);
            flowLayoutSearch.Controls.Add(search_All);
        }
    }
}
