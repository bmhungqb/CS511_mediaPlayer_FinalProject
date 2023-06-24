namespace MediaPlayer
{
    partial class new_release
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
            this.lb_singer = new System.Windows.Forms.Label();
            this.lb_song = new System.Windows.Forms.Label();
            this.pt_thumb = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.Gray;
            this.lb_singer.Location = new System.Drawing.Point(125, 49);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(51, 20);
            this.lb_singer.TabIndex = 12;
            this.lb_singer.Text = "Singer";
            // 
            // lb_song
            // 
            this.lb_song.AutoSize = true;
            this.lb_song.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_song.ForeColor = System.Drawing.Color.White;
            this.lb_song.Location = new System.Drawing.Point(123, 13);
            this.lb_song.Name = "lb_song";
            this.lb_song.Size = new System.Drawing.Size(134, 30);
            this.lb_song.TabIndex = 11;
            this.lb_song.Text = "Song\'s name";
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
            this.pt_thumb.Location = new System.Drawing.Point(7, 6);
            this.pt_thumb.Name = "pt_thumb";
            this.pt_thumb.PressedState.ImageSize = new System.Drawing.Size(100, 100);
            this.pt_thumb.Size = new System.Drawing.Size(100, 73);
            this.pt_thumb.TabIndex = 13;
            this.pt_thumb.Click += new System.EventHandler(this.pt_thumb_Click);
            // 
            // new_release
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pt_thumb);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_song);
            this.Name = "new_release";
            this.Size = new System.Drawing.Size(598, 84);
            this.Load += new System.EventHandler(this.new_release_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton pt_thumb;
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.Label lb_song;
    }
}
