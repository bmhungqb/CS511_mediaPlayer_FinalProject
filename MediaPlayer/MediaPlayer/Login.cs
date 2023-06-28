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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace MediaPlayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void doimau()
        {
            Random rd = new Random();
            lb_title.ForeColor = Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doimau();
        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            //this.Hide();
            signup Signup = new signup();
            guna2CustomGradientPanel1.Controls.Add(Signup);
            Signup.BringToFront();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tb_name.Text))//already exists
            {
                string pass = string.Empty;
                using (StreamReader sr = new StreamReader(Path.Combine(tb_name.Text, "infor.txt")))
               {
                    string s= sr.ReadLine();
                    string[] s1 = s.Split('\t');
                    pass = s1[4];
                }
                if (tb_password.Text == pass || guna2TextBox1.Text==pass)
                {
                    mediaPlayer mediaPlayer = new mediaPlayer();
                    mediaPlayer.Show();
                    user.x = new User(tb_name.Text);
                    this.Hide();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Wrong Password!", "Warning", MessageBoxButtons.RetryCancel);
                    if (res == DialogResult.Retry)
                        tb_password.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Account doesn't exists!", "Warning", MessageBoxButtons.OK);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            tb_password.SendToBack();
            guna2TextBox1.Text = tb_password.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            tb_password.BringToFront();
            tb_password.Text = guna2TextBox1.Text;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
        }
    }
}
