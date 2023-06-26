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
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
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
            tb_search.Text = string.Empty;
        }
        private async void btn_Click_Type_Search(object sender, EventArgs e)
        {
            Guna2Button button = sender as Guna2Button;
            button.Checked = true;
            string resSearch = await zingMp3Api.Search(tb_search.Text);
            Search search = new Search();
            search = Utils.handleSearch(resSearch);
            switch (button.Name)
            {
                case "btn_all":
                    type_search = "artist,song,key,code";
                    btn_song.Checked = false;
                    btn_artist.Checked = false;
                    btn_playlist.Checked = false;
                    SearchMusicAll(search);
                    break;
                case "btn_song":
                    type_search = "song";
                    btn_all.Checked = false;
                    btn_artist.Checked = false;
                    btn_playlist.Checked = false;
                    SearchSong(search);
                    break;
                case "btn_artist":
                    type_search = "song";
                    btn_song.Checked = false;
                    btn_all.Checked = false;
                    btn_playlist.Checked = false;
                    SearchArtist(search);
                    break;
                case "btn_playlist":
                    type_search = "artist,song,key,code";
                    btn_song.Checked = false;
                    btn_artist.Checked = false;
                    btn_all.Checked = false;
                    SearchPlaylist(search);
                    break;
            }
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
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_search.Text == "") return;
                //      SearchMusic();
            }
        }
        private void clear()
        {
            flowLayoutSearch.Controls.Clear();
            flowLayoutSearch.Controls.Add(panel_search);
        }

        private void SearchMusicAll(Search search)
        {
            DeleteUctSongs();
            //  clear();
            flowLayoutSearch.Controls.Clear();
            search_all search_All = new search_all(search);
            flowLayoutSearch.Controls.Add(search_All);
            search_All.BringToFront();
        }
        private void SearchSong(Search search)
        {
            DeleteUctSongs();
            //  clear();
            flowLayoutSearch.Controls.Clear();
            for (int i = 0; i < search.listSongs.Count; i++)
            {
                uct_song uct_Song = new uct_song((i+1).ToString(), search.listSongs[i]);
                flowLayoutSearch.Controls.Add(uct_Song);
            }
        }
        private void SearchArtist(Search search)
        {
            DeleteUctSongs();
            //   clear();
            flowLayoutSearch.Controls.Clear();
            for (int i = 0; i < search.listArtists.Count; i++)
            {
                search_artist artist = new search_artist(search.listArtists[i]);
                artist.OpenArtistSongRequested += Artist_OpenArtistSongRequested;
                flowLayoutSearch.Controls.Add(artist);
                artist.BringToFront();
            }
        }

        private void Artist_OpenArtistSongRequested(object sender, EventArgs e)
        {
            search_artist artist = sender as search_artist;
            uct_artist uct_Playlist = new uct_artist();
            uct_Playlist.OpenUserControl(artist.currentArtist);
            guna2Panel1.Controls.Add(uct_Playlist);
            uct_Playlist.BringToFront();
        }

        private void SearchPlaylist(Search search)
        {
            DeleteUctSongs();
            //  clear();
            flowLayoutSearch.Controls.Clear();
            for (int i = 0; i < search.listPlaylists.Count; i++)
            {
                artist_popular playlist = new artist_popular(search.listPlaylists[i]);
                playlist.OpenPlaylistRequested += Playlist_OpenPlaylistRequested;
                flowLayoutSearch.Controls.Add(playlist);
            }
        }

        private void Playlist_OpenPlaylistRequested(object sender, EventArgs e)
        {
            artist_popular playlist = sender as artist_popular;
            uct_playlist uct_Playlist = new uct_playlist();
            uct_Playlist.OpenUserControlB(playlist.current);
            guna2Panel1.Controls.Add(uct_Playlist);
            uct_Playlist.BringToFront();
        }
    }
}
