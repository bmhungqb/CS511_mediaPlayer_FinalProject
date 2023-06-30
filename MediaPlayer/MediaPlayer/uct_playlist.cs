using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.API;
namespace MediaPlayer
{
    public partial class uct_playlist : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public uct_playlist()
        {
            InitializeComponent();
        }
        public static string ConvertToMinutesAndSeconds(int totalSeconds)
        {
            int hour = totalSeconds / 3600;
            int minutes = totalSeconds % 3600 / 60;
            int seconds = totalSeconds % 3600 % 60;

            string formattedTime = $"{hour} hours " + 
                $"{minutes} mins " + $"{seconds.ToString("D2")} secs";

            return formattedTime;
        }
        public async void OpenUserControlB(Playlist a)
        {
            // Thực hiện các hành động cần thiết khi mở UserControlB
          //  guna2CustomGradientPanel2.Width = 1370;
            string res = await zingMp3Api.GetDetailPlaylist(a.playlistId);
            a=Utils.getPlaylist(res);
            List<Song> songs = a.listSongs;
            name.Text = a.title;
            pic_thumb_artist.Image = Utils.getImage(a.thumbnailM);
            //List<string> lyricsList = lyrics.lyric;
            //// Thực hiện các hành động cần thiết khi mở UserControlB
            int i;
            for (i = 1; i < songs.Count; i++) 
            {
                uct_song curr = new uct_song(i.ToString(),songs[i]);
                flowLayoutPanel1.Controls.Add(curr);
            }
            label3.Text = a.totalSongs.ToString() + " songs, " + ConvertToMinutesAndSeconds(a.totalDuration);
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.setCurrentListSong(songs);
        }

       
        private void uct_playlist_Load(object sender, EventArgs e)
        {
            //mediaPlayer main = this.ParentForm as mediaPlayer;
            //DS_SearchMusic res_searchMusic = apiMusic.searchMusic(name.Text, "artist,song", 10);
            //main.setCurrentListSong(res_searchMusic.Songs);
            //int id = 0;
            //int time = 0;
            //foreach (Song song in res_searchMusic.Songs)
            //{
            //    id++;
            //    uct_song new_Song = new uct_song(id, song);
            //    flowLayoutPanel1.Controls.Add(new_Song);
            //    time += int.Parse(song.duration);
            //}
            //int minutes = time / 60;
            //int seconds = time % 60;

            //string formattedTime = $"{minutes} min {seconds.ToString("D2")} secs ";
            //label3.Text = id.ToString() + " songs,  " + formattedTime;
            //// get avatar artist 
            //if (res_searchMusic.Artists.Count > 0)
            //{
            //    Artist artist = res_searchMusic.Artists[0];
            //    pic_thumb_artist.Image = apiMusic.getImage(artist.thumb);
            //}
            //apiMusic.getLyrics("https://static-zmp3.zmdcdn.me/lyrics/2/b/8/f/2b8f4c339157d10a8c1ab80fa8d25424.lrc");
            //string lyric = await zingMp3.GetChartHome();
            //string lyric = await zingMp3.GetNewReleaseChart();
            //string lyric = await zingMp3.GetListArtistSong("IW6BZA76","1","30");
            //Console.WriteLine(lyric);
        }

        private void search_textbox_IconLeftClick_1(object sender, EventArgs e)
        {
            //pictureBox5.Visible = true;
            //search_textbox.Visible = false;
            //search_textbox.Text = "Search in playlist";
            //pictureBox5.BringToFront();
            //search_textbox.SendToBack();
        }

        private void search_textbox_DoubleClick_1(object sender, EventArgs e)
        {
            //search_textbox.Text = string.Empty;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            //pictureBox5.Visible = false;
            //search_textbox.Visible = true;
            //pictureBox5.SendToBack();
            //search_textbox.BringToFront();
        }
        private void pictureBox7_Click_1(object sender, EventArgs e)//back
        {
            this.Hide();
        }
    }
}
