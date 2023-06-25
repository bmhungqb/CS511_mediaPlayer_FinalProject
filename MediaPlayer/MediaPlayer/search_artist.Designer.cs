namespace MediaPlayer
{
    partial class search_artist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_follow = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.pt_artist = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_artist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb_follow);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 74);
            this.panel1.TabIndex = 1;
            // 
            // lb_follow
            // 
            this.lb_follow.AutoSize = true;
            this.lb_follow.BackColor = System.Drawing.Color.Transparent;
            this.lb_follow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_follow.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_follow.Location = new System.Drawing.Point(4, 40);
            this.lb_follow.Name = "lb_follow";
            this.lb_follow.Size = new System.Drawing.Size(70, 20);
            this.lb_follow.TabIndex = 8;
            this.lb_follow.Text = "lb_follow";
            this.lb_follow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            this.lb_name.AutoEllipsis = true;
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.White;
            this.lb_name.Location = new System.Drawing.Point(3, 2);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(157, 28);
            this.lb_name.TabIndex = 7;
            this.lb_name.Text = "Artist\'s name";
            // 
            // pt_artist
            // 
            this.pt_artist.BackColor = System.Drawing.Color.Transparent;
            this.pt_artist.ImageRotate = 0F;
            this.pt_artist.Location = new System.Drawing.Point(3, 3);
            this.pt_artist.Name = "pt_artist";
            this.pt_artist.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pt_artist.Size = new System.Drawing.Size(235, 185);
            this.pt_artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_artist.TabIndex = 0;
            this.pt_artist.TabStop = false;
            this.pt_artist.Click += new System.EventHandler(this.pt_artist_Click);
            // 
            // search_artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pt_artist);
            this.Name = "search_artist";
            this.Size = new System.Drawing.Size(241, 263);
            this.Load += new System.EventHandler(this.search_artist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_artist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pt_artist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_follow;
        private System.Windows.Forms.Label lb_name;
    }
}
