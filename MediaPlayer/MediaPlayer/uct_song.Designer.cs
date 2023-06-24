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
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_song = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_singer = new System.Windows.Forms.Label();
            this.lb_album = new System.Windows.Forms.Label();
            this.btn_tym = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pt_thumb = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.White;
            this.lb_id.Location = new System.Drawing.Point(14, 26);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(32, 37);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "1";
            // 
            // lb_song
            // 
            this.lb_song.AutoSize = true;
            this.lb_song.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_song.ForeColor = System.Drawing.Color.White;
            this.lb_song.Location = new System.Drawing.Point(179, 21);
            this.lb_song.Name = "lb_song";
            this.lb_song.Size = new System.Drawing.Size(119, 25);
            this.lb_song.TabIndex = 2;
            this.lb_song.Text = "Song\'s name";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_time.Location = new System.Drawing.Point(1169, 37);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(53, 25);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "Time";
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_singer.Location = new System.Drawing.Point(179, 55);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(51, 20);
            this.lb_singer.TabIndex = 5;
            this.lb_singer.Text = "Singer";
            // 
            // lb_album
            // 
            this.lb_album.AutoSize = true;
            this.lb_album.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_album.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_album.Location = new System.Drawing.Point(677, 41);
            this.lb_album.Name = "lb_album";
            this.lb_album.Size = new System.Drawing.Size(119, 25);
            this.lb_album.TabIndex = 7;
            this.lb_album.Text = "Album name";
            // 
            // btn_tym
            // 
            this.btn_tym.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_tym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tym.HoverState.Image = global::MediaPlayer.Properties.Resources.tym_active32;
            this.btn_tym.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_tym.Image = global::MediaPlayer.Properties.Resources.tym32;
            this.btn_tym.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_tym.ImageRotate = 0F;
            this.btn_tym.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_tym.Location = new System.Drawing.Point(1104, 34);
            this.btn_tym.Name = "btn_tym";
            this.btn_tym.PressedState.Image = global::MediaPlayer.Properties.Resources.tym_active32;
            this.btn_tym.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_tym.Size = new System.Drawing.Size(32, 32);
            this.btn_tym.TabIndex = 9;
            this.btn_tym.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // pt_thumb
            // 
            this.pt_thumb.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pt_thumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_thumb.HoverState.Image = global::MediaPlayer.Properties.Resources.play;
            this.pt_thumb.HoverState.ImageSize = new System.Drawing.Size(100, 100);
            this.pt_thumb.Image = global::MediaPlayer.Properties.Resources.ezpapa;
            this.pt_thumb.ImageOffset = new System.Drawing.Point(0, 0);
            this.pt_thumb.ImageRotate = 0F;
            this.pt_thumb.ImageSize = new System.Drawing.Size(100, 100);
            this.pt_thumb.Location = new System.Drawing.Point(61, 12);
            this.pt_thumb.Name = "pt_thumb";
            this.pt_thumb.PressedState.ImageSize = new System.Drawing.Size(100, 100);
            this.pt_thumb.Size = new System.Drawing.Size(100, 73);
            this.pt_thumb.TabIndex = 10;
            this.pt_thumb.Click += new System.EventHandler(this.pt_thumb_Click);
            // 
            // uct_song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pt_thumb);
            this.Controls.Add(this.btn_tym);
            this.Controls.Add(this.lb_album);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_song);
            this.Controls.Add(this.lb_id);
            this.Name = "uct_song";
            this.Size = new System.Drawing.Size(1304, 100);
            this.Load += new System.EventHandler(this.uct_song_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_song;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.Label lb_album;
        private Guna.UI2.WinForms.Guna2ImageButton btn_tym;
        private Guna.UI2.WinForms.Guna2ImageButton pt_thumb;
    }
}
