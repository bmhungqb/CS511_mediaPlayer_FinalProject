﻿using AxWMPLib;
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
using System.Runtime.InteropServices;
using System.Media;
namespace MediaPlayer
{
    public partial class uct_lyrics : UserControl
    {
        MediaPlayer.API.ZingMp3Api zingMp3Api = new ZingMp3Api();
        MediaPlayer.API.Utils Utils = new Utils();
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        SaveFileDialog saveFileRecord = new SaveFileDialog();
        int currentTimerRecord = 0;
        public uct_lyrics()
        {
            InitializeComponent();
        }
        public async void OpenUCTLyrics(Song song)
        {
            string resLyric = await zingMp3Api.GetLyric(song.songId);
            song.lyric = Utils.getLyrics(resLyric);
            name.Text = song.title;
            foreach (Sentence sentence in song.lyric.sentences)
            {
                string line = "";
                foreach (Word word in sentence.sentence)
                {
                    line = line + " " + word.data;
                }
                lyrics_line line1 = new lyrics_line(line);
                panel1.Controls.Add(line1);
            }
        }
        public async void OpenUCTKara(Song song)
        {
            btn_record.Visible = true;
            string resLyric = await zingMp3Api.GetLyric(song.songId);
            song.lyric = Utils.getLyrics(resLyric);
            name.Text = song.title;
            foreach (Sentence sentence in song.lyric.sentences)
            {
                string line = "";
                foreach (Word word in sentence.sentence)
                {
                    line = line + " " + word.data;
                }
                lyrics_line line1 = new lyrics_line(line);
                panel1.Controls.Add(line1);
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)//back
        {
            this.Hide();
        }
        private void handleStartRecord()
        {
            lb_record_timer.Visible = true;
            lb_record_timer.Text = "0:00:00";
            currentTimerRecord = 0;
            timer.Enabled = true;
            timer.Start();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
        }
        private void handleStopRecord()
        {
            timer.Stop();
            timer.Enabled = false;
            lb_record_timer.Visible = false;
            saveFileRecord.Filter = "Thu âm (.wav)|*.wav";
            saveFileRecord.ShowDialog();
            record("save recsound " + saveFileRecord.FileName, "", 0, 0);
            record("close recsound", "", 0, 0);
        }
        private void btn_record_Click(object sender, EventArgs e)
        {
            Guna2ImageButton btn = sender as Guna2ImageButton;
            if(btn.Checked == false)
            {
                handleStartRecord();
            }
            else
            {
                handleStopRecord();
            }
            btn.Checked = !btn.Checked;
        }

        private string getCurrentTimeToString(int time)
        {
            int seconds = time;

            int hours = seconds / 3600;
            int remainingSeconds = seconds % 3600;
            int minutes = remainingSeconds / 60;
            int remainingSecondsFinal = remainingSeconds % 60;

            string formattedTime = $"{hours:00}:{minutes:00}:{remainingSecondsFinal:00}";
            return formattedTime;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimerRecord++;
            lb_record_timer.Text = getCurrentTimeToString(currentTimerRecord);
        }
    }
}
