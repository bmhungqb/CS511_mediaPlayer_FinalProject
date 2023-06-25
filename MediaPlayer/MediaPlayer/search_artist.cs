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

namespace MediaPlayer
{
    public partial class search_artist : UserControl
    {
       public Artist currentArtist;
        MediaPlayer.API.Utils Utils = new Utils();
        public search_artist(Artist artist)
        {
            currentArtist = artist;
            InitializeComponent();
        }
        public string convert()
        {
            string formatFollow;
            int thousand = currentArtist.totalFollow / 1000;
            int remainder = currentArtist.totalFollow % 1000;
            if (thousand == 0)
            {
                formatFollow = currentArtist.totalFollow.ToString();
            }
            else
            {
                formatFollow = thousand.ToString() + "." + remainder.ToString();
            }
            return formatFollow;
        }
        private void search_artist_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            pt_artist.Image = Utils.getImage(currentArtist.thumbnailM);
            lb_name.Text = currentArtist.name;
            lb_follow.Text = convert() + " follows";
        }
        public event EventHandler OpenArtistSongRequested;
        private void pt_artist_Click(object sender, EventArgs e)
        {
            OpenArtistSongRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
