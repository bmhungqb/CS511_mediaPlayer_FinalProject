namespace MediaPlayer
{
    partial class uct_player
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_player));
            this.lbl_song = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_singer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sliderMusic = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblPlayCurrentTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPlayDuration = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sliderVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackTime = new System.Windows.Forms.Timer(this.components);
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_next = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Play = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pt_thumb = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt_thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_song
            // 
            this.lbl_song.BackColor = System.Drawing.Color.Transparent;
            this.lbl_song.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_song.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_song.Location = new System.Drawing.Point(114, 32);
            this.lbl_song.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_song.Name = "lbl_song";
            this.lbl_song.Size = new System.Drawing.Size(66, 21);
            this.lbl_song.TabIndex = 1;
            this.lbl_song.Text = "Cuối tuần";
            // 
            // lbl_singer
            // 
            this.lbl_singer.AutoSize = false;
            this.lbl_singer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_singer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_singer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_singer.Location = new System.Drawing.Point(114, 62);
            this.lbl_singer.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_singer.Name = "lbl_singer";
            this.lbl_singer.Size = new System.Drawing.Size(121, 17);
            this.lbl_singer.TabIndex = 2;
            this.lbl_singer.Text = "Nguyên Hà, Minh Min";
            // 
            // sliderMusic
            // 
            this.sliderMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderMusic.Location = new System.Drawing.Point(473, 67);
            this.sliderMusic.Margin = new System.Windows.Forms.Padding(2);
            this.sliderMusic.Name = "sliderMusic";
            this.sliderMusic.Size = new System.Drawing.Size(519, 20);
            this.sliderMusic.TabIndex = 4;
            this.sliderMusic.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sliderMusic.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderMusic_Scroll);
            // 
            // lblPlayCurrentTime
            // 
            this.lblPlayCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayCurrentTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayCurrentTime.Location = new System.Drawing.Point(434, 68);
            this.lblPlayCurrentTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayCurrentTime.Name = "lblPlayCurrentTime";
            this.lblPlayCurrentTime.Size = new System.Drawing.Size(34, 17);
            this.lblPlayCurrentTime.TabIndex = 7;
            this.lblPlayCurrentTime.Text = "00:00";
            // 
            // lblPlayDuration
            // 
            this.lblPlayDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayDuration.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayDuration.Location = new System.Drawing.Point(999, 67);
            this.lblPlayDuration.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayDuration.Name = "lblPlayDuration";
            this.lblPlayDuration.Size = new System.Drawing.Size(27, 17);
            this.lblPlayDuration.TabIndex = 8;
            this.lblPlayDuration.Text = "1:10";
            // 
            // sliderVolume
            // 
            this.sliderVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderVolume.Location = new System.Drawing.Point(1264, 35);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(2);
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(168, 20);
            this.sliderVolume.TabIndex = 14;
            this.sliderVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sliderVolume.ValueChanged += new System.EventHandler(this.slider_volume);
            // 
            // trackTime
            // 
            this.trackTime.Enabled = true;
            this.trackTime.Interval = 1000;
            this.trackTime.Tick += new System.EventHandler(this.trackTime_Tick);
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton8.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_speaker32;
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton8.Image = global::MediaPlayer.Properties.Resources._7252723_volume_low_speaker_sound_music_icon1;
            this.guna2ImageButton8.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton8.ImageRotate = 0F;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton8.Location = new System.Drawing.Point(1219, 28);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_speaker321;
            this.guna2ImageButton8.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton8.Size = new System.Drawing.Size(32, 32);
            this.guna2ImageButton8.TabIndex = 26;
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton7.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_list24;
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton7.Image = global::MediaPlayer.Properties.Resources._6792164_list_multimedia_music_play_playlist_icon__1_1;
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton7.Location = new System.Drawing.Point(1176, 32);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_list241;
            this.guna2ImageButton7.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton7.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton7.TabIndex = 25;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton6.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_mic24;
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton6.Image = global::MediaPlayer.Properties.Resources._6518717_audio_communication_microphone_music_sound_icon__1_1;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton6.Location = new System.Drawing.Point(1128, 32);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_mic241;
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton6.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton6.TabIndex = 24;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton5.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_repeat32;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton5.Image = global::MediaPlayer.Properties.Resources._4634534_arrow_looping_music_repeat_icon1;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton5.Location = new System.Drawing.Point(818, 20);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_repeat321;
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton5.Size = new System.Drawing.Size(32, 32);
            this.guna2ImageButton5.TabIndex = 23;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton4.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_random32;
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton4.Image = global::MediaPlayer.Properties.Resources._9104257_shuffle_random_mix_icon1;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton4.Location = new System.Drawing.Point(595, 19);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_random321;
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton4.Size = new System.Drawing.Size(32, 32);
            this.guna2ImageButton4.TabIndex = 22;
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_back_32;
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_back.Image = global::MediaPlayer.Properties.Resources._352133_previous_skip_icon1;
            this.btn_back.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_back.ImageRotate = 0F;
            this.btn_back.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_back.Location = new System.Drawing.Point(650, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_back_321;
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_back.Size = new System.Drawing.Size(32, 32);
            this.btn_back.TabIndex = 21;
            this.btn_back.Click += new System.EventHandler(this.btn_next_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_next_32;
            this.btn_next.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_next.Image = global::MediaPlayer.Properties.Resources._352132_next_skip_icon__1_1;
            this.btn_next.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_next.ImageRotate = 0F;
            this.btn_next.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_next.Location = new System.Drawing.Point(766, 19);
            this.btn_next.Name = "btn_next";
            this.btn_next.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_next_32;
            this.btn_next.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_next.Size = new System.Drawing.Size(32, 32);
            this.btn_next.TabIndex = 20;
            this.btn_next.Click += new System.EventHandler(this.btn_next_back_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.CheckedState.Image = global::MediaPlayer.Properties.Resources.new_ic_play;
            this.btn_Play.CheckedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_Play.Image = global::MediaPlayer.Properties.Resources.new_ic_pause;
            this.btn_Play.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Play.ImageRotate = 0F;
            this.btn_Play.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_Play.Location = new System.Drawing.Point(704, 10);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_Play.Size = new System.Drawing.Size(48, 48);
            this.btn_Play.TabIndex = 19;
            this.btn_Play.Click += new System.EventHandler(this.toggleMusic);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Image = global::MediaPlayer.Properties.Resources._9025718_heart_straight_icon__1_;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(262, 51);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::MediaPlayer.Properties.Resources.tym_active;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.TabIndex = 18;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // pt_thumb
            // 
            this.pt_thumb.BorderRadius = 10;
            this.pt_thumb.Image = global::MediaPlayer.Properties.Resources._351752985_936385717576463_3672978110271268401_n;
            this.pt_thumb.ImageRotate = 0F;
            this.pt_thumb.Location = new System.Drawing.Point(13, 16);
            this.pt_thumb.Margin = new System.Windows.Forms.Padding(2);
            this.pt_thumb.Name = "pt_thumb";
            this.pt_thumb.Size = new System.Drawing.Size(80, 80);
            this.pt_thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_thumb.TabIndex = 0;
            this.pt_thumb.TabStop = false;
            // 
            // uct_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2ImageButton8);
            this.Controls.Add(this.guna2ImageButton7);
            this.Controls.Add(this.guna2ImageButton6);
            this.Controls.Add(this.guna2ImageButton5);
            this.Controls.Add(this.guna2ImageButton4);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.lblPlayDuration);
            this.Controls.Add(this.lblPlayCurrentTime);
            this.Controls.Add(this.sliderMusic);
            this.Controls.Add(this.lbl_singer);
            this.Controls.Add(this.lbl_song);
            this.Controls.Add(this.pt_thumb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uct_player";
            this.Size = new System.Drawing.Size(1460, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pt_thumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pt_thumb;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_song;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_singer;
        private Guna.UI2.WinForms.Guna2TrackBar sliderMusic;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlayCurrentTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlayDuration;
        private Guna.UI2.WinForms.Guna2TrackBar sliderVolume;
        private System.Windows.Forms.Timer trackTime;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Play;
        private Guna.UI2.WinForms.Guna2ImageButton btn_next;
        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
    }
}
