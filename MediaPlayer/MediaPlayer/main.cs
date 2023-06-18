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
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//den vau
        {
            uct_playlist a = new uct_playlist(button1.Text);
            panel1.Controls.Add(a);
            a.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)//st
        {
            uct_playlist a = new uct_playlist(button2.Text);
            panel1.Controls.Add(a);
            a.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uct_playlist a = new uct_playlist(button3.Text);
            panel1.Controls.Add(a);
            a.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//hothits
        {
            uct_playlist a = new uct_playlist(label4.Text);
            panel1.Controls.Add(a);
            a.BringToFront();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)//ply
        {
            uct_playlist a = new uct_playlist(label1.Text);
            panel1.Controls.Add(a);
            a.BringToFront();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)//dalab
        {
            uct_playlist a = new uct_playlist(label13.Text);
            panel1.Controls.Add(a);
            a.BringToFront();
        }
    }
}
