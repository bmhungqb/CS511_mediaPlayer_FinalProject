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
    public partial class acc_infor : UserControl
    {
        public acc_infor()
        {
            InitializeComponent();
        }

        private void acc_infor_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            string directoryPath = user.x.name;
            string pass = string.Empty;
            using (StreamReader sr = new StreamReader(Path.Combine(directoryPath, "infor.txt")))
            {
                string s = string.Empty;
                s = sr.ReadLine();
                string[] s1 = s.Split('\t');
                name.Text = s1[0];
                birth.Text = s1[3];
                gender.Text = s1[2];
                email.Text = s1[1];
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)//log out
        {
            //mediaPlayer media = sender as mediaPlayer;
            //media.close();
        }
    }
}
