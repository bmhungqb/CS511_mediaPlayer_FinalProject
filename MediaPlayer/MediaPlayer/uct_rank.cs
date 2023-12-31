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
using System.Windows.Forms.DataVisualization.Charting;

namespace MediaPlayer
{
    public partial class uct_rank : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        ChartHome currentChart = new ChartHome();
        public uct_rank(ChartHome data = null)
        {
            InitializeComponent();
            currentChart = data;
        }

        private async void uct_rank_Load(object sender, EventArgs e)
        {
            string res = await zingMp3Api.GetChartHome();
            currentChart = Utils.getHomeChart(res);
            loadChart(currentChart);
            loadSongs(currentChart);
            mediaPlayer main = this.ParentForm as mediaPlayer;
            main.setCurrentListSong(currentChart.listSongs);
        }
        private void loadChart(ChartHome chartdata)
        {
            Series top1 = new Series();
            Series top2 = new Series();
            Series top3 = new Series();
            top1.BorderWidth = 2;
            top2.BorderWidth = 2;
            top3.BorderWidth = 2;
            top1.MarkerStyle = MarkerStyle.Circle;
            top2.MarkerStyle = MarkerStyle.Circle;
            top3.MarkerStyle = MarkerStyle.Circle;
            top1.ChartType = SeriesChartType.Spline;
            top2.ChartType = SeriesChartType.Spline;
            top3.ChartType = SeriesChartType.Spline;

            foreach (dataChart data in chartdata.chart.top1)
            {
                top1.Points.AddXY($"{data.time}:00", data.counter);
            }
            chart.Series.Add(top1);

            foreach (dataChart data in chartdata.chart.top2)
            {
                top2.Points.AddXY($"{data.time}:00", data.counter);
            }
            chart.Series.Add(top2);

            foreach (dataChart data in chartdata.chart.top3)
            {
                top3.Points.AddXY($"{data.time}:00", data.counter);
            }
            chart.Series.Add(top3);
            chart.Show();
        }
        private void loadSongs(ChartHome chartdata)
        {
            int i = 1;
            foreach (Song song in chartdata.listSongs)
            {
                //if (i > 30) return;
                pnl_flow_rank.Controls.Add(new uct_song(i.ToString(), song));
                i++;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            //this.Hide();
        }
    }
}
