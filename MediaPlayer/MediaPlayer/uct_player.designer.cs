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
            this.btn_video = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_speaker = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_lyric = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_kara = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_repeat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_random = new Guna.UI2.WinForms.Guna2ImageButton();
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
            this.sliderMusic.DisplayFocus = true;
            this.sliderMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sliderMusic.HoverState.FillColor = System.Drawing.Color.MediumOrchid;
            this.sliderMusic.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sliderMusic.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.sliderMusic.IndicateFocus = true;
            this.sliderMusic.Location = new System.Drawing.Point(462, 67);
            this.sliderMusic.Margin = new System.Windows.Forms.Padding(2);
            this.sliderMusic.MouseWheelBarPartitions = 1;
            this.sliderMusic.Name = "sliderMusic";
            this.sliderMusic.Size = new System.Drawing.Size(519, 20);
            this.sliderMusic.TabIndex = 4;
            this.sliderMusic.ThumbColor = System.Drawing.Color.Magenta;
            this.sliderMusic.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderMusic_Scroll);
            // 
            // lblPlayCurrentTime
            // 
            this.lblPlayCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayCurrentTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayCurrentTime.Location = new System.Drawing.Point(423, 68);
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
            this.lblPlayDuration.Location = new System.Drawing.Point(988, 67);
            this.lblPlayDuration.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayDuration.Name = "lblPlayDuration";
            this.lblPlayDuration.Size = new System.Drawing.Size(27, 17);
            this.lblPlayDuration.TabIndex = 8;
            this.lblPlayDuration.Text = "1:10";
            // 
            // sliderVolume
            // 
            this.sliderVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderVolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sliderVolume.Location = new System.Drawing.Point(1264, 35);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(2);
            this.sliderVolume.MouseWheelBarPartitions = 5;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(168, 20);
            this.sliderVolume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.sliderVolume.TabIndex = 14;
            this.sliderVolume.ThumbColor = System.Drawing.Color.Fuchsia;
            this.sliderVolume.Value = 40;
            this.sliderVolume.ValueChanged += new System.EventHandler(this.slider_volume);
            // 
            // trackTime
            // 
            this.trackTime.Enabled = true;
            this.trackTime.Interval = 1000;
            this.trackTime.Tick += new System.EventHandler(this.trackTime_Tick);
            // 
            // btn_video
            // 
            this.btn_video.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_video.HoverState.Image = global::MediaPlayer.Properties.Resources.video32active1;
            this.btn_video.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_video.Image = global::MediaPlayer.Properties.Resources.video321;
            this.btn_video.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_video.ImageRotate = 0F;
            this.btn_video.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_video.Location = new System.Drawing.Point(1076, 28);
            this.btn_video.Name = "btn_video";
            this.btn_video.PressedState.Image = global::MediaPlayer.Properties.Resources.video32active2;
            this.btn_video.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_video.Size = new System.Drawing.Size(32, 32);
            this.btn_video.TabIndex = 27;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_speaker
            // 
            this.btn_speaker.CheckedState.Image = global::MediaPlayer.Properties.Resources.ic_speaker_mute_active32;
            this.btn_speaker.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_speaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_speaker.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_speaker322;
            this.btn_speaker.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_speaker.Image = global::MediaPlayer.Properties.Resources.ic_speaker32;
            this.btn_speaker.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_speaker.ImageRotate = 0F;
            this.btn_speaker.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_speaker.Location = new System.Drawing.Point(1219, 28);
            this.btn_speaker.Name = "btn_speaker";
            this.btn_speaker.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_speaker321;
            this.btn_speaker.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_speaker.Size = new System.Drawing.Size(32, 32);
            this.btn_speaker.TabIndex = 26;
            this.btn_speaker.Click += new System.EventHandler(this.btn_speaker_Click);
            // 
            // btn_lyric
            // 
            this.btn_lyric.CheckedState.Image = global::MediaPlayer.Properties.Resources.new_ic_list242;
            this.btn_lyric.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_lyric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lyric.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_list24;
            this.btn_lyric.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_lyric.Image = global::MediaPlayer.Properties.Resources._6792164_list_multimedia_music_play_playlist_icon__1_1;
            this.btn_lyric.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_lyric.ImageRotate = 0F;
            this.btn_lyric.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_lyric.Location = new System.Drawing.Point(1176, 32);
            this.btn_lyric.Name = "btn_lyric";
            this.btn_lyric.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_list241;
            this.btn_lyric.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_lyric.Size = new System.Drawing.Size(24, 24);
            this.btn_lyric.TabIndex = 25;
            this.btn_lyric.Click += new System.EventHandler(this.btn_lyric_Click);
            // 
            // btn_kara
            // 
            this.btn_kara.CheckedState.Image = global::MediaPlayer.Properties.Resources.new_ic_mic242;
            this.btn_kara.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_kara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kara.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_mic24;
            this.btn_kara.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_kara.Image = global::MediaPlayer.Properties.Resources._6518717_audio_communication_microphone_music_sound_icon__1_1;
            this.btn_kara.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_kara.ImageRotate = 0F;
            this.btn_kara.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_kara.Location = new System.Drawing.Point(1128, 32);
            this.btn_kara.Name = "btn_kara";
            this.btn_kara.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_mic241;
            this.btn_kara.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_kara.Size = new System.Drawing.Size(24, 24);
            this.btn_kara.TabIndex = 24;
            this.btn_kara.Click += new System.EventHandler(this.btn_kara_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repeat.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_repeat32;
            this.btn_repeat.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_repeat.Image = global::MediaPlayer.Properties.Resources._4634534_arrow_looping_music_repeat_icon1;
            this.btn_repeat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_repeat.ImageRotate = 0F;
            this.btn_repeat.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_repeat.Location = new System.Drawing.Point(818, 20);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_repeat321;
            this.btn_repeat.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_repeat.Size = new System.Drawing.Size(32, 32);
            this.btn_repeat.TabIndex = 23;
            this.btn_repeat.Click += new System.EventHandler(this.btn_mode_click);
            // 
            // btn_random
            // 
            this.btn_random.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_random.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_random.HoverState.Image = global::MediaPlayer.Properties.Resources.new_ic_random32;
            this.btn_random.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_random.Image = global::MediaPlayer.Properties.Resources._9104257_shuffle_random_mix_icon1;
            this.btn_random.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_random.ImageRotate = 0F;
            this.btn_random.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_random.Location = new System.Drawing.Point(595, 19);
            this.btn_random.Name = "btn_random";
            this.btn_random.PressedState.Image = global::MediaPlayer.Properties.Resources.new_ic_random321;
            this.btn_random.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_random.Size = new System.Drawing.Size(32, 32);
            this.btn_random.TabIndex = 22;
            this.btn_random.Click += new System.EventHandler(this.btn_mode_click);
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
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_speaker);
            this.Controls.Add(this.btn_lyric);
            this.Controls.Add(this.btn_kara);
            this.Controls.Add(this.btn_repeat);
            this.Controls.Add(this.btn_random);
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
            this.Load += new System.EventHandler(this.uct_player_Load);
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
        private Guna.UI2.WinForms.Guna2ImageButton btn_random;
        private Guna.UI2.WinForms.Guna2ImageButton btn_repeat;
        private Guna.UI2.WinForms.Guna2ImageButton btn_kara;
        private Guna.UI2.WinForms.Guna2ImageButton btn_lyric;
        private Guna.UI2.WinForms.Guna2ImageButton btn_speaker;
        private Guna.UI2.WinForms.Guna2ImageButton btn_video;
    }
}
