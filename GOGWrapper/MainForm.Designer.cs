namespace GOGWrapper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gamesList = new System.Windows.Forms.ListBox();
            this.gameName = new System.Windows.Forms.Label();
            this.gameID = new System.Windows.Forms.Label();
            this.gameIcon = new System.Windows.Forms.PictureBox();
            this.gamePath = new System.Windows.Forms.Label();
            this.gameGalaxyBtn = new System.Windows.Forms.Button();
            this.gameLaunchBtn = new System.Windows.Forms.Button();
            this.gameSteamShortcut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesList
            // 
            this.gamesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesList.BackColor = System.Drawing.SystemColors.Window;
            this.gamesList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesList.FormattingEnabled = true;
            this.gamesList.IntegralHeight = false;
            this.gamesList.ItemHeight = 15;
            this.gamesList.Location = new System.Drawing.Point(0, 0);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(160, 321);
            this.gamesList.TabIndex = 0;
            this.gamesList.SelectedValueChanged += new System.EventHandler(this.gamesList_SelectedValueChanged);
            // 
            // gameName
            // 
            this.gameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameName.AutoEllipsis = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameName.Location = new System.Drawing.Point(220, 6);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(392, 40);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "Game";
            // 
            // gameID
            // 
            this.gameID.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gameID.Location = new System.Drawing.Point(225, 47);
            this.gameID.Name = "gameID";
            this.gameID.Size = new System.Drawing.Size(86, 12);
            this.gameID.TabIndex = 2;
            this.gameID.Text = " 123";
            // 
            // gameIcon
            // 
            this.gameIcon.Location = new System.Drawing.Point(166, 12);
            this.gameIcon.Name = "gameIcon";
            this.gameIcon.Size = new System.Drawing.Size(48, 48);
            this.gameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameIcon.TabIndex = 3;
            this.gameIcon.TabStop = false;
            // 
            // gamePath
            // 
            this.gamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePath.AutoEllipsis = true;
            this.gamePath.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamePath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gamePath.Location = new System.Drawing.Point(317, 47);
            this.gamePath.Name = "gamePath";
            this.gamePath.Size = new System.Drawing.Size(295, 12);
            this.gamePath.TabIndex = 4;
            this.gamePath.Text = "D:\\GOG\\Game";
            this.gamePath.Click += new System.EventHandler(this.gamePath_Click);
            // 
            // gameGalaxyBtn
            // 
            this.gameGalaxyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gameGalaxyBtn.Location = new System.Drawing.Point(484, 269);
            this.gameGalaxyBtn.Name = "gameGalaxyBtn";
            this.gameGalaxyBtn.Size = new System.Drawing.Size(128, 40);
            this.gameGalaxyBtn.TabIndex = 5;
            this.gameGalaxyBtn.Text = "Open GOG Galaxy";
            this.gameGalaxyBtn.UseVisualStyleBackColor = true;
            this.gameGalaxyBtn.Click += new System.EventHandler(this.gameGalaxyBtn_Click);
            // 
            // gameLaunchBtn
            // 
            this.gameLaunchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLaunchBtn.Location = new System.Drawing.Point(166, 66);
            this.gameLaunchBtn.Name = "gameLaunchBtn";
            this.gameLaunchBtn.Size = new System.Drawing.Size(446, 40);
            this.gameLaunchBtn.TabIndex = 6;
            this.gameLaunchBtn.Text = "Launch";
            this.gameLaunchBtn.UseVisualStyleBackColor = true;
            this.gameLaunchBtn.Click += new System.EventHandler(this.gameLaunchBtn_Click);
            // 
            // gameSteamShortcut
            // 
            this.gameSteamShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gameSteamShortcut.Location = new System.Drawing.Point(166, 269);
            this.gameSteamShortcut.Name = "gameSteamShortcut";
            this.gameSteamShortcut.Size = new System.Drawing.Size(210, 40);
            this.gameSteamShortcut.TabIndex = 7;
            this.gameSteamShortcut.Text = "Add shortcut to the Steam Library";
            this.gameSteamShortcut.UseVisualStyleBackColor = true;
            this.gameSteamShortcut.Click += new System.EventHandler(this.gameSteamShortcut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.gameSteamShortcut);
            this.Controls.Add(this.gameLaunchBtn);
            this.Controls.Add(this.gameGalaxyBtn);
            this.Controls.Add(this.gamePath);
            this.Controls.Add(this.gameIcon);
            this.Controls.Add(this.gameID);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gamesList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOGWrapper";
            ((System.ComponentModel.ISupportInitialize)(this.gameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label gameID;
        private System.Windows.Forms.PictureBox gameIcon;
        private System.Windows.Forms.Label gamePath;
        private System.Windows.Forms.Button gameGalaxyBtn;
        private System.Windows.Forms.Button gameLaunchBtn;
        private System.Windows.Forms.Button gameSteamShortcut;
    }
}

