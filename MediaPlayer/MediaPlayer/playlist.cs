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
using System.Web.UI;
//using System.Web.UI;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class playlist : System.Windows.Forms.UserControl
    {
        string filepath;
        public playlist()
        {
            InitializeComponent();
            filepath = Path.Combine(user.x.name, "playlists");

        }
        private void UserControlA_OpenUserControlBRequested(object sender, EventArgs e)
        {
            uct_playlist1 uct_Playlist1 = sender as uct_playlist1;
            userplaylist playlist = new userplaylist();
            // Gọi phương thức OpenUserControlB
            playlist.OpenUserControlB(uct_Playlist1.filepath);
            panel1.Controls.Add(playlist);
            playlist.BringToFront();
        }
        private void playlist_Load(object sender, EventArgs e)
        {
            string[] thuMucCon = Directory.GetDirectories(filepath);
            foreach (string thuMuc in thuMucCon)
            {
                string tenThuMuc = Path.GetFileName(thuMuc);
                if (tenThuMuc == "records")
                    continue;
                else
                {
                    string filepath = Path.Combine(Path.Combine(user.x.name, "playlists"), tenThuMuc);
                    uct_playlist1 uct_Playlist = new uct_playlist1(filepath);
                    panel.Controls.Add(uct_Playlist);
                    uct_Playlist.OpenUserControlBRequested += UserControlA_OpenUserControlBRequested;
                    uct_Playlist.DelPlaylistRequested += Uct_Playlist_DelPlaylistRequested;
                }
            }
        }
        public void reload()
        {
            panel.Controls.Clear();
            string[] thuMucCon = Directory.GetDirectories(filepath);
            foreach (string thuMuc in thuMucCon)
            {
                string tenThuMuc = Path.GetFileName(thuMuc);
                if (tenThuMuc == "records")
                    continue;
                else
                {
                    string filepath = Path.Combine(Path.Combine(user.x.name, "playlists"), tenThuMuc);
                    uct_playlist1 uct_Playlist = new uct_playlist1(filepath);
                    panel.Controls.Add(uct_Playlist);
                    uct_Playlist.OpenUserControlBRequested += UserControlA_OpenUserControlBRequested;
                    uct_Playlist.DelPlaylistRequested += Uct_Playlist_DelPlaylistRequested;
                }
            }
        }
        private void Uct_Playlist_DelPlaylistRequested(object sender, EventArgs e)
        {
            uct_playlist1 uct_Playlist1 = sender as uct_playlist1;
            DialogResult dialogResult = MessageBox.Show("Confirm to delete this playlist?","Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//delete
            {
                Directory.Delete(uct_Playlist1.filepath, true);
                this.reload();
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text=string.Empty;
        }

        private void guna2Button2_Click(object sender, EventArgs e)//create new playlist
        {
            string[] thuMucCon = Directory.GetDirectories(filepath);
            int min = 0;
            foreach (string thuMuc in thuMucCon)
            {
                string tenThuMuc = Path.GetFileName(thuMuc);
                if (tenThuMuc == "favor" || tenThuMuc == "records")
                    continue;
                else if (int.Parse(tenThuMuc) > min)
                    min = int.Parse(tenThuMuc);
            }
            //tạo folder
            string new_playlist = Path.Combine(filepath, (min+1).ToString());
            Directory.CreateDirectory(new_playlist);

            //tạo infor
            using (StreamWriter sw = File.CreateText(Path.Combine(new_playlist, "playlistInfor.txt")))
            {

                string s = "My playlist#" + (min+1).ToString();
                sw.WriteLine(s);
                sw.WriteLine("0 songs");
            }
            //tạo danh sách bài hát
            FileStream fileStream= File.Create(Path.Combine(new_playlist, "listSongs.txt"));
            fileStream.Close();
            uct_create create = new uct_create(new_playlist); 
            panel1.Controls.Add(create);
            create.BringToFront();
        }
    }
}
