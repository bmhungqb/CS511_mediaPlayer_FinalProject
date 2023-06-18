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
    public partial class uct_playlist1 : UserControl
    {
        public event EventHandler OpenUserControlBRequested;
        public uct_playlist1()
        {
            InitializeComponent();
        }
        public string name()
        {
            return label4.Text;
        }
        private void uct_playlist1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            OpenUserControlBRequested?.Invoke(this, EventArgs.Empty);
        }
        private void uct_playlist1_Click(object sender, EventArgs e)
        {
            OpenUserControlBRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
