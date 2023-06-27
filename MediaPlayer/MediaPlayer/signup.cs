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
namespace MediaPlayer
{
    public partial class signup : UserControl
    {
        public signup()
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
            if (Directory.Exists(tb_name.Text))//already exists
            {
                DialogResult dlr = MessageBox.Show("User's name already exists!", "Warning", MessageBoxButtons.OK);
                tb_name.Text = string.Empty;
            }
            else//create
            {
                ConfirmEmail confirmEmail = new ConfirmEmail(tb_email.Text,tb_name.Text);
                DialogResult resDia =  confirmEmail.ShowDialog();
                if(resDia == DialogResult.OK)
                {
                    Directory.CreateDirectory(tb_name.Text);
                    //tạo file thông tin của user
                    string infor = "infor.txt";
                    using(StreamWriter sw = File.CreateText(Path.Combine(tb_name.Text, infor)))
                    {
                  
                        string birth = day.SelectedItem.ToString()+ "/" + month.SelectedItem.ToString() + "/" + year.Text;
                        string s = tb_name.Text + "\t" + tb_email.Text + "\t" + gender.SelectedItem.ToString() + "\t" + birth + "\t" + password.Text + "\t";
                        sw.WriteLine(s);
                    }
                    //tạo folder playlists
                    string playlists = Path.Combine(tb_name.Text, "playlists");
                    Directory.CreateDirectory(playlists);

                    //tạo folder records trong playlists
                    string records = Path.Combine(playlists, "records");
                    Directory.CreateDirectory(records);

                    //tạo folder favorites song
                    string favor = Path.Combine(playlists, "favor");
                    Directory.CreateDirectory(favor);

                    //tạo infor của favorites song
                    using (StreamWriter sw = File.CreateText(Path.Combine(favor, "playlistInfor.txt")))
                    {

                        string s = "Your favorite songs";
                        sw.WriteLine(s);
                        sw.WriteLine("0 songs");
                    }
                    //tạo danh sách bài hát
                    File.Create(Path.Combine(favor, "listSongs.txt"));

                    DialogResult dlr = MessageBox.Show("Sign up success! Do you want to log in?", "Warning", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                        this.Hide();
                }
            }
        }
        private void tb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string directoryPath = tb_name.Text;
                if (Directory.Exists(directoryPath))//already exists
                {
                    DialogResult dlr = MessageBox.Show("User's name already exists!", "Warning", MessageBoxButtons.OK);
                    tb_name.Text = string.Empty;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            this.Hide();
        }
    }
}
