using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class uct_playlist : UserControl
    {
        public uct_playlist(string y)
        {
            InitializeComponent();
            name.Text = y;
        }
        private void pictureBox5_Click(object sender, EventArgs e)//find
        {
            pictureBox5.Visible=false;
            search_textbox.Visible = true;
            pictureBox5.SendToBack();
            search_textbox.BringToFront();
        }
        private void search_textbox_IconLeftClick(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            search_textbox.Visible = false;
            search_textbox.Text = "Search in playlist";
            pictureBox5.BringToFront();
            search_textbox.SendToBack();
        }
        private void search_textbox_DoubleClick(object sender, EventArgs e)
        {
            search_textbox.Text = string.Empty;

        }

        private void label1_Click(object sender, EventArgs e)//edit details
        {
            edit_detail.Visible = true;
            edit_detail.Size = new Size(501, 264);
            edit_detail.Location = new Point(370, 229);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            edit_detail.Visible = false ;
            name.Text = name_change.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            edit_detail.Visible = false;
        }
        public void OpenUserControlB()
        {
            // Thực hiện các hành động cần thiết khi mở UserControlB
        }

        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            guna2CustomGradientPanel1.Controls.Clear();
            this.Hide();
        }

        private void uct_playlist_Load(object sender, EventArgs e)
        {
            uct_song song = new uct_song();
            song.Location = new Point(13, 437);
            //panel1.Controls.Clear();
            guna2CustomGradientPanel1.Controls.Add(song);
            song.BringToFront();
        }
    }
}
