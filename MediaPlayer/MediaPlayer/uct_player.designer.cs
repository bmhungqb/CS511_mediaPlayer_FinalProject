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
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox6 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox5 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_tym = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_Play = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pt_thumb = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_song
            // 
            this.lbl_song.BackColor = System.Drawing.Color.Transparent;
            this.lbl_song.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_song.Location = new System.Drawing.Point(114, 32);
            this.lbl_song.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_song.Name = "lbl_song";
            this.lbl_song.Size = new System.Drawing.Size(66, 21);
            this.lbl_song.TabIndex = 1;
            this.lbl_song.Text = "Cuối tuần";
            // 
            // lbl_singer
            // 
            this.lbl_singer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_singer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblPlayCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayCurrentTime.Location = new System.Drawing.Point(438, 68);
            this.lblPlayCurrentTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayCurrentTime.Name = "lblPlayCurrentTime";
            this.lblPlayCurrentTime.Size = new System.Drawing.Size(30, 17);
            this.lblPlayCurrentTime.TabIndex = 7;
            this.lblPlayCurrentTime.Text = "00:00";
            // 
            // lblPlayDuration
            // 
            this.lblPlayDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayDuration.Location = new System.Drawing.Point(999, 67);
            this.lblPlayDuration.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayDuration.Name = "lblPlayDuration";
            this.lblPlayDuration.Size = new System.Drawing.Size(24, 17);
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
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
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
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(1128, 32);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(24, 24);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 17;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(1176, 32);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(24, 24);
            this.guna2PictureBox3.TabIndex = 16;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2CirclePictureBox6
            // 
            this.guna2CirclePictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox6.Image")));
            this.guna2CirclePictureBox6.ImageRotate = 0F;
            this.guna2CirclePictureBox6.Location = new System.Drawing.Point(1218, 28);
            this.guna2CirclePictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox6.Name = "guna2CirclePictureBox6";
            this.guna2CirclePictureBox6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox6.Size = new System.Drawing.Size(32, 32);
            this.guna2CirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox6.TabIndex = 15;
            this.guna2CirclePictureBox6.TabStop = false;
            // 
            // guna2CirclePictureBox5
            // 
            this.guna2CirclePictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox5.Image")));
            this.guna2CirclePictureBox5.ImageRotate = 0F;
            this.guna2CirclePictureBox5.Location = new System.Drawing.Point(818, 20);
            this.guna2CirclePictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox5.Name = "guna2CirclePictureBox5";
            this.guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox5.Size = new System.Drawing.Size(32, 32);
            this.guna2CirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox5.TabIndex = 13;
            this.guna2CirclePictureBox5.TabStop = false;
            // 
            // btn_tym
            // 
            this.btn_tym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tym.Image = ((System.Drawing.Image)(resources.GetObject("btn_tym.Image")));
            this.btn_tym.ImageRotate = 0F;
            this.btn_tym.Location = new System.Drawing.Point(595, 19);
            this.btn_tym.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tym.Name = "btn_tym";
            this.btn_tym.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_tym.Size = new System.Drawing.Size(32, 32);
            this.btn_tym.TabIndex = 12;
            this.btn_tym.TabStop = false;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(650, 19);
            this.guna2CirclePictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(32, 32);
            this.guna2CirclePictureBox3.TabIndex = 11;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(766, 19);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(32, 32);
            this.guna2CirclePictureBox2.TabIndex = 10;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // btn_Play
            // 
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.Image = global::MediaPlayer.Properties.Resources._3669309_pause_circle_filled_ic_icon;
            this.btn_Play.ImageRotate = 0F;
            this.btn_Play.Location = new System.Drawing.Point(704, 10);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Play.Size = new System.Drawing.Size(48, 48);
            this.btn_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Play.TabIndex = 9;
            this.btn_Play.TabStop = false;
            this.btn_Play.Click += new System.EventHandler(this.toggleMusic);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2CirclePictureBox6);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.guna2CirclePictureBox5);
            this.Controls.Add(this.btn_tym);
            this.Controls.Add(this.guna2CirclePictureBox3);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lblPlayDuration);
            this.Controls.Add(this.lblPlayCurrentTime);
            this.Controls.Add(this.sliderMusic);
            this.Controls.Add(this.lbl_singer);
            this.Controls.Add(this.lbl_song);
            this.Controls.Add(this.pt_thumb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uct_player";
            this.Size = new System.Drawing.Size(1460, 110);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).EndInit();
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_Play;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_tym;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox5;
        private Guna.UI2.WinForms.Guna2TrackBar sliderVolume;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Timer trackTime;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
