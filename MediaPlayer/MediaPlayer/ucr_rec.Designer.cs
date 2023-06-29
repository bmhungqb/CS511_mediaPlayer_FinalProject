namespace MediaPlayer
{
    partial class ucr_rec
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
            this.lb_id = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_singer
            // 
            this.lb_singer.AutoSize = true;
            this.lb_singer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_singer.Location = new System.Drawing.Point(188, 56);
            this.lb_singer.Name = "lb_singer";
            this.lb_singer.Size = new System.Drawing.Size(51, 20);
            this.lb_singer.TabIndex = 15;
            this.lb_singer.Text = "Singer";
            // 
            // lb_song
            // 
            this.lb_song.AutoSize = true;
            this.lb_song.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_song.ForeColor = System.Drawing.Color.White;
            this.lb_song.Location = new System.Drawing.Point(188, 22);
            this.lb_song.Name = "lb_song";
            this.lb_song.Size = new System.Drawing.Size(119, 25);
            this.lb_song.TabIndex = 13;
            this.lb_song.Text = "Song\'s name";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.White;
            this.lb_id.Location = new System.Drawing.Point(12, 27);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(32, 37);
            this.lb_id.TabIndex = 12;
            this.lb_id.Text = "1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = global::MediaPlayer.Properties.Resources.user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(80, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 19;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // ucr_rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lb_singer);
            this.Controls.Add(this.lb_song);
            this.Controls.Add(this.lb_id);
            this.Name = "ucr_rec";
            this.Size = new System.Drawing.Size(1289, 100);
            this.Load += new System.EventHandler(this.ucr_rec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_singer;
        private System.Windows.Forms.Label lb_song;
        private System.Windows.Forms.Label lb_id;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
