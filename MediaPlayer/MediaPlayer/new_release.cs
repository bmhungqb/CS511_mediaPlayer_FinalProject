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
    public partial class new_release : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        Song currentSong = new Song();
        public new_release(Song song)
        {
            InitializeComponent();
            currentSong = song;
        }

        private void new_release_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);
            lb_song.Text = currentSong.title;
            lb_singer.Text = currentSong.artistsNames;
        }
    }
}
