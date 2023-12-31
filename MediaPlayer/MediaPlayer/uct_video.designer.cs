﻿namespace MediaPlayer
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.name = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.player);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(67)))), ((int)(((byte)(219)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1404, 577);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(232, 106);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(900, 400);
            this.player.TabIndex = 99;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_back);
            this.guna2CustomGradientPanel2.Controls.Add(this.name);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1404, 75);
            this.guna2CustomGradientPanel2.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.HoverState.Image = global::MediaPlayer.Properties.Resources.ic_back48new_active;
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_back.Image = global::MediaPlayer.Properties.Resources.ic_back48new;
            this.btn_back.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_back.ImageRotate = 0F;
            this.btn_back.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_back.Location = new System.Drawing.Point(2, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.Image = global::MediaPlayer.Properties.Resources.ic_back48new_active1;
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_back.Size = new System.Drawing.Size(48, 48);
            this.btn_back.TabIndex = 97;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(113, 14);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(1053, 40);
            this.name.TabIndex = 94;
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uct_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "uct_video";
            this.Size = new System.Drawing.Size(1404, 577);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label name;
        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
    }
}
