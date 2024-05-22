namespace YoutubeVidDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.VidURLTextBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.outputSelect = new System.Windows.Forms.ComboBox();
            this.ytThumb = new System.Windows.Forms.PictureBox();
            this.vidTitle = new System.Windows.Forms.Label();
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ytThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // VidURLTextBox
            // 
            this.VidURLTextBox.Location = new System.Drawing.Point(12, 9);
            this.VidURLTextBox.Name = "VidURLTextBox";
            this.VidURLTextBox.Size = new System.Drawing.Size(581, 20);
            this.VidURLTextBox.TabIndex = 0;
            this.VidURLTextBox.Enter += new System.EventHandler(this.VidURLTextBox_Enter);
            this.VidURLTextBox.Leave += new System.EventHandler(this.VidURLTextBox_Leave);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(599, 8);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // outputSelect
            // 
            this.outputSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputSelect.FormattingEnabled = true;
            this.outputSelect.Items.AddRange(new object[] {
            "Video (Complete)",
            "Video only",
            "Audio only"});
            this.outputSelect.Location = new System.Drawing.Point(680, 11);
            this.outputSelect.Name = "outputSelect";
            this.outputSelect.Size = new System.Drawing.Size(108, 21);
            this.outputSelect.TabIndex = 2;
            // 
            // ytThumb
            // 
            this.ytThumb.Location = new System.Drawing.Point(12, 35);
            this.ytThumb.Name = "ytThumb";
            this.ytThumb.Size = new System.Drawing.Size(581, 327);
            this.ytThumb.TabIndex = 3;
            this.ytThumb.TabStop = false;
            // 
            // vidTitle
            // 
            this.vidTitle.AutoSize = true;
            this.vidTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vidTitle.Location = new System.Drawing.Point(299, 365);
            this.vidTitle.Name = "vidTitle";
            this.vidTitle.Size = new System.Drawing.Size(0, 13);
            this.vidTitle.TabIndex = 4;
            // 
            // DownloadBar
            // 
            this.DownloadBar.Location = new System.Drawing.Point(12, 381);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(581, 23);
            this.DownloadBar.TabIndex = 5;
            this.DownloadBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DownloadBar);
            this.Controls.Add(this.vidTitle);
            this.Controls.Add(this.ytThumb);
            this.Controls.Add(this.outputSelect);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.VidURLTextBox);
            this.Name = "Form1";
            this.Text = "Youtube XD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ytThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VidURLTextBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.ComboBox outputSelect;
        private System.Windows.Forms.PictureBox ytThumb;
        private System.Windows.Forms.Label vidTitle;
        private System.Windows.Forms.ProgressBar DownloadBar;
    }
}

