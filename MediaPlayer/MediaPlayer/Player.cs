using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Windows;
using WMPLib;
namespace MediaPlayer
{
    public partial class Player : UserControl
    {
        public Player()
        {
            InitializeComponent();
            player.URL = musicPath;
            player.controls.stop();
        }
        #region define player
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string musicPath = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/CS511_MediaPlayer_FinalProject/resources/y2mate.com - chờ mãi cũng đến  Cuối Tuần  Nguyên Hà  Minh Min   Official MV_320kbps.mp3";
        #endregion
        private void toggleMusic(object sender, EventArgs e)
        {
            if(player.playState ==  WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.controls.stop();
            }
            else
            {
                player.controls.play();
            }
        }
    }
}
