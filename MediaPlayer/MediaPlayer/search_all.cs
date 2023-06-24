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
           // pt_thumb.Image = Utils.getImage(a.thumbnail);
           for (int i = 0; i < a.listSongs.Count; i++)
            {
                uct_song uct_Song = new uct_song((i+1).ToString(), a.listSongs[i]);
                flow_song.Controls.Add(uct_Song);
            }
            for (int i = 0; i < a.listPlaylists.Count; i++)
            {
                artist_popular artist = new artist_popular(a.listPlaylists[i]);
                flow_playlist.Controls.Add(artist);
            }
            for (int i = 0; i < a.listArtists.Count; i++)
            {
                artist_popular artist = new artist_popular(a.listPlaylists[i]);
                flow_artist.Controls.Add(artist);
            }
        }
    }
}
