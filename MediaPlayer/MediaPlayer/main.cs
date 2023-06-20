using Guna.UI2.WinForms;
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
        private void button_Click(object sender, EventArgs e)
        {
            Guna2Button guna2Button = sender as Guna2Button;
            switch(guna2Button.Name)
            {
                case "btn_hieuthuhai":
                    uct_playlist a = new uct_playlist(btn_hieuthuhai.Text);
                    panel1.Controls.Add(a);
                    a.BringToFront();
                    break;
                case "btn_sontungmtp":
                    uct_playlist b = new uct_playlist(btn_sontungmtp.Text);
                    panel1.Controls.Add(b);
                    b.BringToFront();
                    break;
                case "btn_denvau":
                    uct_playlist c = new uct_playlist(btn_denvau.Text);
                    panel1.Controls.Add(c);
                    c.BringToFront();
                    break;
            }
        }

        private void button_Click_Picture(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            switch (picture.Name)
            {
                case "pt_hot_hit":
                    uct_playlist hot_hit = new uct_playlist("Vũ trụ có anh");
                    panel1.Controls.Add(hot_hit);
                    hot_hit.BringToFront();
                    break;
                case "pt_den":
                    uct_playlist den = new uct_playlist(lb_denvau.Text);
                    panel1.Controls.Add(den);
                    den.BringToFront();
                    break;
                case "pt_justatee":
                    uct_playlist jus = new uct_playlist(lb_justatee.Text);
                    panel1.Controls.Add(jus);
                    jus.BringToFront();
                    break;
            }
        }
        private void button_Click_Picture_Circle(object sender, EventArgs e)
        {
            Guna2CirclePictureBox picture = sender as Guna2CirclePictureBox;
            switch (picture.Name)
            {
                case "pt_phuongly":
                    uct_playlist phuongly = new uct_playlist(lb_phuongly.Text);
                    panel1.Controls.Add(phuongly);
                    phuongly.BringToFront();
                    break;
                case "pt_dalab":
                    uct_playlist dalab = new uct_playlist(lb_dalab.Text);
                    panel1.Controls.Add(dalab);
                    dalab.BringToFront();
                    break;
            }
        }
    }
}
