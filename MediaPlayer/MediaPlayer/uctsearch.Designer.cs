namespace MediaPlayer
{
    partial class uctsearch
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
            this.btn_playlist = new Guna.UI2.WinForms.Guna2Button();
            this.btn_artist = new Guna.UI2.WinForms.Guna2Button();
            this.btn_song = new Guna.UI2.WinForms.Guna2Button();
            this.btn_all = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_search = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.flowLayoutSearch.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_playlist);
            this.panel1.Controls.Add(this.btn_artist);
            this.panel1.Controls.Add(this.btn_song);
            this.panel1.Controls.Add(this.btn_all);
            this.panel1.Location = new System.Drawing.Point(14, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 50);
            this.panel1.TabIndex = 10;
            // 
            // btn_playlist
            // 
            this.btn_playlist.AutoRoundedCorners = true;
            this.btn_playlist.BackColor = System.Drawing.Color.Transparent;
            this.btn_playlist.BorderColor = System.Drawing.Color.Transparent;
            this.btn_playlist.BorderRadius = 22;
            this.btn_playlist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_playlist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_playlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_playlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_playlist.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_playlist.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playlist.ForeColor = System.Drawing.Color.White;
            this.btn_playlist.Location = new System.Drawing.Point(422, 2);
            this.btn_playlist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(152, 46);
            this.btn_playlist.TabIndex = 13;
            this.btn_playlist.Text = "Playlists";
            this.btn_playlist.Click += new System.EventHandler(this.btn_Click_Type_Search);
            // 
            // btn_artist
            // 
            this.btn_artist.AutoRoundedCorners = true;
            this.btn_artist.BackColor = System.Drawing.Color.Transparent;
            this.btn_artist.BorderColor = System.Drawing.Color.Transparent;
            this.btn_artist.BorderRadius = 22;
            this.btn_artist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_artist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_artist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_artist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_artist.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_artist.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artist.ForeColor = System.Drawing.Color.White;
            this.btn_artist.Location = new System.Drawing.Point(281, 1);
            this.btn_artist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_artist.Name = "btn_artist";
            this.btn_artist.Size = new System.Drawing.Size(128, 46);
            this.btn_artist.TabIndex = 12;
            this.btn_artist.Text = "Artists";
            this.btn_artist.Click += new System.EventHandler(this.btn_Click_Type_Search);
            // 
            // btn_song
            // 
            this.btn_song.AutoRoundedCorners = true;
            this.btn_song.BackColor = System.Drawing.Color.Transparent;
            this.btn_song.BorderColor = System.Drawing.Color.Transparent;
            this.btn_song.BorderRadius = 22;
            this.btn_song.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_song.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_song.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_song.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_song.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_song.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_song.ForeColor = System.Drawing.Color.White;
            this.btn_song.Location = new System.Drawing.Point(143, 2);
            this.btn_song.Margin = new System.Windows.Forms.Padding(2);
            this.btn_song.Name = "btn_song";
            this.btn_song.Size = new System.Drawing.Size(128, 46);
            this.btn_song.TabIndex = 11;
            this.btn_song.Text = "Songs";
            this.btn_song.Click += new System.EventHandler(this.btn_Click_Type_Search);
            // 
            // btn_all
            // 
            this.btn_all.AutoRoundedCorners = true;
            this.btn_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_all.BorderColor = System.Drawing.Color.Transparent;
            this.btn_all.BorderRadius = 22;
            this.btn_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_all.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_all.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(4, 2);
            this.btn_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(128, 46);
            this.btn_all.TabIndex = 10;
            this.btn_all.Text = "All";
            this.btn_all.Click += new System.EventHandler(this.btn_Click_Type_Search);
            // 
            // flowLayoutSearch
            // 
            this.flowLayoutSearch.AutoScroll = true;
            this.flowLayoutSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutSearch.Controls.Add(this.panel_search);
            this.flowLayoutSearch.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutSearch.Name = "flowLayoutSearch";
            this.flowLayoutSearch.Size = new System.Drawing.Size(1385, 574);
            this.flowLayoutSearch.TabIndex = 11;
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.tb_search);
            this.panel_search.Controls.Add(this.panel1);
            this.panel_search.FillColor = System.Drawing.Color.DimGray;
            this.panel_search.FillColor2 = System.Drawing.SystemColors.WindowFrame;
            this.panel_search.FillColor3 = System.Drawing.Color.Black;
            this.panel_search.FillColor4 = System.Drawing.Color.DimGray;
            this.panel_search.Location = new System.Drawing.Point(3, 3);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(1360, 131);
            this.panel_search.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.AutoRoundedCorners = true;
            this.tb_search.BackColor = System.Drawing.Color.Transparent;
            this.tb_search.BorderColor = System.Drawing.Color.White;
            this.tb_search.BorderRadius = 25;
            this.tb_search.BorderThickness = 2;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.tb_search.ForeColor = System.Drawing.Color.LightGray;
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.IconLeft = global::MediaPlayer.Properties.Resources.find;
            this.tb_search.IconLeftSize = new System.Drawing.Size(65, 65);
            this.tb_search.Location = new System.Drawing.Point(4, 15);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderForeColor = System.Drawing.Color.White;
            this.tb_search.PlaceholderText = "What do you want to listen to?";
            this.tb_search.SelectedText = "";
            this.tb_search.Size = new System.Drawing.Size(495, 52);
            this.tb_search.TabIndex = 0;
            this.tb_search.Click += new System.EventHandler(this.guna2TextBox1_Click);
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // uctsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uctsearch";
            this.Size = new System.Drawing.Size(1385, 577);
            this.panel1.ResumeLayout(false);
            this.flowLayoutSearch.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_playlist;
        private Guna.UI2.WinForms.Guna2Button btn_artist;
        private Guna.UI2.WinForms.Guna2Button btn_song;
        private Guna.UI2.WinForms.Guna2Button btn_all;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSearch;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_search;
    }
}
