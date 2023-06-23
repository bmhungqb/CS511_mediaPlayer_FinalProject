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
    public partial class uct_create : UserControl
    {
        public uct_create()
        {
            InitializeComponent();
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = string.Empty;
        }

        private void uct_create_Load(object sender, EventArgs e)
        {
            //list_song panel: shows song after adding in playlist (show usercontrol uct_song1)
            uct_song1 uct = new uct_song1();
            list_song.Controls.Add(uct);
            //add_song panel: search song to add (show usercontrol add_song)
        }

        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            this.Hide();
        }
    }
}
