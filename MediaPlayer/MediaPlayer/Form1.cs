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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class mediaPlayer : Form
    {
        public mediaPlayer()
        {
            InitializeComponent();
            panel1.AutoScroll = false;

        }
        uct_player player = new uct_player();
        Song x;
        public void testPlayMusic(Song song)
        {
            player.playMusic(song);
            x = song;
        }
        public void setCurrentListSong(List<Song> listSongs)
        {
            player.SetCurrentPlaylist(listSongs);
        }
        private void mediaPlayer_Load_1(object sender, EventArgs e)
        {
            thunho();
            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
            home1.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            acc.FillColor = SystemColors.WindowFrame;
            setting.FillColor = SystemColors.WindowFrame;
            //Add player into pnl_Player
            player.OpenUCTLyricsRequested += UserControlA_OpenUCTLyrics;
            player.OpenUCTKaraRequested += UserControlA_OpenUCTKara;
            pnl_Player.Controls.Add(player);
        }
        private void UserControlA_OpenUCTLyrics(object sender, EventArgs e)
        {
            uct_lyrics lyrics = new uct_lyrics(x.title);
            // Gọi phương thức OpenUserControlB
            lyrics.OpenUCTLyrics(x);
            panel1.Controls.Add(lyrics);
            lyrics.BringToFront();
        }
        private void UserControlA_OpenUCTKara(object sender, EventArgs e)
        {
            uct_lyrics lyrics = new uct_lyrics(x.title);
            // Gọi phương thức OpenUserControlB
            lyrics.OpenUCTKara(x);
            panel1.Controls.Add(lyrics);
            lyrics.BringToFront();
        }
        void morong()
        {
            panel2.Height = 148;
            panel2.Location = new Point(0, 2);
            panel4.Location = new Point(0, 149);
            panel3.Location = new Point(0, 280);
        }
        void thunho()
        {
            panel2.Height = 38;
            panel2.Location = new Point(0, 2);
            panel4.Location = new Point(0, 40);
            panel3.Location = new Point(0, 170);
        }
        private void playlist_b_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = false;
            panel2.Height = 50;
            thunho();
            playlist_b.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;
            acc.FillColor = SystemColors.WindowFrame;
            setting.FillColor = SystemColors.WindowFrame;
            playlist Playlist = new playlist();
            panel1.Controls.Add(Playlist);
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

            if (panel2.Height != 148)//mở rộng
                morong();
            else
            {
                thunho();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Height = 50;
            thunho();
            
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
            acc.FillColor = SystemColors.WindowFrame;
            setting.FillColor = SystemColors.WindowFrame;
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
            acc.FillColor = SystemColors.WindowFrame;
            setting.FillColor = SystemColors.WindowFrame;
        }

        private void guna2Button1_Click(object sender, EventArgs e)//profile
        {
            find.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            acc.FillColor = SystemColors.AppWorkspace;
            setting.FillColor = SystemColors.WindowFrame;
            panel1.Controls.Clear();
            uctacc uctacc = new uctacc();
            panel1.Controls.Add(uctacc);
        }

        private void setting_Click(object sender, EventArgs e)
        {
            find.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            setting.FillColor = SystemColors.AppWorkspace;
            acc.FillColor = SystemColors.WindowFrame;
            panel1.Controls.Clear();
            uctacc uctacc = new uctacc();
        }
    }
}
