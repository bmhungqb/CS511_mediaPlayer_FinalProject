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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MediaPlayer
{
    public partial class uct_player : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public Song currentSong = new Song();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<Song> currentPlaylist = new List<Song> { };
        bool isAutoPlay = false;
        int orderSong = 0;
        public uct_player()
        {
            InitializeComponent();
        }
        public void handleRemovePlayStateChange()
        {
            player.PlayStateChange -= Player_PlayStateChange;
            player.PlayStateChange -= Player_PlayStateChangeRecord;
        }
        public void HandleModeAutoPlay(bool auto)
        {
            isAutoPlay = auto;
        }
        public static string ConvertToMinutesAndSeconds(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = $"{minutes}:{seconds.ToString("D2")}";

            return formattedTime;
        }
        public void SetCurrentPlaylist(List<Song> listSongs)
        {
            currentPlaylist.Clear();
            currentPlaylist = listSongs;
        }
        public void playRec(Song song)
        {
            player.URL = song.filePathRecord;
            string[] lines = File.ReadAllLines(Path.Combine(user.x.name, "infor.txt"));
            if (lines.Length == 1)//chưa có ava
            {
                pt_thumb.Image = Properties.Resources.user;
            }
            else
            {
                pt_thumb.ImageLocation = lines[1];
            }
            string[] s = song.filePathRecord.Split('\\');
            lbl_song.Text = s[s.Length - 1];
            lbl_singer.Text = user.x.name;
            btn_Play.Checked = false;
            player.controls.stop();
            player.PlayStateChange += Player_PlayStateChangeRecord;
            handleVisibleRecordoOrSong(false);
        }
        void handleVisibleRecordoOrSong(bool isSong)
        {
            guna2ImageButton1.Visible = isSong;
            guna2ImageButton1.Enabled = isSong;
            btn_random.Visible = isSong;
            btn_back.Visible = isSong;
            btn_next.Visible = isSong;
            btn_repeat.Visible = isSong;
            btn_video.Visible = isSong;
            btn_kara.Visible = isSong;
            btn_lyric.Visible = isSong;
        }
        private void Player_PlayStateChangeRecord(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsReady)
            {
                player.controls.pause();
                btn_Play.Checked = false;
            }
            else if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblPlayDuration.Text = player.currentMedia.durationString;
                TimeSpan durationTimeSpan = TimeSpan.FromSeconds(player.controls.currentItem.duration);
                sliderMusic.Maximum = (int)durationTimeSpan.TotalSeconds;
            }
            else if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                btn_Play.Checked = false;
            }
        }

        public async void playMusic(Song song)
        {
            handleVisibleRecordoOrSong(true);
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
            if(isAutoPlay)
            {
                btn_Play.Checked = true;
                player.controls.play();
            }   
            else
            {
                btn_Play.Checked = false;
                player.controls.pause();
            }
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
            if(NewState == (int)WMPLib.WMPPlayState.wmppsReady)
            {
                if(isAutoPlay)
                {
                    player.controls.play();
                    btn_Play.Checked = true;
                }
                else
                {
                    player.controls.pause();
                    btn_Play.Checked = false;   
                }
            }
            else if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                TimeSpan durationTimeSpan = TimeSpan.FromSeconds(player.controls.currentItem.duration);
                sliderMusic.Maximum = (int)durationTimeSpan.TotalSeconds;
                lblPlayDuration.Text = player.currentMedia.durationString;
            }
            else if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                btn_Play.Checked = false;
                if(btn_random.Checked)
                {
                    Random rdn = new Random();
                    int OrderSong = rdn.Next(0,currentPlaylist.Count-1);
                    currentSong = currentPlaylist[OrderSong];
                    orderSong = OrderSong;
                    if (currentPlaylist[orderSong].songId != null)
                    {
                        handleRemovePlayStateChange();
                        playMusic(currentPlaylist[orderSong]);
                    }
                }
                else if(btn_repeat.Checked)
                {
                    if (currentPlaylist[orderSong].songId != null)
                    {
                        handleRemovePlayStateChange();
                        playMusic(currentPlaylist[orderSong]);
                    }
                }
                else
                {
                    if (currentPlaylist.Count > 0)
                    {
                        if (orderSong + 1 == currentPlaylist.Count)
                        {
                            orderSong = 0;
                        }
                        else orderSong++;
                        if (currentPlaylist[orderSong].songId != null)
                        {
                            handleRemovePlayStateChange();
                            playMusic(currentPlaylist[orderSong]);
                        }
                    }
                }
            }
        }
        public event EventHandler OpenUCTPauseLyric;
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
            if(btn_kara.Checked || btn_lyric.Checked)
            {
                OpenUCTPauseLyric?.Invoke(this, new EventArgs());   
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
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.updatetimerLyricFromPlayer((int)player.controls.currentPosition* 1000);
        }
        private int ConvertTimeToSeconds(string time)
        {
            string[] timeParts = time.Split(':');
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);

            int totalSeconds = (hours * 60 * 60) + (minutes * 60);

            return totalSeconds;
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
                if (currentPlaylist.Count > 0)
                {
                    if (orderSong == 0)
                    {
                        orderSong = currentPlaylist.Count - 1;
                    }
                    else orderSong--;
                    if(currentPlaylist[orderSong].songId != null)
                    {
                        handleRemovePlayStateChange();
                        playMusic(currentPlaylist[orderSong]);
                    }
                }
            }
            else if (button.Name == "btn_next")
            {
                if (currentPlaylist.Count > 0)
                {
                    if (orderSong + 1 == currentPlaylist.Count)
                    {
                        orderSong = -1;
                    }
                    orderSong++;
                    if (currentPlaylist[orderSong] != null)
                    {
                        handleRemovePlayStateChange();
                        playMusic(currentPlaylist[orderSong]);
                    }
                }
            }
        }
        public event EventHandler OpenUCTLyricsRequested;
        public event EventHandler OpenUCTKaraRequested;
        public event EventHandler OpenUCTVideoRequested;

        private void btn_lyric_Click(object sender, EventArgs e)
        {
            btn_kara.Checked = false;
            Guna2ImageButton btn = sender as Guna2ImageButton;
            btn.Checked = !btn.Checked;
            OpenUCTLyricsRequested?.Invoke(this, EventArgs.Empty);
        }
        private void btn_kara_Click(object sender, EventArgs e)
        {
            btn_lyric.Checked = false;
            Guna2ImageButton btn = sender as Guna2ImageButton;
            btn.Checked = !btn.Checked;
            OpenUCTKaraRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            btn_kara.Checked = false;
            btn_lyric.Checked = false;
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

        private void uct_player_Load(object sender, EventArgs e)
        {
            if(currentPlaylist.Count == 0)
            {
                playMusic(null);
            }
            else
            {
                playMusic(currentPlaylist[0]);
            }
        }

        private void btn_mode_click(object sender, EventArgs e)
        {
            Guna2ImageButton btn = sender as Guna2ImageButton;
            if(btn.Name == "btn_random")
            {
                btn_repeat.Checked = false;
                btn_random.Checked = !btn_random.Checked;
            }
            else if(btn.Name == "btn_repeat")
            {
                btn_random.Checked = false;
                btn_repeat.Checked = !btn_repeat.Checked;
            }
        }
        public void toggleBackLyricKara()
        {
            btn_kara.Checked = false;
            btn_lyric.Checked = false;
        }
    }
}
