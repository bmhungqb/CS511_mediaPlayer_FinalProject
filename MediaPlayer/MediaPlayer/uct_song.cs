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
using Guna.UI2.WinForms;
using MediaPlayer.API;
namespace MediaPlayer
{
    public partial class uct_song : UserControl
    {
        string ID = null;
        MediaPlayer.API.ZingMp3Api zingMp3Ap = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        Song currentSong = new Song();
        public uct_song(string id, Song song)
        {
            InitializeComponent();
            pt_thumb.BringToFront();
            currentSong = song;
            ID= id;
        }
        public static string ConvertToMinutesAndSeconds(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = $"{minutes}:{seconds.ToString("D2")}";

            return formattedTime;
        }
        private void uct_song_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            lb_id.Text = ID;
            if(ID == "1")
            {
                lb_id.ForeColor = Color.Yellow;
            }
            else if(ID == "2")
            {
                lb_id.ForeColor= Color.Orange;
            }
            else if(ID == "3")
            {
                lb_id.ForeColor = Color.Silver;
            }
            lb_song.Text = currentSong.title;
            lb_singer.Text = currentSong.artistsNames;
            if (currentSong.album==null)
                lb_album.Text = string.Empty;
            else 
                lb_album.Text = currentSong.album.title;
            lb_time.Text = ConvertToMinutesAndSeconds(currentSong.duration);
            pt_thumb.Image = Utils.getImage(currentSong.thumbnail);
            string favor = Path.Combine(Path.Combine(user.x.name, "playlists"), "favor");
            // Đường dẫn đến danh sách bài hát yêu thích
            string filePath = Path.Combine(favor, "listSongs.txt");
            string lineToRemove = currentSong.songId;
            string[] lines = File.ReadAllLines(filePath);
            if (Array.IndexOf(lines, lineToRemove) != -1)
            {
                btn_tym.Checked = true;
            }
            else btn_tym.Checked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)//
        {
            pt_thumb.SendToBack();
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pt_thumb.BringToFront();
        }

        private void pt_thumb_Click(object sender, EventArgs e)
        {
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.testPlayMusic(currentSong);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string favor = Path.Combine(Path.Combine(user.x.name, "playlists"), "favor");
            // Đường dẫn đến danh sách bài hát yêu thích
            string filePath = Path.Combine(favor, "listSongs.txt");
            btn_tym.Checked = !btn_tym.Checked;
            if (btn_tym.Checked )//add to favorites
            {
                File.AppendAllText(filePath, currentSong.songId + "\n");
            }
            else //delete from favorites
            {
                // Dòng cần tìm và xóa
                string lineToRemove = currentSong.songId;

                // Mảng chứa các dòng trong tập tin
                string[] lines = File.ReadAllLines(filePath);

                // Kiểm tra xem dòng cần tìm có trong tập tin hay không
                if (Array.IndexOf(lines, lineToRemove) != -1)
                {
                    // Xóa dòng khỏi mảng
                    lines = lines.Where(line => line != lineToRemove).ToArray();

                    // Ghi lại các dòng còn lại vào tập tin
                    File.WriteAllLines(filePath, lines);
                }

            }
        }
    }
}
