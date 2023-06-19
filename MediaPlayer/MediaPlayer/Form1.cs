using Guna.UI2.WinForms;
using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class mediaPlayer : Form
    {
        public mediaPlayer()
        {
            InitializeComponent();
        }
        uct_player player = new uct_player();
        public void testPlayMusic(Song song)
        {
            player.playMusic(song);
        }
        private void mediaPlayer_Load_1(object sender, EventArgs e)
        {
            panel1.Width = 1385;
            panel1.Location = new Point(58, -1);
            panel2.Width = 52;
            panel3.Width = 52;
            panel2.Height = 50;
            thunho();

            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
            home1.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            //Add player into pnl_Player
            pnl_Player.Controls.Add(player);
        }
        void morong()
        {
            panel2.Height = 145;
            panel2.Location = new Point(0, 42);
            panel4.Location = new Point(0, 193);
            panel3.Location = new Point(0, 323);
        }
        void thunho()
        {
            panel2.Location = new Point(0, 42);
            panel4.Location = new Point(0, 83);
            panel3.Location = new Point(0, 211);
        }
        private void playlist_b_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Height = 50;
            thunho();
            playlist_b.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;

            playlist Playlist = new playlist();
            panel1.Controls.Add(Playlist);
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (panel2.Width != 160)
            {
                pictureBox1.Image = Properties.Resources.reduce;
                panel1.Location = new Point(165, -1);
                panel1.Width = 1278;
                panel2.Width = 160;
                panel4.Width = 160;
                panel3.Width = 160;
            }
            if (panel2.Height != 145)//mở rộng
                morong();
            else
            {
                thunho();
                panel2.Height = 50;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Height = 50;
            thunho();
            if (panel2.Width == 160)//thu nhỏ
            {
                pictureBox1.Image = Properties.Resources.expand;
                panel1.Width = 1385;
                panel1.Location = new Point(58, -1);
                panel2.Width = 52;
                panel4.Width = 52;
                panel3.Width = 52;
            }
            else //expand
            {
                pictureBox1.Image = Properties.Resources.reduce;
                panel1.Location = new Point(165, -1);
                panel1.Width = 1278;
                panel2.Width = 160;
                panel4.Width = 160;
                panel3.Width = 160;
            }
        }

        private void home1_Click_1(object sender, EventArgs e)
        {
            panel2.Height = 50;
            thunho();
            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
            home1.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
        }

        private void find_Click(object sender, EventArgs e)
        {
            panel2.Height = 50;
            thunho();
            panel1.Controls.Clear();
            uctsearch uctsearch = new uctsearch();
            panel1.Controls.Add(uctsearch);
            find.FillColor = SystemColors.AppWorkspace;
            home1.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
        }

        private void guna2Button1_Click(object sender, EventArgs e)//profile
        {
            find.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            guna2Button1.FillColor = SystemColors.AppWorkspace;
            panel1.Controls.Clear();
            uctacc uctacc = new uctacc();
            panel1.Controls.Add(uctacc);
        }
    }
}
