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
        int start = 0;
        int end = 0;
        public lyrics_line(string x, int startTime, int endTime)
        {
            InitializeComponent();
            lbl_lyrics.Text = x;
            start = startTime;
            end = endTime;
            BackColor = Color.Transparent;
        }
        public void activeLine()
        {
            lbl_lyrics.ForeColor = Color.Yellow;
        }
        public void unactiveLine()
        {
            lbl_lyrics.ForeColor = Color.Gray;
        }
        public bool isActive(int time)
        {
            if(time > start && time < end)
            {
                return true;
            }
            return false;
        }
    }
}
