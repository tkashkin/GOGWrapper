using Microsoft.Win32;
using System;
using System.IO;
using GOGWrapper.Steam.VDFParser;
using GOGWrapper.Steam.VDFParser.Models;

namespace GOGWrapper.Steam
{
    public static class SteamUtils
    {
        /// <summary>
        /// Returns Steam's current installed path
        /// </summary>
        /// <returns></returns>
        public static string GetSteamFolder()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Valve\\Steam");
            if (key == null)
                if ((key = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Valve\\Steam")) == null)
                    return null;
            return key.GetValue("InstallPath").ToString();
        }

        /// <summary>
        /// Returns all the users on userdata
        /// </summary>
        /// <param name="steamInstallPath">Steam's current installed path</param>
        /// <returns>ListString of users path</returns>
        public static String[] GetUsers(string steamInstallPath = null)
        {
            steamInstallPath = steamInstallPath ?? SteamUtils.GetSteamFolder();
            return Directory.GetDirectories(steamInstallPath + "\\userdata");
        }

        public static VDFEntry[] ReadShortcuts(string userPath)
        {
            string shortcutFile = userPath + "\\config\\shortcuts.vdf";
            VDFEntry[] shortcuts = new VDFEntry[0];

            //Some users don't seem to have the config directory at all or the shortcut file, return a empty entry for those
            if (!Directory.Exists(userPath + "\\config\\") || !File.Exists(shortcutFile))
            {
                return shortcuts;
            }

            shortcuts = VDFParser.VDFParser.Parse(shortcutFile);

            return shortcuts;
        }

        public static void WriteShortcuts(VDFEntry[] vdf, string userPath)
        {
            byte[] result = VDFSerializer.Serialize(vdf);

            try
            {
                File.WriteAllBytes(userPath + "\\config\\shortcuts.vdf", result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}