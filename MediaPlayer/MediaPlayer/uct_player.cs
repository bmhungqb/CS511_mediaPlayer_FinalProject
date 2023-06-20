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
        MediaPlayer.API.APIMusic apiMusic = new MediaPlayer.API.APIMusic();
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
        public void playMusic(Song song)
        {
            player.URL = apiMusic.getAudio(song.id);
            player.PlayStateChange += Player_PlayStateChange;
            lblPlayDuration.Text = ConvertToMinutesAndSeconds(int.Parse(song.duration));
            lbl_song.Text = song.name;
            btn_Play.Checked = false;
            player.controls.pause();    
            lbl_singer.Text = song.artist;
            pt_thumb.Image = apiMusic.getImage(song.thumb);
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
    }
}
