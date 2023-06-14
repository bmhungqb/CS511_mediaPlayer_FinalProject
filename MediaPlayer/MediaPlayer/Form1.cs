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

        private void mediaPlayer_Load(object sender, EventArgs e)
        {
            
        }

        private void home1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            main home = new main();
            panel1.Controls.Add(home);
        }
    }
}
