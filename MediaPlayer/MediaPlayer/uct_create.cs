using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace MediaPlayer
{
    public partial class uct_create : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        string filepath;
        string infor;
        string list;
        public uct_create(string path)
        {
            InitializeComponent();
            filepath = path;
            infor = Path.Combine(filepath, "playlistInfor.txt");
            list = Path.Combine(filepath, "listSongs.txt");
        }
        private void DeleteUctSongs()
        {
            var utcSongs = flowLayoutSearch.Controls.OfType<uct_song>().ToList();
            foreach (var utcSong in utcSongs)
            {
                flowLayoutSearch.Controls.Remove(utcSong);
                utcSong.Dispose();
            }
        }
        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = string.Empty;
        }

        private async void uct_create_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(infor);
            string[] listSong = File.ReadAllLines(list);
            name.Text = lines[0];
            label3.Text = lines[1].Split(',')[0];
            if (listSong.Length == 0)
            {
                list_song.Controls.Clear();
                pictureBox4.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else
            {
                Song firstSong = new Song();
                string res = await zingMp3Api.GetInfoSong(listSong[0]);
                firstSong = Utils.getInfoSong(res);
                pictureBox4.Image = Utils.getImage(firstSong.thumbnail);
                foreach (string line in listSong)
                {
                    Song song = new Song();
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    uct_song2 uct_Song = new uct_song2(list, song);
                    uct_Song.DelSongRequested += Uct_Song2_DelSongRequested;
                    list_song.Controls.Add(uct_Song);
                }
            }
        }
        private async void update()
        {
            string[] listSong = File.ReadAllLines(list);
            label3.Text = listSong.Length.ToString() + " songs";
            if (File.ReadAllText(list).Length == 0)
            {
                pictureBox4.Image = Properties.Resources._3669182_video_library_ic_icon;
            }
            else
            {
                Song song = new Song();
                string res = await zingMp3Api.GetInfoSong(listSong[0]);
                song = Utils.getInfoSong(res);
                pictureBox4.Image = Utils.getImage(song.thumbnail);
            }
        }
        private async void pictureBox7_Click(object sender, EventArgs e)//back
        {
            string[] listSong = File.ReadAllLines(list);
            if (listSong.Length == 0)
            {
                File.WriteAllText(infor, string.Empty);
                File.AppendAllText(infor, name.Text + "\n" + "0 songs" + "\n");
            }
            else
            {
                File.WriteAllText(infor, string.Empty);
                int time = 0;
                foreach (string line in listSong)
                {
                    Song song = new Song();
                    string ress = await zingMp3Api.GetInfoSong(line);
                    song = Utils.getInfoSong(ress);
                    time += song.duration;
                }
                File.AppendAllText(infor, name.Text + "\n" + listSong.Length.ToString() + " songs, " +
                    ConvertToMinutesAndSeconds(time));
            }
            userplaylist play = new userplaylist();
            // Gọi phương thức OpenUserControlB
            play.OpenUserControlB(filepath);
            panel4.Controls.Add(play);
            play.BringToFront();
        }
        static string BoDauTiengViet(string chuoi)
        {
            string[] dauTiengViet = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ" };
            string[] khongDauTiengViet = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y" };

            for (int i = 0; i < dauTiengViet.Length; i++)
            {
                chuoi = Regex.Replace(chuoi, dauTiengViet[i], khongDauTiengViet[i]);
                chuoi = Regex.Replace(chuoi, dauTiengViet[i].ToUpper(), khongDauTiengViet[i].ToUpper());
            }

            return chuoi;
        }
        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_search.Text == "") return;
                SearchSong(tb_search.Text);
            }
        }
        private async void SearchSong(string request)
        {
            DeleteUctSongs();
            string resSearch = await zingMp3Api.Search(BoDauTiengViet(request));
            Search search = new Search();
            search = Utils.handleSearch(resSearch);
            flowLayoutSearch.Controls.Clear();
            for (int i = 0; i < search.listSongs.Count; i++)
            {
                uct_song1 uct_Song = new uct_song1(list, search.listSongs[i]);
                uct_Song.AddMusicRequested += Uct_Song_AddMusicRequested;
                flowLayoutSearch.Controls.Add(uct_Song);
            }
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
        private void Uct_Song_AddMusicRequested(object sender, EventArgs e)
        {
            //uct_song1 uct = sender as uct_song1;
            //uct_song2 uct_Song2 = new uct_song2(uct.listSong, uct.currentSong);
            //uct_Song2.DelSongRequested += Uct_Song2_DelSongRequested;
            //list_song.Controls.Add(uct_Song2);
            //string[] totalSong = File.ReadAllLines(uct.listSong);
            //label3.Text = totalSong.Length.ToString() + " songs";
            update();
            reload();
        }
        private async void reload()
        {
            string[] listSong = File.ReadAllLines(list);
            list_song.Controls.Clear();
            foreach (string line in listSong)
            {
                Song song = new Song();
                string ress = await zingMp3Api.GetInfoSong(line);
                song = Utils.getInfoSong(ress);
                uct_song2 uct_Song = new uct_song2(list, song);
                uct_Song.DelSongRequested += Uct_Song2_DelSongRequested;
                list_song.Controls.Add(uct_Song);
            }
            
        }
        private void Uct_Song2_DelSongRequested(object sender, EventArgs e)
        {
            uct_song2 uct_Song2 = sender as uct_song2;
            string songToRemove = uct_Song2.currentSong.songId;
            string[] lines = File.ReadAllLines(list);
            if (Array.IndexOf(lines, songToRemove) != -1)
            {
                lines = lines.Where(line => line != songToRemove).ToArray();
                File.WriteAllLines(list, lines);
            }
            update();
            reload();
        }

        private void name_Click(object sender, EventArgs e)
        {
            if (name.Text != "Your favorite songs")
            {
                edit.Visible = true;
                edit.Focus();
                name.Visible = false;
            }
        }

        private void edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (edit.Text == "") return;
                name.Text = edit.Text;
                edit.Visible = false;
                name.Visible = true;
            }
        }
    }
}
