﻿using MediaPlayer.API;
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
    public partial class banner : UserControl
    {
        MediaPlayer.API.Utils Utils = new Utils();
        BannerItem bannerItem = new BannerItem();
        public banner(BannerItem banner) 
        {
            InitializeComponent();
            bannerItem = banner;
        }
        private void banner_Load(object sender, EventArgs e)
        {
           guna2PictureBox1.Image = Utils.getImage(bannerItem.banner);
        }
    }
}
