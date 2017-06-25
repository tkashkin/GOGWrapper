using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace GOGWrapper.GOG
{
    class GOGRegistry
    {
        #region Registry keys

        private static RegistryKey _regroot;
        public static RegistryKey REGRoot
        {
            get
            {
                _regroot = _regroot ?? Registry.LocalMachine.OpenSubKey(@"SOFTWARE\GOG.com");
                return _regroot;
            }
        }

        private static RegistryKey _regclient;
        public static RegistryKey REGClient
        {
            get
            {
                _regclient = _regclient ?? GOGRegistry.REGRoot?.OpenSubKey(@"GalaxyClient\paths");
                return _regclient;
            }
        }

        private static RegistryKey _reggames;
        public static RegistryKey REGGames
        {
            get
            {
                _reggames = _reggames ?? GOGRegistry.REGRoot?.OpenSubKey(@"Games");
                return _reggames;
            }
        }

        #endregion

        #region Values

        private static string _clientPath;
        public static string ClientPath
        {
            get
            {
                if(_clientPath == null || _clientPath.Trim().Length == 0)
                {
                    _clientPath = (string) GOGRegistry.REGClient?.GetValue("client");
                }
                return _clientPath;
            }
        }
        public static string ClientExecutable => (GOGRegistry.ClientPath ?? "") + @"\GalaxyClient.exe";

        private static List<GOGGame> _games;
        public static List<GOGGame> Games
        {
            get
            {
                if(_games == null)
                {
                    _games = new List<GOGGame>();

                    RegistryKey g = GOGRegistry.REGGames;

                    if(g != null)
                    {
                        foreach(string id in g.GetSubKeyNames())
                        {
                            RegistryKey key = g.OpenSubKey(id);
                            
                            if(GOGGame.IsValidGame(key)) _games.Add(new GOGGame(key));
                        }
                    }

                    _games.Sort();
                }

                return _games;
            }
        }

        public static GOGGame Game(string id)
        {
            foreach (GOGGame game in GOGRegistry.Games)
            {
                if (game.ID == id)
                {
                    return game;
                }
            }
            return null;
        }

        #endregion
    }
}
