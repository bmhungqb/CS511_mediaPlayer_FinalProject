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
    public partial class search_all : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        Search a = new Search();
        public search_all(Search search)
        {
            a = search;
            InitializeComponent();
            BackColor = Color.Transparent;
        }

        private void search_all_Load(object sender, EventArgs e)
        {
           for (int i = 0; i < a.listSongs.Count; i++)
            {
                uct_song uct_Song = new uct_song((i+1).ToString(), a.listSongs[i]);
                flow_song.Controls.Add(uct_Song);
            }
            for (int i = 0; i < a.listPlaylists.Count; i++)
            {
                //usercontrol artist_popular use for playlist
                artist_popular playlist = new artist_popular(a.listPlaylists[i]);
                playlist.OpenPlaylistRequested += Playlist_OpenPlaylistRequested;
                flow_playlist.Controls.Add(playlist);
            }
            for (int i = 0; i < a.listArtists.Count; i++)
            {
                search_artist artist = new search_artist(a.listArtists[i]);
                artist.OpenArtistSongRequested += Artist_OpenArtistSongRequested;
                flow_artist.Controls.Add(artist);
            }
        }

        private void Artist_OpenArtistSongRequested(object sender, EventArgs e)
        {
            search_artist artist = sender as search_artist;
            uct_artist uct_Playlist = new uct_artist();
            uct_Playlist.OpenUserControl(artist.currentArtist);
            panel1.Controls.Add(uct_Playlist);
            uct_Playlist.BringToFront();
        }

        private void Playlist_OpenPlaylistRequested(object sender, EventArgs e)
        {
            artist_popular playlist = sender as artist_popular;
            uct_playlist uct_Playlist = new uct_playlist();
            uct_Playlist.OpenUserControlB(playlist.current);
            panel1.Controls.Add(uct_Playlist);
            uct_Playlist.BringToFront();
        }
    }
}
