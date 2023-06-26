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

        private void uctacc_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            aboutme.FillColor2 = Color.DimGray;
            edit_profile.FillColor2 = Color.Transparent;
            acc_infor acc_Infor = new acc_infor();
            flowLayoutPanel1.Controls.Add(acc_Infor);            
        }
        private void aboutme_Click(object sender, EventArgs e)
        {
            
            aboutme.FillColor2 = Color.DimGray;
            edit_profile.FillColor2 = Color.Transparent;
            acc_infor infor = new acc_infor();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(infor);
        }

        private void edit_profile_Click(object sender, EventArgs e)
        {
            
            edit_profile.FillColor2 = Color.DimGray;
            aboutme.FillColor2 = Color.Transparent;
            acc_edit edit = new acc_edit();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(edit);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
          
            aboutme.FillColor2 = Color.DimGray;
            edit_profile.FillColor2 = Color.Transparent;
        }

        
    }
}
