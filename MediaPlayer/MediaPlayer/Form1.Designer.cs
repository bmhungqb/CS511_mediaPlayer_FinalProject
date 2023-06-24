namespace MediaPlayer
{
    partial class mediaPlayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaPlayer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_Player = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home1 = new Guna.UI2.WinForms.Guna2Button();
            this.find = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.playlist_b = new Guna.UI2.WinForms.Guna2Button();
            this.setting = new Guna.UI2.WinForms.Guna2Button();
            this.acc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.setting);
            this.panel2.Controls.Add(this.acc);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 150);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.playlist_b);
            this.panel3.Location = new System.Drawing.Point(2, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 151);
            this.panel3.TabIndex = 87;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.home1);
            this.panel4.Controls.Add(this.find);
            this.panel4.Location = new System.Drawing.Point(0, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 129);
            this.panel4.TabIndex = 84;
            // 
            // pnl_Player
            // 
            this.pnl_Player.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Player.Location = new System.Drawing.Point(0, 581);
            this.pnl_Player.Name = "pnl_Player";
            this.pnl_Player.Size = new System.Drawing.Size(1444, 110);
            this.pnl_Player.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 580);
            this.panel1.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.AutoRoundedCorners = true;
            this.home1.BackColor = System.Drawing.Color.Transparent;
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home1.BorderRadius = 22;
            this.home1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home1.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.home1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home1.ForeColor = System.Drawing.Color.White;
            this.home1.Image = global::MediaPlayer.Properties.Resources.home;
            this.home1.ImageSize = new System.Drawing.Size(35, 35);
            this.home1.Location = new System.Drawing.Point(2, 8);
            this.home1.Margin = new System.Windows.Forms.Padding(2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(50, 47);
            this.home1.TabIndex = 76;
            this.home1.UseTransparentBackground = true;
            this.home1.Click += new System.EventHandler(this.home1_Click_1);
            // 
            // find
            // 
            this.find.AutoRoundedCorners = true;
            this.find.BackColor = System.Drawing.Color.Transparent;
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.find.BorderRadius = 22;
            this.find.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.find.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.find.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.find.ForeColor = System.Drawing.Color.White;
            this.find.Image = global::MediaPlayer.Properties.Resources.search;
            this.find.ImageSize = new System.Drawing.Size(35, 35);
            this.find.Location = new System.Drawing.Point(2, 72);
            this.find.Margin = new System.Windows.Forms.Padding(2);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(50, 47);
            this.find.TabIndex = 77;
            this.find.UseTransparentBackground = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::MediaPlayer.Properties.Resources.rank;
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(0, 70);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(50, 47);
            this.guna2Button1.TabIndex = 79;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // playlist_b
            // 
            this.playlist_b.AutoRoundedCorners = true;
            this.playlist_b.BackColor = System.Drawing.Color.Transparent;
            this.playlist_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playlist_b.BorderRadius = 22;
            this.playlist_b.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playlist_b.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playlist_b.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playlist_b.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playlist_b.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.playlist_b.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playlist_b.ForeColor = System.Drawing.Color.White;
            this.playlist_b.Image = global::MediaPlayer.Properties.Resources.playlist;
            this.playlist_b.ImageSize = new System.Drawing.Size(35, 35);
            this.playlist_b.Location = new System.Drawing.Point(0, 5);
            this.playlist_b.Margin = new System.Windows.Forms.Padding(2);
            this.playlist_b.Name = "playlist_b";
            this.playlist_b.Size = new System.Drawing.Size(50, 47);
            this.playlist_b.TabIndex = 78;
            this.playlist_b.UseTransparentBackground = true;
            this.playlist_b.Click += new System.EventHandler(this.playlist_b_Click_1);
            // 
            // setting
            // 
            this.setting.AutoRoundedCorners = true;
            this.setting.BackColor = System.Drawing.Color.Transparent;
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setting.BorderRadius = 22;
            this.setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setting.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.setting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = global::MediaPlayer.Properties.Resources.setting;
            this.setting.ImageSize = new System.Drawing.Size(35, 35);
            this.setting.Location = new System.Drawing.Point(0, 95);
            this.setting.Margin = new System.Windows.Forms.Padding(2);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(50, 47);
            this.setting.TabIndex = 87;
            this.setting.UseTransparentBackground = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // acc
            // 
            this.acc.AutoRoundedCorners = true;
            this.acc.BackColor = System.Drawing.Color.Transparent;
            this.acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acc.BorderRadius = 22;
            this.acc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.acc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.acc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.acc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.acc.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.acc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acc.ForeColor = System.Drawing.Color.White;
            this.acc.Image = global::MediaPlayer.Properties.Resources.profile;
            this.acc.ImageSize = new System.Drawing.Size(35, 35);
            this.acc.Location = new System.Drawing.Point(0, 40);
            this.acc.Margin = new System.Windows.Forms.Padding(2);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(50, 47);
            this.acc.TabIndex = 85;
            this.acc.UseTransparentBackground = true;
            this.acc.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button3.BorderRadius = 16;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::MediaPlayer.Properties.Resources.menu;
            this.guna2Button3.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button3.Location = new System.Drawing.Point(2, 2);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(50, 34);
            this.guna2Button3.TabIndex = 80;
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // mediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1444, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Player);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mediaPlayer";
            this.Load += new System.EventHandler(this.mediaPlayer_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button playlist_b;
        private Guna.UI2.WinForms.Guna2Button find;
        private Guna.UI2.WinForms.Guna2Button home1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button setting;
        private Guna.UI2.WinForms.Guna2Button acc;
        private System.Windows.Forms.Panel pnl_Player;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

