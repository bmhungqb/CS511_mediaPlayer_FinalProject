using Guna.UI2.WinForms;
using MediaPlayer.API;
using MediaPlayer.Properties;
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
        //    panel1.AutoScroll = false;

        }
        uct_player player = new uct_player();
         public void testPlayMusic(Song song)
        {
            player.playMusic(song);
        }
        public void setCurrentListSong(List<Song> listSongs)
        {
            player.SetCurrentPlaylist(listSongs);
        }
        private void mediaPlayer_Load_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
            btn_home.Checked = true;
            btn_account.Checked = false;
            btn_playlist.Checked = false;
            btn_rank.Checked = false;
            btn_search.Checked = false;
            btn_setting.Checked = false;
            //Add player into pnl_Player
            player.OpenUCTLyricsRequested += UserControlA_OpenUCTLyrics;
            player.OpenUCTKaraRequested += UserControlA_OpenUCTKara;
            player.OpenUCTVideoRequested += UserControlA_OpenUCTVideo;
            pnl_Player.Controls.Add(player);
        }
        private void UserControlA_OpenUCTVideo(object sender, EventArgs e)
        {
           // panel1.Controls.Clear();
            uct_video lyrics = new uct_video();
            // Gọi phương thức OpenUserControlB
            //lyrics.OpenUCTLyrics(player.currentSong);
            panel1.Controls.Add(lyrics);
            lyrics.BringToFront();
        }
        private void UserControlA_OpenUCTLyrics(object sender, EventArgs e)
        {
          //  panel1.Controls.Clear();
            uct_player player = sender as uct_player;
            uct_lyrics lyrics = new uct_lyrics();
            // Gọi phương thức OpenUserControlB
            lyrics.OpenUCTLyrics(player.currentSong);
            panel1.Controls.Add(lyrics);
            lyrics.BringToFront();
        }
        private void UserControlA_OpenUCTKara(object sender, EventArgs e)
        {
          //  panel1.Controls.Clear();
            uct_player player = sender as uct_player;
            uct_lyrics lyrics = new uct_lyrics();
            // Gọi phương thức OpenUserControlB
            lyrics.OpenUCTKara(player.currentSong);
            panel1.Controls.Add(lyrics);
            lyrics.BringToFront();
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            Guna2CircleButton btn = sender as Guna2CircleButton;
            btn.Checked = !btn.Checked;
            btn_home.Checked = false;
            btn_account.Checked = false;
            btn_playlist.Checked = false;
            btn_rank.Checked = false;
            btn_search.Checked = false;
            btn_setting.Checked = false;
            if(btn.Checked)
            {
                btn_setting.Visible = true;
                btn_account.Visible = true;
            }
            else
            {
                btn_setting.Visible = false;
                btn_account.Visible = false;
            }
        }

        //private void home1_Click_1(object sender, EventArgs e)
        //{
        //    panel2.Height = 50;
        //    thunho();
        //    panel1.Controls.Clear();
        //    main home = new main();
        //    panel1.Controls.Add(home);
        //    home1.FillColor = SystemColors.AppWorkspace;
        //    find.FillColor = SystemColors.WindowFrame;
        //    playlist_b.FillColor = SystemColors.WindowFrame;
        //    acc.FillColor = SystemColors.WindowFrame;
        //    setting.FillColor = SystemColors.WindowFrame;
        //}

        //private void find_Click(object sender, EventArgs e)
        //{
        //    panel2.Height = 50;
        //    thunho();
        //    panel1.Controls.Clear();
        //    uctsearch uctsearch = new uctsearch();
        //    panel1.Controls.Add(uctsearch);
        //    find.FillColor = SystemColors.AppWorkspace;
        //    home1.FillColor = SystemColors.WindowFrame;
        //    playlist_b.FillColor = SystemColors.WindowFrame;
        //    acc.FillColor = SystemColors.WindowFrame;
        //    setting.FillColor = SystemColors.WindowFrame;
        //}

        //private void guna2Button1_Click(object sender, EventArgs e)//profile
        //{
        //    find.FillColor = SystemColors.WindowFrame;
        //    home1.FillColor = SystemColors.WindowFrame;
        //    playlist_b.FillColor = SystemColors.WindowFrame;
        //    acc.FillColor = SystemColors.AppWorkspace;
        //    setting.FillColor = SystemColors.WindowFrame;
        //    panel1.Controls.Clear();
        //    uctacc uctacc = new uctacc();
        //    panel1.Controls.Add(uctacc);
        //}

        //private void setting_Click(object sender, EventArgs e)
        //{
        //    find.FillColor = SystemColors.WindowFrame;
        //    home1.FillColor = SystemColors.WindowFrame;
        //    playlist_b.FillColor = SystemColors.WindowFrame;
        //    setting.FillColor = SystemColors.AppWorkspace;
        //    acc.FillColor = SystemColors.WindowFrame;
        //    panel1.Controls.Clear();
        //    uctacc uctacc = new uctacc();
        //}

        //private void guna2Button1_Click_1(object sender, EventArgs e)//rank
        //{
        //    find.FillColor = SystemColors.WindowFrame;
        //    home1.FillColor = SystemColors.WindowFrame;
        //    playlist_b.FillColor = SystemColors.WindowFrame;
        //    setting.FillColor = SystemColors.WindowFrame;
        //    guna2Button1.FillColor = SystemColors.AppWorkspace;
        //    acc.FillColor = SystemColors.WindowFrame;
        //    panel1.Controls.Clear();
        //}
        private void button_Click(object sender, EventArgs e)
        {
            Guna2CircleButton button = sender as Guna2CircleButton;
            if(button.Name == "btn_home")
            {
             panel1.Controls.Clear();
                main home = new main();
                panel1.Controls.Add(home);
                btn_home.Checked = true;
                btn_account.Checked = false;
                btn_playlist.Checked = false;
                btn_rank.Checked = false;
                btn_search.Checked = false;
                btn_setting.Checked = false;
                btn_list.Checked = false;
            }
            else if(button.Name == "btn_search")
            {
               panel1.Controls.Clear();
                uctsearch uctsearch = new uctsearch();
                panel1.Controls.Add(uctsearch);
                btn_home.Checked = false;
                btn_account.Checked = false;
                btn_playlist.Checked = false;
                btn_rank.Checked = false;
                btn_search.Checked = true;
                btn_setting.Checked = false;
                btn_list.Checked = false;
            }
            else if( button.Name == "btn_playlist")
            {
                panel1.Controls.Clear();
              //  panel1.AutoScroll = false;
                playlist Playlist = new playlist();
                panel1.Controls.Add(Playlist);
                btn_home.Checked = false;
                btn_account.Checked = false;
                btn_playlist.Checked = true;
                btn_rank.Checked = false;
                btn_search.Checked = false;
                btn_setting.Checked = false;
                btn_list.Checked = false;
            }
            else if(button.Name == "btn_rank")
            {
                panel1.Controls.Clear();
                btn_home.Checked = false;
                btn_account.Checked = false;
                btn_playlist.Checked = false;
                btn_rank.Checked = true;
                btn_search.Checked = false;
                btn_setting.Checked = false;
                btn_list.Checked = false;
                uct_rank rank = new uct_rank();
                panel1.Controls.Add(rank);
            }
            else if(button.Name == "btn_setting")
            {
                btn_home.Checked = false;
                btn_account.Checked = false;
                btn_playlist.Checked = false;
                btn_rank.Checked = false;
                btn_search.Checked = false;
                btn_setting.Checked = true;
                panel1.Controls.Clear();
                //uctacc uctacc = new uctacc();
            }
            else if(button.Name == "btn_account")
            {
                btn_home.Checked = false;
                btn_account.Checked = true;
                btn_playlist.Checked = false;
                btn_rank.Checked = false;
                btn_search.Checked = false;
                btn_setting.Checked = false;
                panel1.Controls.Clear();
                uctacc uctacc = new uctacc();
                panel1.Controls.Add(uctacc);
            }
        }
    }
}
