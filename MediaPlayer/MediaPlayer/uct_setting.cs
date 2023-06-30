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
    public partial class uct_setting : UserControl
    {
        public uct_setting()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Guna2ToggleSwitch toggle = sender as Guna2ToggleSwitch;
            mediaPlayer main = this.ParentForm as mediaPlayer;
            if (main != null)
            {
                if (toggle.Checked)
                {
                    main.handleModeAutoPlay(true);
                }
                else
                {
                    main.handleModeAutoPlay(false);
                }
            }
        }
    }
}
