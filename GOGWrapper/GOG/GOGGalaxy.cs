using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

using GOGWrapper.Utils;

namespace GOGWrapper.GOG
{
    class GOGGalaxy
    {
        private static int _x = 420;
        private static int _y = 190;

        public static void open(GOGGame game)
        {
            if(game == null) return;
            GOGGalaxy.open(game.ID);
        }
        public static void launch(GOGGame game)
        {
            if (game == null) return;
            GOGGalaxy.launch(game.ID);
        }

        public static void open(string id)
        {
            Process.Start(GOGRegistry.ClientExecutable, $@"/gameid {id} /command launch");
        }

        public static void launch(string id, Action callback = null)
        {
            // GOGGalaxy.launchWinapi(id); // old hacky way
            
            Process.Start(GOGRegistry.ClientExecutable, $@"/gameid {id} /command runGame");
            GOGGalaxy.waitForStartup();

            GOGGame game = GOGRegistry.Game(id);            

            if(game?.ExecutableName?.Length > 0)
            {
                Thread.Sleep(5000);

                Process[] procs = Process.GetProcessesByName(game.ExecutableName.Replace(".exe", ""));

                if (procs?.Length > 0)
                {
                    procs[0].WaitForExit();
                }

                Thread.Sleep(5000);

                procs = Process.GetProcesses();

                foreach(Process proc in procs)
                {
                    try
                    {
                        if(normalize(proc.MainModule.FileName).StartsWith(normalize(game.Path)))
                        {
                            proc.WaitForExit();
                            break;
                        }
                    }
                    catch {}
                }
            }

            callback?.Invoke();
        }

        private static void launchWinapi(string id)
        {
            GOGGalaxy.open(id);

            IntPtr hwnd = GOGGalaxy.waitForStartup();

            WinAPI.SetForegroundWindow(hwnd);
            WinAPI.Click(hwnd, new System.Drawing.Point(_x, _y));
        }

        private static IntPtr waitForStartup()
        {
            IntPtr hwnd = WinAPI.FindWindow("GalaxyClientClass", null);

            bool windowExists = WinAPI.IsWindow(hwnd);

            Thread.Sleep(500);

            if (!windowExists)
            {
                hwnd = WinAPI.WaitForWindow("GalaxyClientClass", null);
                Thread.Sleep(5000);
            }

            return hwnd;
        }

        private static string normalize(string path)
        {
            return Path.GetFullPath(new Uri(path).LocalPath).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }
    }
}
