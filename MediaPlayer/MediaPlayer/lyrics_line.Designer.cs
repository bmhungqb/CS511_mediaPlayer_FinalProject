namespace MediaPlayer
{
    partial class lyrics_line
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
            this.lbl_lyrics = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lbl_lyrics
            // 
            this.lbl_lyrics.AutoSize = false;
            this.lbl_lyrics.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lyrics.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lyrics.ForeColor = System.Drawing.Color.White;
            this.lbl_lyrics.Location = new System.Drawing.Point(0, 0);
            this.lbl_lyrics.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_lyrics.Name = "lbl_lyrics";
            this.lbl_lyrics.Size = new System.Drawing.Size(1379, 35);
            this.lbl_lyrics.TabIndex = 3;
            this.lbl_lyrics.Text = "Nguyên Hà, Minh Min";
            this.lbl_lyrics.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lyrics_line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lbl_lyrics);
            this.Name = "lyrics_line";
            this.Size = new System.Drawing.Size(1379, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_lyrics;
    }
}
