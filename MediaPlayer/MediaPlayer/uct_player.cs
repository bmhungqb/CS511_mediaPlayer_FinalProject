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
using System.IO;

namespace MediaPlayer
{
    public partial class uct_player : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public Song currentSong = new Song();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<Song> currentPlaylist = new List<Song>();
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
        int orderSong = 0;
        public void SetCurrentPlaylist(List<Song> listSongs)
        {
            currentPlaylist = listSongs;
        }
        public async void playMusic(Song song)
        {
            

            if (song == null)
            {
                string res = await zingMp3Api.GetInfoSong("ZWADIOCC");
                currentSong = Utils.getInfoSong(res);
            }
            else
            {
                string res = await zingMp3Api.GetInfoSong(song.songId);
                currentSong = Utils.getInfoSong(res);
            }
            string dataSong = await zingMp3Api.GetSong(currentSong.songId);
            player.URL = Utils.getSong(dataSong);

            player.PlayStateChange += Player_PlayStateChange;
            lblPlayDuration.Text = ConvertToMinutesAndSeconds(currentSong.duration);
            lbl_song.Text = currentSong.title;
            btn_Play.Checked = false;
            player.controls.pause();
            lbl_singer.Text = currentSong.artistsNames;
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);

            string favor = Path.Combine(Path.Combine(user.x.name, "playlists"), "favor");
            // Đường dẫn đến danh sách bài hát yêu thích
            string filePath = Path.Combine(favor, "listSongs.txt");
            string lineToRemove = currentSong.songId;
            string[] lines = File.ReadAllLines(filePath);
            if (Array.IndexOf(lines, lineToRemove) != -1)
            {
                guna2ImageButton1.Checked = true;
            }
            else guna2ImageButton1.Checked = false;
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
            else if(btn_Play.Checked)
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
        public static string ConvertToHoursAndSeconds(int totalSeconds)
        {
            int hour = totalSeconds / 3600;
            int minutes = totalSeconds % 3600 / 60;
            int seconds = totalSeconds % 3600 % 60;

            string formattedTime = $"{hour} hours " +
                $"{minutes} mins " + $"{seconds.ToString("D2")} secs";

            return formattedTime;
        }
        private async void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Guna2ImageButton btn = sender as Guna2ImageButton;
            btn.Checked = !btn.Checked;
            string favor = Path.Combine(Path.Combine(user.x.name, "playlists"), "favor");
            // Đường dẫn đến danh sách bài hát yêu thích
            string list = Path.Combine(favor, "listSongs.txt");
            string infor = Path.Combine(favor, "playlistInfor.txt");
            if (btn.Checked)//add to favorites
            {
                File.AppendAllText(list, currentSong.songId + "\n");
            }
            else //delete from favorites
            {
                string songToRemove = currentSong.songId;
                string[] lines = File.ReadAllLines(list);
                if (Array.IndexOf(lines, songToRemove) != -1)
                {
                    lines = lines.Where(line => line != songToRemove).ToArray();
                    File.WriteAllLines(list, lines);
                }
            }
            string[] listSongs = File.ReadAllLines(list);
            string[] inforPlaylist = File.ReadAllLines(infor);
            int time = 0;
            foreach (string line in listSongs)
            {
                Song song = new Song();
                string ress = await zingMp3Api.GetInfoSong(line);
                song = Utils.getInfoSong(ress);
                time += song.duration;
            }
            File.WriteAllText(infor, string.Empty);
            File.AppendAllText(infor, inforPlaylist[0] + "\n" + 
                listSongs.Length.ToString() + " songs, " +ConvertToHoursAndSeconds(time) + "\n");
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

        private void btn_speaker_Click(object sender, EventArgs e)
        {
            Guna2ImageButton btn = sender as Guna2ImageButton;
            btn.Checked = !btn.Checked;
            if(btn.Checked)
            {
                player.settings.volume = 0;
                sliderVolume.Value = 0; 
            }
            else
            {
                player.settings.volume = 20;
                sliderVolume.Value = 20;
            }
        }
    }
}
