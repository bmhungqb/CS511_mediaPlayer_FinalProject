using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Mail;

namespace MediaPlayer
{
    partial class ConfirmEmail : Form
    {
        MediaPlayer.Mail.MailRequest mail = new MailRequest();
        string name = string.Empty;
        string email = string.Empty;    
        string Code = string.Empty;
        public ConfirmEmail(string Email,string Name)
        {
            InitializeComponent();
            name = Name ?? string.Empty;
            email = Email ?? string.Empty;
            createCode();
        }
        private void createCode()
        {
            Random rdn = new Random();
            Code = rdn.Next(100000, 1000000).ToString();
            mail.handleSendCode(email, name, Code);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            createCode();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if(Code == input.Text)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong code!!!");
                DialogResult = DialogResult.No;
            }
            Close();
        }
    }
}
