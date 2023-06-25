namespace MediaPlayer
{
    partial class uct_video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_video));
            this.pnl_video = new Guna.UI2.WinForms.Guna2Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lb_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnl_video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_video
            // 
            this.pnl_video.BackColor = System.Drawing.Color.Transparent;
            this.pnl_video.Controls.Add(this.lb_title);
            this.pnl_video.Controls.Add(this.player);
            this.pnl_video.Controls.Add(this.btn_back);
            this.pnl_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_video.Location = new System.Drawing.Point(0, 0);
            this.pnl_video.Name = "pnl_video";
            this.pnl_video.Size = new System.Drawing.Size(1404, 577);
            this.pnl_video.TabIndex = 0;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(191, 33);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(950, 470);
            this.player.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.HoverState.Image = global::MediaPlayer.Properties.Resources.ic_backactive1;
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_back.Image = global::MediaPlayer.Properties.Resources.ic_back1;
            this.btn_back.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_back.ImageRotate = 0F;
            this.btn_back.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_back.Location = new System.Drawing.Point(4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.Image = global::MediaPlayer.Properties.Resources.ic_backactive2;
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_back.Size = new System.Drawing.Size(48, 48);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseTransparentBackground = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Location = new System.Drawing.Point(620, 523);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(86, 15);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "guna2HtmlLabel2";
            // 
            // uct_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_video);
            this.Name = "uct_video";
            this.Size = new System.Drawing.Size(1404, 577);
            this.pnl_video.ResumeLayout(false);
            this.pnl_video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnl_video;
        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_title;
    }
}
