using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GOGWrapper.GOG
{
    class GOGGame : IComparable<GOGGame>
    {
        private string _id;
        private string _name;
        private string _path;
        private string _exename;
        private string _exepath;

        public string ID             => this._id;
        public string Name           => this._name;
        public string Path           => this._path;
        public string ExecutableName => this._exename;
        public string ExecutablePath => this._exepath;
        public string Icon           => $@"{this.Path}\goggame-{this.ID}.ico";

        public GOGGame(RegistryKey key)
        {
            this._id      = (string) key.GetValue("gameID");
            this._name    = (string) key.GetValue("GAMENAME");
            this._path    = (string) key.GetValue("PATH");
            this._exename = (string) key.GetValue("EXEFILE");
            this._exepath = (string) key.GetValue("EXE");
        }

        public static bool IsValidGame(RegistryKey key)
        {
            if(key == null) return false;

            string depends = (string)key.GetValue("DEPENDSON");
            if(depends != null && depends.Trim().Length > 0) return false;

            return !_keyExists(key, "DEPENDSON")
                && _keyExists(key, "gameID")
                && _keyExists(key, "GAMENAME")
                && _keyExists(key, "PATH");
        }

        public override string ToString()
        {
            return this._name ?? this._id ?? "<unknown>";
        }

        private static bool _keyExists(RegistryKey key, string name)
        {
            string val = (string) key.GetValue(name);
            return val != null && val.Trim().Length > 0;
        }

        public int CompareTo(GOGGame other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
