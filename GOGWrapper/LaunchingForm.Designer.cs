namespace GOGWrapper
{
    partial class LaunchingForm
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
            this.gameIcon = new System.Windows.Forms.PictureBox();
            this.gameName = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.gameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gameIcon
            // 
            this.gameIcon.Location = new System.Drawing.Point(12, 8);
            this.gameIcon.Name = "gameIcon";
            this.gameIcon.Size = new System.Drawing.Size(48, 48);
            this.gameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameIcon.TabIndex = 5;
            this.gameIcon.TabStop = false;
            // 
            // gameName
            // 
            this.gameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameName.AutoEllipsis = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameName.Location = new System.Drawing.Point(66, 15);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(282, 30);
            this.gameName.TabIndex = 4;
            this.gameName.Text = "Game";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(-1, 62);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(362, 8);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 6;
            // 
            // LaunchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(360, 70);
            this.ControlBox = false;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.gameIcon);
            this.Controls.Add(this.gameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaunchingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launching...";
            ((System.ComponentModel.ISupportInitialize)(this.gameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameIcon;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.ProgressBar progress;
    }
}