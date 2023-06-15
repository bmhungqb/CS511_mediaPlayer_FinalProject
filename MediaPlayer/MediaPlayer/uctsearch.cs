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
    public partial class uctsearch : UserControl
    {
        public uctsearch()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            guna2TextBox1.Text= string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)//all
        {
            guna2Button1.FillColor = Color.White;
            guna2Button1.ForeColor = Color.Black;
            guna2Button2.FillColor = SystemColors.WindowFrame;
            guna2Button2.ForeColor = Color.White;
            guna2Button3.FillColor = SystemColors.WindowFrame;
            guna2Button3.ForeColor = Color.White;
            guna2Button4.FillColor = SystemColors.WindowFrame;
            guna2Button4.ForeColor = Color.White;
        }

        private void guna2Button2_Click(object sender, EventArgs e)//songs
        {
            guna2Button2.FillColor = Color.White;
            guna2Button2.ForeColor = Color.Black;
            guna2Button1.FillColor = SystemColors.WindowFrame;
            guna2Button1.ForeColor = Color.White;
            guna2Button3.FillColor = SystemColors.WindowFrame;
            guna2Button3.ForeColor = Color.White;
            guna2Button4.FillColor = SystemColors.WindowFrame;
            guna2Button4.ForeColor = Color.White;
        }

        private void guna2Button3_Click(object sender, EventArgs e)//artists
        {
            guna2Button3.FillColor = Color.White;
            guna2Button3.ForeColor = Color.Black;
            guna2Button2.FillColor = SystemColors.WindowFrame;
            guna2Button2.ForeColor = Color.White;
            guna2Button1.FillColor = SystemColors.WindowFrame;
            guna2Button1.ForeColor = Color.White;
            guna2Button4.FillColor = SystemColors.WindowFrame;
            guna2Button4.ForeColor = Color.White;
        }

        private void guna2Button4_Click(object sender, EventArgs e)//playlists
        {
            guna2Button4.FillColor = Color.White;
            guna2Button4.ForeColor = Color.Black;
            guna2Button2.FillColor = SystemColors.WindowFrame;
            guna2Button2.ForeColor = Color.White;
            guna2Button3.FillColor = SystemColors.WindowFrame;
            guna2Button3.ForeColor = Color.White;
            guna2Button1.FillColor = SystemColors.WindowFrame;
            guna2Button1.ForeColor = Color.White;
        }
    }
}
