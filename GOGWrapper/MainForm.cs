using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using GOGWrapper.GOG;

using GOGWrapper.Steam;
using GOGWrapper.Steam.VDFParser.Models;

using GOGWrapper.Utils;

namespace GOGWrapper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = $"GOGWrapper - {GOGRegistry.ClientPath}";
            this.gamesList.DataSource = GOGRegistry.Games;
        }

        private void gamesList_SelectedValueChanged(object sender, EventArgs e)
        {
            GOGGame game = (GOGGame) this.gamesList.SelectedValue;

            if(game == null) return;

            this.gameName.Text = game.Name;
            this.gameID.Text = game.ID;
            this.gameIcon.ImageLocation = game.Icon;
            this.gamePath.Text = game.Path;
        }

        private void gamePath_Click(object sender, EventArgs e)
        {
            GOGGame game = (GOGGame) this.gamesList.SelectedValue;
            if (game == null) return;
            Process.Start(game.Path);
        }

        private void gameGalaxyBtn_Click(object sender, EventArgs e)
        {
            GOGGame game = (GOGGame) this.gamesList.SelectedValue;
            GOGGalaxy.open(game);
        }

        private void gameLaunchBtn_Click(object sender, EventArgs e)
        {
            GOGGame game = (GOGGame) this.gamesList.SelectedValue;
            new LaunchingForm(game.ID).ShowDialog();
        }

        private void gameSteamShortcut_Click(object sender, EventArgs e)
        {
            GOGGame game = (GOGGame)this.gamesList.SelectedValue;
            if (game == null) return;

            this.gameSteamShortcut.Enabled = false;

            try
            {
                string[] users = SteamUtils.GetUsers();

                VDFEntry shortcut = new VDFEntry()
                {
                    AppName = game.Name,
                    Exe = $"\"{Application.ExecutablePath}\" {game.ID} -e",
                    StartDir = $"\"{game.Path}\"",
                    Icon = game.Icon,
                    ShortcutPath = "",
                    IsHidden = 0,
                    AllowDesktopConfig = 1,
                    OpenVR = 0,
                    Tags = new string[] { "GOG.com" },
                    Index = 0
                };

                foreach(string user in users)
                {
                    List<VDFEntry> shortcuts = new List<VDFEntry>(SteamUtils.ReadShortcuts(user));

                    shortcuts.Add(shortcut);

                    SteamUtils.WriteShortcuts(shortcuts.ToArray(), user);
                }

                MessageBox.Show("You may need to restart Steam to use new shortcut", "Steam shortcut added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Steam shortcut add failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.gameSteamShortcut.Enabled = true;
        }
    }
}
