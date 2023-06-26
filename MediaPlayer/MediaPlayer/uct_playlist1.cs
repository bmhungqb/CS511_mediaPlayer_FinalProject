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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class uct_playlist1 : UserControl
    {
        public event EventHandler OpenUserControlBRequested;
        public string filepath;
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public uct_playlist1(string path)
        {
            InitializeComponent();
            filepath = path;
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
        public async void load()
        {
            string infor = Path.Combine(filepath, "playlistInfor.txt");
            string list = Path.Combine(filepath, "listSongs.txt");
            BackColor = Color.Transparent;
            string[] listSongs = File.ReadAllLines(list);
            Song song = new Song();
            string playlistName = "";
            using (StreamReader streamReader = new StreamReader(infor))
            {
                string s;
                while ((s = streamReader.ReadLine()) != null)
                    playlistName = s;
            }
            label4.Text = playlistName;
            int time = 0;
            if (File.ReadAllText(list).Length == 0)
            {
                pictureBox4.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else
            {
                string res = await zingMp3Api.GetInfoSong(listSongs[0]);
                song = Utils.getInfoSong(res);
                pictureBox4.Image = Utils.getImage(song.thumbnail);
                foreach (string line in listSongs)
                {
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    time += song.duration;
                }
                label6.Text = listSongs.Length.ToString() + " songs, " + ConvertToMinutesAndSeconds(time);
            }
        }
        private async void uct_playlist1_Load(object sender, EventArgs e)
        {
            string infor = Path.Combine(filepath, "playlistInfor.txt");
            string list = Path.Combine(filepath, "listSongs.txt");
            BackColor = Color.Transparent;
            string[] listSongs = File.ReadAllLines(list);
            Song song = new Song();
            string playlistName="";
            using (StreamReader streamReader = new StreamReader(infor))
            {
                string s;
                while ((s = streamReader.ReadLine()) != null)
                    playlistName = s;
            }
            label4.Text = playlistName;
            int time = 0;
            if (File.ReadAllText(list).Length == 0)
            {
                pictureBox4.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else
            {
                string res = await zingMp3Api.GetInfoSong(listSongs[0]);
                song = Utils.getInfoSong(res);
                pictureBox4.Image = Utils.getImage(song.thumbnail);
                foreach (string line in listSongs)
                {
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    time += song.duration;
                }
                label6.Text = listSongs.Length.ToString() + " songs, " + ConvertToMinutesAndSeconds(time);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            OpenUserControlBRequested?.Invoke(this, EventArgs.Empty);
        }
        private void uct_playlist1_Click(object sender, EventArgs e)
        {
            OpenUserControlBRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
