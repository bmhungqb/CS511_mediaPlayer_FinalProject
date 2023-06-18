using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string x;
        private void UserControlA_OpenUserControlBRequested(object sender, EventArgs e)
        {
            uct_playlist playlist = new uct_playlist(x);
            // Gọi phương thức OpenUserControlB
            playlist.OpenUserControlB();
            panel.Controls.Add(playlist);
            playlist.BringToFront();
        }
        int y = 65;
        //y+209;
        private void playlist_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                userControlA = new uct_playlist1();
                userControlA.Location = new Point(3, y);
                x = userControlA.name();
                // Thêm UserControlA vào Form
                panel.Controls.Add(userControlA);
                userControlA.OpenUserControlBRequested += UserControlA_OpenUserControlBRequested;
                y += 209;
            }
        }
    }
}
