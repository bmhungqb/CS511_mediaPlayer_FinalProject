namespace MediaPlayer
{
    partial class uct_song2
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lb_singer = new System.Windows.Forms.Label();
            this.lb_song = new System.Windows.Forms.Label();
            this.btn_del = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pt_thumb = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lb_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 79);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(756, 10);
            this.guna2Separator1.TabIndex = 104;
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_singer.Location = new System.Drawing.Point(111, 46);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(51, 20);
            this.lb_singer.TabIndex = 100;
            this.lb_singer.Text = "Singer";
            // 
            // lb_song
            // 
            this.lb_song.AutoSize = true;
            this.lb_song.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_song.ForeColor = System.Drawing.Color.White;
            this.lb_song.Location = new System.Drawing.Point(110, 10);
            this.lb_song.Name = "lb_song";
            this.lb_song.Size = new System.Drawing.Size(119, 25);
            this.lb_song.TabIndex = 99;
            this.lb_song.Text = "Song\'s name";
            // 
            // btn_del
            // 
            this.btn_del.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_del.Image = global::MediaPlayer.Properties.Resources.del;
            this.btn_del.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_del.ImageRotate = 0F;
            this.btn_del.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_del.Location = new System.Drawing.Point(706, 27);
            this.btn_del.Name = "btn_del";
            this.btn_del.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_del.Size = new System.Drawing.Size(32, 32);
            this.btn_del.TabIndex = 102;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
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
            this.pt_thumb.Location = new System.Drawing.Point(3, 3);
            this.pt_thumb.Name = "pt_thumb";
            this.pt_thumb.PressedState.ImageSize = new System.Drawing.Size(100, 100);
            this.pt_thumb.Size = new System.Drawing.Size(100, 73);
            this.pt_thumb.TabIndex = 101;
            this.pt_thumb.Click += new System.EventHandler(this.pt_thumb_Click);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_time.Location = new System.Drawing.Point(561, 34);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(53, 25);
            this.lb_time.TabIndex = 105;
            this.lb_time.Text = "Time";
            // 
            // uct_song2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_song);
            this.Controls.Add(this.pt_thumb);
            this.Name = "uct_song2";
            this.Size = new System.Drawing.Size(750, 89);
            this.Load += new System.EventHandler(this.uct_song2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_del;
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.Label lb_song;
        private Guna.UI2.WinForms.Guna2ImageButton pt_thumb;
        private System.Windows.Forms.Label lb_time;
    }
}
