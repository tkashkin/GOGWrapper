using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

using GOGWrapper.GOG;

namespace GOGWrapper
{
    public partial class LaunchingForm : Form
    {
        public bool ExitGalaxy = false;

        public LaunchingForm(String gameid)
        {
            InitializeComponent();

            GOGGame game = GOGRegistry.Game(gameid);

            this.gameName.Text = game?.Name;
            this.gameIcon.ImageLocation = game?.Icon;

            new Thread(new ThreadStart(() => GOGGalaxy.launch(gameid, this.Exit))).Start();
        }

        private void GalaxyPreExit()
        {
            this.Text = "Exiting in 20 seconds...";
            this.progress.Visible = false;
            //this.Hide();
        }

        private void Exit()
        {
            if (this.ExitGalaxy)
            {
                foreach (Process proc in Process.GetProcessesByName("GalaxyClient"))
                {
                    this.Invoke((MethodInvoker) this.GalaxyPreExit);

                    proc.CloseMainWindow();
                    Thread.Sleep(20000); // delay for galaxy sync, etc
                    try                  // user can kill process before timeout
                    {
                        proc.Kill();
                    }
                    catch { }
                    break;
                }
            }

            this.Invoke((MethodInvoker) this.Close);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
    }
}
