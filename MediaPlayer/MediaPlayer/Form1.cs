using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class mediaPlayer : Form
    {
        public mediaPlayer()
        {
            InitializeComponent();
        }
        private void home1_Click(object sender, EventArgs e)//home
        {
            panel_acc.Visible = false;
            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
            home1.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            create_b.FillColor = SystemColors.WindowFrame;
        }
        private void find_Click(object sender, EventArgs e)//search
        {
            panel_acc.Visible = false;
            panel1.Controls.Clear();
            uctsearch uctsearch = new uctsearch();
            panel1.Controls.Add(uctsearch);
            find.FillColor = SystemColors.AppWorkspace;
            home1.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            create_b.FillColor = SystemColors.WindowFrame;
        }

        private void playlist_b_Click(object sender, EventArgs e)//playlist
        {
            panel_acc.Visible = false;
            panel1.Controls.Clear();
            playlist_b.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;
            create_b.FillColor = SystemColors.WindowFrame;
        }
        private void create_b_Click(object sender, EventArgs e)//create
        {
            panel_acc.Visible = false;
            panel1.Controls.Clear();
            create_b.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            home1.FillColor = SystemColors.WindowFrame;
        }
        private void guna2Button3_Click(object sender, EventArgs e)//account
        {
            panel1.Controls.Clear();
            uctacc uctacc = new uctacc();
            panel1.Controls.Add(uctacc);
            home1.FillColor = SystemColors.WindowFrame;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            create_b.FillColor = SystemColors.WindowFrame;
            panel_acc.Visible = true;

        }
        private void mediaPlayer_Load_1(object sender, EventArgs e)
        {
            panel_acc.Visible = false;
            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
            home1.FillColor = SystemColors.AppWorkspace;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            create_b.FillColor = SystemColors.WindowFrame;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)//profile
        {
            guna2GradientButton1.FillColor2 = Color.DarkRed; 
            guna2GradientButton2.FillColor2 = Color.IndianRed;
            guna2GradientButton3.FillColor2 = Color.IndianRed;
            panel1.Controls.Clear();
            uctacc uctacc = new uctacc();
            panel1.Controls.Add(uctacc);
            home1.FillColor = SystemColors.WindowFrame;
            find.FillColor = SystemColors.WindowFrame;
            playlist_b.FillColor = SystemColors.WindowFrame;
            create_b.FillColor = SystemColors.WindowFrame;
            panel_acc.Visible = true;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)//settings
        {
            guna2GradientButton2.FillColor2 = Color.DarkRed;
            guna2GradientButton1.FillColor2 = Color.IndianRed;
            guna2GradientButton3.FillColor2 = Color.IndianRed;
            panel1.Controls.Clear();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)//account
        {
            guna2GradientButton3.FillColor2 = Color.DarkRed;
            guna2GradientButton2.FillColor2 = Color.IndianRed;
            guna2GradientButton1.FillColor2 = Color.IndianRed;
            panel1.Controls.Clear();
        }
    }
}
