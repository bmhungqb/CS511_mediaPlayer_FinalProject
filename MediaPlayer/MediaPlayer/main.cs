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
using MediaPlayer.API;
namespace MediaPlayer
{
    public partial class main : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        HomePage dataHomePage = new HomePage();
        public main()
        {
            InitializeComponent();
        }
        int width = 1355;
        int height = 200;
        private async void main_Load(object sender, EventArgs e)
        {
            /* Test API
                string res = await zingMp3Api.GetDetailPlaylist("ZOCIIUWW");
                string res = await zingMp3Api.GetLyric("Z6B6ZDIB");
                Lyric ress = Utils.getLyrics(res);
                string ress = Utils.getLyrics(res);
                string response = await zingMp3Api.GetListMV("ZOAC7BUF");
                string res = await zingMp3Api.GetArtist("Thanh-Dat");
                
                string res = await zingMp3Api.GetArtist("Den");
                Artist ar = Utils.getArtist(res);
                string res = await zingMp3Api.GetListArtistSong("IW6BZA76");
                string res = await zingMp3Api.GetVideo("Z6B6ZDIB");
                Video v = Utils.getVideo(res);
                string res = await zingMp3Api.GetInfoSong("ZOAC7BUF");
                string res = await zingMp3Api.Search("Den");
                Search searchData = Utils.handleSearch(res);
            */
            //string res = await zingMp3Api.GetChartHome();
            string response = await zingMp3Api.GetHome();
            dataHomePage = Utils.getHome(response);
            for (int i = 1; i < dataHomePage.banner.listBanners.Count(); i++)
            {
                BannerItem a = dataHomePage.banner.listBanners[i];
                banner ban = new banner(a);
                flow_banner.Controls.Add(ban);
            }
            for (int i = 1; i < dataHomePage.newRelease.listSongs.Count(); i++)
            {
                new_release new_Release = new new_release(dataHomePage.newRelease.listSongs[i]);
                flow_new.Controls.Add(new_Release);
            }
            for (int i = 1; i < dataHomePage.chill.listPlaylists.Count(); i++)
            {
                //usercontrol artist popular use for both chill & popular artists
                Playlist a = dataHomePage.chill.listPlaylists[i];
                artist_popular artist_Popular = new artist_popular(a);
                artist_Popular.OpenPlaylistRequested += Artist_Popular_OpenPlaylistRequested;
                flow_chill.Controls.Add(artist_Popular);
            }
            for (int i = 1; i < dataHomePage.artistPopular.listPlaylists.Count(); i++)
            {
                Playlist a = dataHomePage.artistPopular.listPlaylists[i];
                artist_popular artist_Popular = new artist_popular(a);
                artist_Popular.OpenPlaylistRequested += Artist_Popular_OpenPlaylistRequested;
                flow_artist.Controls.Add(artist_Popular);
            }
        }
        private void Artist_Popular_OpenPlaylistRequested(object sender, EventArgs e)
        {
            artist_popular artist_Popular = sender as artist_popular;
            uct_playlist uct_Playlist = new uct_playlist();
            uct_Playlist.OpenUserControlB(artist_Popular.current);
            panel1.Controls.Add(uct_Playlist);
            uct_Playlist.BringToFront();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Guna2Button guna2Button = sender as Guna2Button;
            //switch(guna2Button.Name)
            //{
            //    case "btn_hieuthuhai":
            //        uct_playlist a = new uct_playlist(btn_hieuthuhai.Text);
            //        panel1.Controls.Add(a);
            //        a.BringToFront();
            //        break;
            //    case "btn_sontungmtp":
            //        uct_playlist b = new uct_playlist(btn_sontungmtp.Text);
            //        panel1.Controls.Add(b);
            //        b.BringToFront();
            //        break;
            //    case "btn_denvau":
            //        uct_playlist c = new uct_playlist(btn_denvau.Text);
            //        panel1.Controls.Add(c);
            //        c.BringToFront();
            //        break;
            //}
        }

        private void button_Click_Picture(object sender, EventArgs e)
        {
            //panel1.AutoScroll = false;
            //PictureBox picture = sender as PictureBox;
            //switch (picture.Name)
            //{
            //    case "pt_hot_hit":
            //        uct_playlist hot_hit = new uct_playlist("Vũ trụ có anh");
            //        panel1.Controls.Add(hot_hit);
            //        hot_hit.BringToFront();
            //        break;
            //    case "pt_den":
            //        uct_playlist den = new uct_playlist(lb_denvau.Text);
            //        panel1.Controls.Add(den);
            //        den.BringToFront();
            //        break;
            //    case "pt_justatee":
            //        uct_playlist jus = new uct_playlist(lb_justatee.Text);
            //        panel1.Controls.Add(jus);
            //        jus.BringToFront();
            //        break;
            //}
        }
        private void button_Click_Picture_Circle(object sender, EventArgs e)
        {
            //panel1.AutoScroll = false;
            //Guna2CirclePictureBox picture = sender as Guna2CirclePictureBox;
            //switch (picture.Name)
            //{
            //    case "pt_phuongly":
            //        uct_playlist phuongly = new uct_playlist(lb_phuongly.Text);
            //        panel1.Controls.Add(phuongly);
            //        phuongly.BringToFront();
            //        break;
            //    case "pt_dalab":
            //        uct_playlist dalab = new uct_playlist(lb_dalab.Text);
            //        panel1.Controls.Add(dalab);
            //        dalab.BringToFront();
            //        break;
            //}
        }
    }
}
