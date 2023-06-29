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
        string path;
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
        public async void OpenUserControlB(string filepath)
        {
            path = filepath;
            string infor = Path.Combine(filepath, "playlistInfor.txt");
            string list = Path.Combine(filepath, "listSongs.txt");
            BackColor = Color.Transparent;
            string[] listSongs = File.ReadAllLines(list);
            string[] inforPlaylist = File.ReadAllLines(infor);
            Song song = new Song();
            name.Text = inforPlaylist[0];
            label3.Text = inforPlaylist[1];
            //int time = 0;
            if (name.Text == "Your records" || name.Text == "Your favorite songs")
            {
                pt_add.Visible = false;
                pt_add.Enabled = false;
            }
            if (name.Text == "Your records")
            {
                int count = 0;
                foreach (string line in listSongs)
                {
                    count++;
                    ucr_rec uct_Song = new ucr_rec(count.ToString(), line);
                    flow_song.Controls.Add(uct_Song);
                }
            }
            
            if (File.ReadAllText(list).Length == 0 || name.Text=="Your records")
            {
                pic_thumb_artist.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else if (name.Text!="Your records")
            {
                label7.Visible = true; label7.Enabled = true;
                string res = await zingMp3Api.GetInfoSong(listSongs[0]);
                song = Utils.getInfoSong(res);
                pic_thumb_artist.Image = Utils.getImage(song.thumbnail);
                int count = 0;
                List<Song> songs = new List<Song>();
                foreach (string line in listSongs)
                {
                    count++;
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    uct_song uct_Song = new uct_song(count.ToString(), song);
                    flow_song.Controls.Add(uct_Song);
                    songs.Add(song);
                }
                mediaPlayer main = this.ParentForm as mediaPlayer;
                main.UpdateCurrentListSongs(songs);
            }
        }
        private async void loaddata(string filepath)
        {
            string infor = Path.Combine(filepath, "playlistInfor.txt");
            string list = Path.Combine(filepath, "listSongs.txt");
            BackColor = Color.Transparent;
            string[] listSongs = File.ReadAllLines(list);
            string[] inforPlaylist = File.ReadAllLines(infor);
            Song song = new Song();
            name.Text = inforPlaylist[0];
            label3.Text = inforPlaylist[1];
            //int time = 0;
            if (name.Text == "Your records" || name.Text == "Your favorite songs")
            {
                pt_add.Visible = false;
                pt_add.Enabled = false;
            }
            if (name.Text == "Your records")
            {
                int count = 0;
                foreach (string line in listSongs)
                {
                    count++;
                    ucr_rec uct_Song = new ucr_rec(count.ToString(), line);
                    flow_song.Controls.Add(uct_Song);
                }
            }
            if (File.ReadAllText(list).Length == 0 || name.Text == "Your records")
            {
                pic_thumb_artist.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else if (name.Text != "Your records")
            {
                label7.Visible = true; label7.Enabled = true;
                string res = await zingMp3Api.GetInfoSong(listSongs[0]);
                song = Utils.getInfoSong(res);
                pic_thumb_artist.Image = Utils.getImage(song.thumbnail);
                int count = 0;
                int time = 0;
                List<Song> songs = new List<Song>();
                foreach (string line in listSongs)
                {
                    count++;
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    uct_song uct_Song = new uct_song(count.ToString(), song);
                    flow_song.Controls.Add(uct_Song);
                    time += song.duration;
                    songs.Add(song);
                }
                label3.Text = listSongs.Length.ToString() + " songs, " + ConvertToMinutesAndSeconds(time);
                mediaPlayer main = this.ParentForm as mediaPlayer;
                main.UpdateCurrentListSongs(songs);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)//refresh
        {
            flow_song.Controls.Clear();
            loaddata(path);
        }

        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            // this.Hide();
            string infor = Path.Combine(path, "playlistInfor.txt");
            string[] lines = File.ReadAllLines(infor);
            File.WriteAllText(infor, string.Empty);
            File.AppendAllText(infor, lines[0] + "\n" + label3.Text + "\n");

            playlist play  = new playlist();
            panel2.Controls.Add(play);
            play.BringToFront();
        }

        private void pt_add_Click(object sender, EventArgs e)//add music
        {
            uct_create uct_Create = new uct_create(path);
            panel2.Controls.Add(uct_Create);
            uct_Create.BringToFront();
        }
    }
}
