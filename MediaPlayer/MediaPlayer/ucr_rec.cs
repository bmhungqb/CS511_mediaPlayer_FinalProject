using Guna.UI2.WinForms;
using MediaPlayer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MediaPlayer
{
    public partial class ucr_rec : UserControl
    {
        string ID;
        public string filepath;
        Song song = new Song();
        public ucr_rec(string id, string path)
        {
            InitializeComponent();
            ID= id;
            filepath= path;
            BackColor = Color.Transparent;
            song.isRecord = true;
            song.filePathRecord = filepath;
        }

        private void ucr_rec_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Path.Combine(user.x.name, "infor.txt"));
            if (lines.Length == 1)//chưa có ava
            {
                guna2CirclePictureBox1.Image = Properties.Resources.user;
            }
            else
            {
                guna2CirclePictureBox1.ImageLocation = lines[1];
            }
            string[] s = filepath.Split('\\');
            lb_id.Text = ID;
            lb_id.Text = ID;
            if (ID == "1")
            {
                lb_id.ForeColor = Color.Yellow;
            }
            else if (ID == "2")
            {
                lb_id.ForeColor = Color.Orange;
            }
            else if (ID == "3")
            {
                lb_id.ForeColor = Color.Silver;
            }
            lb_song.Text = s[s.Length-1];
            lb_singer.Text = user.x.name;
        }
       
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.playRecs(song);
        }
        public event EventHandler DelRecRequested;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DelRecRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
