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
    public partial class uct_song : UserControl
    {
        public uct_song()
        {
            InitializeComponent();
            pictureBox1.BringToFront();
        }

        private void uct_song_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)//
        {
            pictureBox1.SendToBack();
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }
    }
}
