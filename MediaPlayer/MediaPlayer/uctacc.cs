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
    public partial class uctacc : UserControl
    {
        public uctacc()
        {
            InitializeComponent();
        }
        string filepath;
        private void guna2CirclePictureBox1_MouseMove(object sender, MouseEventArgs e)//ava
        {
            guna2CirclePictureBox1.SendToBack();
            guna2CirclePictureBox2.BringToFront();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox2.SendToBack();
            guna2CirclePictureBox1.BringToFront();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;

            }
            guna2CirclePictureBox1.ImageLocation = filepath;
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void guna2CirclePictureBox2_MouseLeave(object sender, EventArgs e)
        {
            guna2CirclePictureBox2.SendToBack();
            guna2CirclePictureBox1.BringToFront();
        }
    }
}
