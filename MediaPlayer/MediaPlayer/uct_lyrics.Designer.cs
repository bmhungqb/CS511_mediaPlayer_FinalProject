﻿namespace MediaPlayer
{
    partial class uct_lyrics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_lyrics));
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_record = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 577);
            this.panel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox7);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_record);
            this.guna2CustomGradientPanel1.Controls.Add(this.name);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1379, 75);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(569, 12);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(247, 40);
            this.name.TabIndex = 94;
            this.name.Text = "HIEUTHUHAI";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::MediaPlayer.Properties.Resources._216437_back_arrow_icon;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(54, 54);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 95;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // btn_record
            // 
            this.btn_record.BackColor = System.Drawing.Color.Transparent;
            this.btn_record.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_record.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_record.Image = ((System.Drawing.Image)(resources.GetObject("btn_record.Image")));
            this.btn_record.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_record.ImageRotate = 0F;
            this.btn_record.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_record.Location = new System.Drawing.Point(1219, 6);
            this.btn_record.Name = "btn_record";
            this.btn_record.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_record.Size = new System.Drawing.Size(64, 54);
            this.btn_record.TabIndex = 96;
            this.btn_record.Visible = false;
            // 
            // uct_lyrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "uct_lyrics";
            this.Size = new System.Drawing.Size(1404, 577);
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI2.WinForms.Guna2ImageButton btn_record;
    }
}
