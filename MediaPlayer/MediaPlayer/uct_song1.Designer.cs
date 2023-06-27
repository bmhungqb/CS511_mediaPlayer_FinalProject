namespace MediaPlayer
{
    partial class uct_song1
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
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pt_thumb = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_singer.Location = new System.Drawing.Point(125, 46);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(66, 25);
            this.lb_singer.TabIndex = 14;
            this.lb_singer.Text = "Singer";
            // 
            // lb_song
            // 
            this.lb_song.AutoSize = true;
            this.lb_song.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_song.ForeColor = System.Drawing.Color.White;
            this.lb_song.Location = new System.Drawing.Point(123, 3);
            this.lb_song.Name = "lb_song";
            this.lb_song.Size = new System.Drawing.Size(189, 41);
            this.lb_song.TabIndex = 12;
            this.lb_song.Text = "Song\'s name";
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderColor = System.Drawing.Color.DimGray;
            this.btn_add.BorderRadius = 19;
            this.btn_add.BorderThickness = 2;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(424, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 40);
            this.btn_add.TabIndex = 96;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 79);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(564, 10);
            this.guna2Separator1.TabIndex = 98;
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
            this.pt_thumb.TabIndex = 17;
            this.pt_thumb.Click += new System.EventHandler(this.pt_thumb_Click);
            // 
            // uct_song1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_song);
            this.Controls.Add(this.pt_thumb);
            this.Name = "uct_song1";
            this.Size = new System.Drawing.Size(515, 89);
            this.Load += new System.EventHandler(this.uct_song1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton pt_thumb;
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.Label lb_song;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
