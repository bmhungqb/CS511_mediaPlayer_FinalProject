namespace MediaPlayer
{
    partial class uct_song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_song));
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_song = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_singer = new System.Windows.Forms.Label();
            this.lb_album = new System.Windows.Forms.Label();
            this.pt_tym = new System.Windows.Forms.PictureBox();
            this.pt_thumb = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt_tym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_thumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.White;
            this.lb_id.Location = new System.Drawing.Point(5, 34);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(28, 31);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "1";
            // 
            // lb_song
            // 
            this.lb_song.AutoSize = true;
            this.lb_song.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_song.ForeColor = System.Drawing.Color.White;
            this.lb_song.Location = new System.Drawing.Point(179, 21);
            this.lb_song.Name = "lb_song";
            this.lb_song.Size = new System.Drawing.Size(100, 21);
            this.lb_song.TabIndex = 2;
            this.lb_song.Text = "Song\'s name";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_time.Location = new System.Drawing.Point(1169, 37);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(44, 21);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "Time";
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_singer.Location = new System.Drawing.Point(179, 55);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(45, 17);
            this.lb_singer.TabIndex = 5;
            this.lb_singer.Text = "Singer";
            // 
            // lb_album
            // 
            this.lb_album.AutoSize = true;
            this.lb_album.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_album.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_album.Location = new System.Drawing.Point(570, 38);
            this.lb_album.Name = "lb_album";
            this.lb_album.Size = new System.Drawing.Size(99, 21);
            this.lb_album.TabIndex = 7;
            this.lb_album.Text = "Album name";
            // 
            // pt_tym
            // 
            this.pt_tym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_tym.Image = global::MediaPlayer.Properties.Resources.tymm;
            this.pt_tym.Location = new System.Drawing.Point(1104, 34);
            this.pt_tym.Name = "pt_tym";
            this.pt_tym.Size = new System.Drawing.Size(32, 32);
            this.pt_tym.TabIndex = 8;
            this.pt_tym.TabStop = false;
            // 
            // pt_thumb
            // 
            this.pt_thumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_thumb.Image = global::MediaPlayer.Properties.Resources.ezpapa;
            this.pt_thumb.Location = new System.Drawing.Point(61, 12);
            this.pt_thumb.Name = "pt_thumb";
            this.pt_thumb.Size = new System.Drawing.Size(100, 73);
            this.pt_thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_thumb.TabIndex = 1;
            this.pt_thumb.TabStop = false;
            this.pt_thumb.Click += new System.EventHandler(this.pt_thumb_Click);
            this.pt_thumb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pt_thumb_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave_1);
            // 
            // uct_song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pt_tym);
            this.Controls.Add(this.lb_album);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_song);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.pt_thumb);
            this.Controls.Add(this.pictureBox2);
            this.Name = "uct_song";
            this.Size = new System.Drawing.Size(1329, 100);
            this.Load += new System.EventHandler(this.uct_song_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt_tym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_thumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.PictureBox pt_thumb;
        private System.Windows.Forms.Label lb_song;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_album;
        private System.Windows.Forms.PictureBox pt_tym;
    }
}
