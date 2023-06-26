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
//using System.Web.UI;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class playlist : UserControl
    {

        private uct_playlist1 userControlA;
        private uct_playlist userControlB;
        public playlist()
        {
            InitializeComponent();
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
        int y = 65;
        //y+209;
        private void playlist_Load(object sender, EventArgs e)
        {
            string filepath = Path.Combine( Path.Combine(user.x.name, "playlists"), "favor");
            userControlA = new uct_playlist1(filepath);
            userControlA.Location = new Point(3, y);
            // Thêm UserControlA vào Form
            panel.Controls.Add(userControlA);
            userControlA.OpenUserControlBRequested += UserControlA_OpenUserControlBRequested;
            y += 209;
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text=string.Empty;
        }

        private void guna2Button2_Click(object sender, EventArgs e)//create new playlist
        {
            uct_create create = new uct_create(); 
            panel1.Controls.Add(create);
            create.BringToFront();
        }
    }
}
