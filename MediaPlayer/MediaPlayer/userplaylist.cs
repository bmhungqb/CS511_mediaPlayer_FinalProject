using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class userplaylist : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public userplaylist()
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
        string path;
        public async void OpenUserControlB(string filepath)
        {
            path = filepath;
            string infor = Path.Combine(filepath, "playlistInfor.txt");
            string list = Path.Combine(filepath, "listSongs.txt");
            BackColor = Color.Transparent;
            string[] listSongs = File.ReadAllLines(list);
            Song song = new Song();
            using (StreamReader streamReader = new StreamReader(infor))
            {
                string s = streamReader.ReadLine();
                name.Text = s;
            }
            int count = 0;
            int time = 0;
            if (File.ReadAllText(list).Length == 0)
            {
                pic_thumb_artist.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else
            {
                string res = await zingMp3Api.GetInfoSong(listSongs[0]);
                song = Utils.getInfoSong(res);
                pic_thumb_artist.Image = Utils.getImage(song.thumbnail);
                foreach (string line in listSongs)
                {
                    count++; 
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    time += song.duration;
                    uct_song uct_Song = new uct_song(count.ToString(), song) ;
                    flow_song.Controls.Add(uct_Song) ;
                }
                label3.Text = count.ToString() + " songs, " + ConvertToMinutesAndSeconds(time);
            }
        }
        private async void loaddata(string filepath)
        {
            string infor = Path.Combine(filepath, "playlistInfor.txt");
            string list = Path.Combine(filepath, "listSongs.txt");
            BackColor = Color.Transparent;
            string[] listSongs = File.ReadAllLines(list);
            Song song = new Song();
            using (StreamReader streamReader = new StreamReader(infor))
            {
                string s = streamReader.ReadLine();
                name.Text = s;
            }
            int count = 0;
            int time = 0;
            if (File.ReadAllText(list).Length == 0)
            {
                pic_thumb_artist.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else
            {
                string res = await zingMp3Api.GetInfoSong(listSongs[0]);
                song = Utils.getInfoSong(res);
                pic_thumb_artist.Image = Utils.getImage(song.thumbnail);
                foreach (string line in listSongs)
                {
                    count++;
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    time += song.duration;
                    uct_song uct_Song = new uct_song(count.ToString(), song);
                    flow_song.Controls.Add(uct_Song);
                }
                label3.Text = count.ToString() + " songs, " + ConvertToMinutesAndSeconds(time);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)//refresh
        {
            flow_song.Controls.Clear();
            loaddata(path);
        }

        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            this.Hide();
        }
    }
}
