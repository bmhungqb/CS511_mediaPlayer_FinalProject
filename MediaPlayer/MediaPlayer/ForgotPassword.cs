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
using MediaPlayer.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediaPlayer
{
    public partial class ForgotPassword : Form
    {
        MediaPlayer.Mail.GetPassword mail = new GetPassword();
        string user = string.Empty;
        string ema = string.Empty;
        string Code = string.Empty;
        public ForgotPassword()
        {
            InitializeComponent();
            
        }
        private void send()
        {
            user = name.Text ?? string.Empty;
            string filepath = Path.Combine(name.Text, "infor.txt");
            string[] lines = File.ReadAllLines(filepath);
            ema = lines[0].Split('\t')[1];
            Code = lines[0].Split('\t')[4];
            mail.handleSendCode(ema, user, Code);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            send();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            send();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)//back
        {
            Close();
        }
    }
}
