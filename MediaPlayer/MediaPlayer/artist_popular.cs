using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class artist_popular : UserControl
    {
        string descrip;
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        string url;
        public artist_popular(string image, string des)
        {
            InitializeComponent();
            url = image;
            descrip=des;
        }
        private void artist_popular_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            pt_artist.Image = Utils.getImage(url);
            guna2TextBox1.Text = descrip;
        }
    }
}
