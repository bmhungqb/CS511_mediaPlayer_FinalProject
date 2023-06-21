using AxWMPLib;
using Guna.UI2.WinForms;
using MediaPlayer.API;
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
    public partial class uct_lyrics : UserControl
    {
        string x, y;
        MediaPlayer.API.APIMusic apiMusic = new APIMusic();
        public uct_lyrics(string name)
        {
            InitializeComponent();
            x = name;
            //y = urlLyrics;
        }
        public void OpenUCTLyrics()
        {
            Lyrics lyrics = apiMusic.getLyrics("https://static-zmp3.zmdcdn.me/lyrics/2/b/8/f/2b8f4c339157d10a8c1ab80fa8d25424.lrc");
            name.Text = x;
            List<string> lyricsList = lyrics.lyric;
            // Thực hiện các hành động cần thiết khi mở UserControlB
            foreach (string line in lyricsList)
            {
                lyrics_line line1 = new lyrics_line(line);
                panel1.Controls.Add(line1);
            }
        }
        public void OpenUCTKara()
        {
            btn_record.Visible = true;
            Lyrics lyrics = apiMusic.getLyrics("https://static-zmp3.zmdcdn.me/lyrics/2/b/8/f/2b8f4c339157d10a8c1ab80fa8d25424.lrc");
            name.Text = x;
            List<string> lyricsList = lyrics.lyric;
            // Thực hiện các hành động cần thiết khi mở UserControlB
            foreach (string line in lyricsList)
            {
                lyrics_line line1 = new lyrics_line(line);
                panel1.Controls.Add(line1);
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            this.Hide();
        }
    }
}
