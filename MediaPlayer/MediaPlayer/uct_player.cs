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
namespace MediaPlayer
{
    public partial class uct_player : UserControl
    {
        public uct_player()
        {
            InitializeComponent();
            playMusic(musicPath,"Cuối tuần");
        }
        public void playMusic(string url,string name)
        {
            player.URL = url;
            player.PlayStateChange += Player_PlayStateChange;
            guna2HtmlLabel1.Text = name;
            player.controls.pause();
            btn_Play.Image = Image.FromFile(img_btn_stop);
        }
        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                TimeSpan durationTimeSpan = TimeSpan.FromSeconds(player.controls.currentItem.duration);
                sliderMusic.Maximum = (int)durationTimeSpan.TotalSeconds;
                lblPlayDuration.Text = player.controls.currentItem.durationString;
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
            lblPlayDuration.Text = player.controls.currentItem.durationString;
            if (player.playState ==  WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();
                btn_Play.Image = Image.FromFile(img_btn_stop);
            }
            else
            {
                player.controls.play();
                btn_Play.Image = Image.FromFile(img_btn_play);
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
    }
}
