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
using System.Runtime.CompilerServices;

namespace MediaPlayer
{
    public partial class uct_player : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public Song currentSong = new Song();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public uct_player()
        {
            InitializeComponent();
            playMusic(null);
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
            string res = await zingMp3Api.GetInfoSong("ZWADIOCC");
            currentSong = Utils.getInfoSong(res);
            string dataSong = await zingMp3Api.GetSong(currentSong.songId);
            player.URL = Utils.getSong(dataSong);

            player.PlayStateChange += Player_PlayStateChange;
            lblPlayDuration.Text = ConvertToMinutesAndSeconds(currentSong.duration);
            lbl_song.Text = currentSong.title;
            btn_Play.Checked = false;
            player.controls.pause();
            lbl_singer.Text = currentSong.artistsNames;
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);
        }
        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                TimeSpan durationTimeSpan = TimeSpan.FromSeconds(player.controls.currentItem.duration);
                sliderMusic.Maximum = (int)durationTimeSpan.TotalSeconds;
            }
        }
        private void toggleMusic(object sender, EventArgs e)
        {
            btn_Play.Checked = !btn_Play.Checked;
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
        public event EventHandler OpenUCTVideoRequested;
        private void guna2ImageButton7_Click(object sender, EventArgs e)//show lyrics
        {
            OpenUCTLyricsRequested?.Invoke(this, EventArgs.Empty);
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)//lyrics + kara
        {
            OpenUCTKaraRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            OpenUCTVideoRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
