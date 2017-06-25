using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using GOGWrapper.GOG;

namespace GOGWrapper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                string gameid = args[1];
                bool exitGalaxy = false;

                if (args.Length > 2)
                {
                    for (int i = 2; i < args.Length; i++)
                    {
                        string arg = args[i];

                        switch (arg)
                        {
                            case "--exit":
                            case "-e":
                            case "/exit":
                                exitGalaxy = true;
                                break;

                            default: break;
                        }
                    }
                }

                LaunchingForm form = new LaunchingForm(gameid);
                form.ExitGalaxy = exitGalaxy;

                Application.Run(form);
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
