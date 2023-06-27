﻿using AxWMPLib;
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
using WMPLib;

namespace MediaPlayer
{
    public partial class uct_video : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        public Song currentSong = new Song();
        public uct_video(Song song)
        {
            InitializeComponent();
            currentSong = song;
            playVideo(currentSong);
        }
        public async void playVideo(Song song)
        {
            name.Text = song.title;
            string res = await zingMp3Api.GetVideo(song.songId);
            Video video = Utils.getVideo(res);
            player.URL = video.linkFileTempVideo;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
