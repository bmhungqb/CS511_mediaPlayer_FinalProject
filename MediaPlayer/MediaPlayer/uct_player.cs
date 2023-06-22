using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Windows;
using WMPLib;
using MediaPlayer.API;
using Guna.UI2.WinForms;

namespace MediaPlayer
{
    public partial class uct_player : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api;
        MediaPlayer.API.Utils Utils;
        public uct_player()
        {
            InitializeComponent();
        }
        public static string ConvertToMinutesAndSeconds(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = $"{minutes}:{seconds.ToString("D2")}";

            return formattedTime;
        }
        List<Song> currentPlaylist = new List<Song>();
        int orderSong = 0;
        public void SetCurrentPlaylist(List<Song> listSongs)
        {
            currentPlaylist = listSongs;
        }
        public async void playMusic(Song song)
        {
            string dataSong = await zingMp3Api.GetSong(song.songId);
            player.URL = Utils.getSong(dataSong);

            player.PlayStateChange += Player_PlayStateChange;
            lblPlayDuration.Text = ConvertToMinutesAndSeconds(song.duration);
            lbl_song.Text = song.title;
            btn_Play.Checked = false;
            player.controls.pause();    
            lbl_singer.Text = song.artistsNames;
            pt_thumb.Image = Utils.getImage(song.thumbnail);
        }
        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                TimeSpan durationTimeSpan = TimeSpan.FromSeconds(player.controls.currentItem.duration);
                sliderMusic.Maximum = (int)durationTimeSpan.TotalSeconds;
            }
        }
        #region define player
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string img_btn_stop = "C:\\Users\\bmhun\\Documents\\TaiLieuHocTapDaiHoc\\Year2\\HK_II\\UIT\\C-Sharp\\Doan\\CS511_mediaPlayer_FinalProject\\MediaPlayer\\MediaPlayer\\Resources\\352073_circle_fill_play_icon.png";
        string img_btn_play = "C:\\Users\\bmhun\\Documents\\TaiLieuHocTapDaiHoc\\Year2\\HK_II\\UIT\\C-Sharp\\Doan\\CS511_mediaPlayer_FinalProject\\MediaPlayer\\MediaPlayer\\Resources\\3669309_pause_circle_filled_ic_icon.png";
        string musicPath = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/Doan/CS511_mediaPlayer_FinalProject/MediaPlayer/MediaPlayer/Resources/cuoituan.mp3";
        #endregion
        private void toggleMusic(object sender, EventArgs e)
        {
            btn_Play.Checked = !btn_Play.Checked;
            if (player.playState ==  WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();
            }
            else
            {
                player.controls.play();
            }
        }

        private void slider_volume(object sender, EventArgs e)
        {
            int volume = (int)sliderVolume.Value;
            player.settings.volume = volume;
        }

        private void trackTime_Tick(object sender, EventArgs e)
        {
            lblPlayCurrentTime.Text = player.controls.currentPositionString;
            sliderMusic.Value = (int)player.controls.currentPosition;
        }

        private void sliderMusic_Scroll(object sender, ScrollEventArgs e)
        {
            player.controls.currentPosition = sliderMusic.Value;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Guna2ImageButton btn = sender as Guna2ImageButton;
            btn.Checked = !btn.Checked;
        }
        private void btn_next_back_Click(object sender, EventArgs e)
        {
            Guna2ImageButton button = sender as Guna2ImageButton;
            if (button.Name == "btn_back")
            {
                if (currentPlaylist != null)
                {
                    if (orderSong == 0)
                    {
                        orderSong = currentPlaylist.Count - 1;
                    }
                    else orderSong--;
                    playMusic(currentPlaylist[orderSong]);
                }
            }
            else if (button.Name == "btn_next")
            {
                if (currentPlaylist != null)
                {
                    if (orderSong + 1 == currentPlaylist.Count)
                    {
                        orderSong = 0;
                    }
                    else orderSong++;
                    playMusic(currentPlaylist[orderSong]);
                }
            }
        }
        public event EventHandler OpenUCTLyricsRequested;
        public event EventHandler OpenUCTKaraRequested;
        private void guna2ImageButton7_Click(object sender, EventArgs e)//show lyrics
        {
            OpenUCTLyricsRequested?.Invoke(this, EventArgs.Empty);
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)//lyrics + kara
        {
            OpenUCTKaraRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
