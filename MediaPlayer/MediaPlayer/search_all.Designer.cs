namespace MediaPlayer
{
    partial class search_all
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
            this.label1 = new System.Windows.Forms.Label();
            this.flow_song = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flow_playlist = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flow_artist = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flow_song);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flow_playlist);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flow_artist);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 869);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Song";
            // 
            // flow_song
            // 
            this.flow_song.AutoScroll = true;
            this.flow_song.Location = new System.Drawing.Point(2, 48);
            this.flow_song.Name = "flow_song";
            this.flow_song.Size = new System.Drawing.Size(1341, 179);
            this.flow_song.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playlist";
            // 
            // flow_playlist
            // 
            this.flow_playlist.AutoScroll = true;
            this.flow_playlist.Location = new System.Drawing.Point(2, 283);
            this.flow_playlist.Name = "flow_playlist";
            this.flow_playlist.Size = new System.Drawing.Size(1341, 232);
            this.flow_playlist.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "Artist";
            // 
            // flow_artist
            // 
            this.flow_artist.AutoScroll = true;
            this.flow_artist.Location = new System.Drawing.Point(2, 571);
            this.flow_artist.Name = "flow_artist";
            this.flow_artist.Size = new System.Drawing.Size(1341, 270);
            this.flow_artist.TabIndex = 12;
            // 
            // search_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "search_all";
            this.Size = new System.Drawing.Size(1346, 869);
            this.Load += new System.EventHandler(this.search_all_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flow_song;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flow_playlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flow_artist;
    }
}
