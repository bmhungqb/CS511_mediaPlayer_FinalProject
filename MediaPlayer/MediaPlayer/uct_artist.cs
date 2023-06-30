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
    public partial class uct_artist : UserControl
    {
        Artist currentArtist;
        MediaPlayer.API.Utils Utils = new Utils();
        MediaPlayer.API.ZingMp3Api zingMp3 = new ZingMp3Api();
        public uct_artist()
        {
            InitializeComponent();
        }
        
        public string convert(int totalFollow)
        {
            string formatFollow;
            int thousand = totalFollow / 1000;
            int remainder = totalFollow % 1000;
            if (thousand == 0)
            {
                formatFollow = totalFollow.ToString();
            }
            else
            {
                formatFollow = thousand.ToString() + "." + remainder.ToString();
            }
            return formatFollow;
        }

        private void uct_artist_Load(object sender, EventArgs e)
        {
            ////name
            //label3.Text = convert();
            //pic_thumb_artist.Image = Utils.getImage(currentArtist.thumbnail);
            //birthday.Text = currentArtist.birthday;
            //for (int i = 0; i < currentArtist.listSongs.Count; i++)
            //{
            //    uct_song uct_Song = new uct_song((i + 1).ToString(), currentArtist.listSongs[i]);
            //    flow_song.Controls.Add(uct_Song);
            //}
        }
        public async void OpenUserControl(Artist artist)
        {
            name.Text = artist.name;
            label3.Text = convert(artist.totalFollow) + " follows";
            pic_thumb_artist.Image = Utils.getImage(artist.thumbnail);
            string res = await zingMp3.GetListArtistSong(artist.artistId);
            List<Song> songs = Utils.getListArtistSong(res);
            for (int i = 0; i < songs.Count; i++)
            {
                uct_song uct_Song = new uct_song((i + 1).ToString(), songs[i]);
                flow_song.Controls.Add(uct_Song);
            }
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.setCurrentListSong(songs);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
