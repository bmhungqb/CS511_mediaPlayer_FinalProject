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
    public partial class lyrics_line : UserControl
    {
        public lyrics_line(string x, int startTime, int endTime)
        {
            InitializeComponent();
            lbl_lyrics.Text = x;
            BackColor = Color.Transparent;
        }
    }
}
