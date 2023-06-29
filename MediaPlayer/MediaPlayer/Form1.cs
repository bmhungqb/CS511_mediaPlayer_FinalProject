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
        }
        uct_player player = new uct_player();
        public void testPlayMusic(Song song)
        {
            player.playMusic(song);
        }
        public void playRecs(string url)
        {
            player.playRec(url);
        }
        public void UpdateCurrentListSongs(List<Song> listSongs)
        {
            player.UpdateListSong(listSongs);
        }
        public void setCurrentListSong(List<Song> listSongs)
        {
            player.SetCurrentPlaylist(listSongs);
        }
        public void toggleLyricKara()
        {
            player.toggleBackLyricKara();
        }
        public void updatetimerLyricFromPlayer(int time)
        {
            uct_lyrics lyric = panel1.Controls.OfType<uct_lyrics>().FirstOrDefault();
            if(lyric != null)
            {
                lyric.updatetimerLyric(time);
            }
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
            player.OpenUCTPauseLyric += UserControlA_OpenUCTPauseLyric;
            pnl_Player.Controls.Add(player);
        }
        private void UserControlA_OpenUCTPauseLyric(object sender, EventArgs e)
        {
            uct_lyrics lyric = panel1.Controls.OfType<uct_lyrics>().FirstOrDefault();
            lyric.toggleTimerLyric();
        }
        private void UserControlA_OpenUCTVideo(object sender, EventArgs e)
        {
            uct_player player = sender as uct_player;
            uct_video video = new uct_video(player.currentSong);
            // Gọi phương thức OpenUserControlB
            panel1.Controls.Add(video);
            video.BringToFront();
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
                uct_setting uctsetting = new uct_setting();
                panel1.Controls.Clear();
                panel1.Controls.Add(uctsetting);
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
