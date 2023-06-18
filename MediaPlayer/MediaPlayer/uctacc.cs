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

        private void uctacc_Load(object sender, EventArgs e)
        {
            label1.Text = name.Text;
            edit.Visible = false ;
            about.Size = new Size(1348, 533);
            about.Location = new Point(7, 423);
            aboutme.FillColor2= Color.DimGray;
            edit_profile.FillColor2= Color.Transparent;
        }

        private void aboutme_Click(object sender, EventArgs e)
        {
            edit.Visible = false;
            about.Visible = true;
            edit.SendToBack();
            about.BringToFront();
            about.Size = new Size(1348, 533);
            about.Location = new Point(7, 423);
            aboutme.FillColor2 = Color.DimGray;
            edit_profile.FillColor2 = Color.Transparent;
        }

        private void edit_profile_Click(object sender, EventArgs e)
        {
            about.Visible = false;
            edit.Visible= true;
            about.SendToBack();
            edit.Size = new Size(1348, 533);
            edit.Location = new Point(7, 423);
            edit.BringToFront();
            edit_profile.FillColor2 = Color.DimGray;
            aboutme.FillColor2 = Color.Transparent;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            edit.SendToBack();
            about.BringToFront();
            edit.Visible = false;
            about.Visible= true;
            about.Size = new Size(1348, 533);
            about.Location = new Point(7, 423);
            aboutme.FillColor2 = Color.DimGray;
            edit_profile.FillColor2 = Color.Transparent;
        }

        private void save_Click(object sender, EventArgs e)
        {
            name.Text = textBox1.Text;
            label1.Text = name.Text;
            gender.Text = comboBox1.Text;
            birth.Text = month.Text + " "+ day.Text+", "+ year.Text;
            email.Text = textBox2.Text;
        }
    }
}
