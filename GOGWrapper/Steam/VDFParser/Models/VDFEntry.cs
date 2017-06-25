namespace GOGWrapper.Steam.VDFParser.Models
{
    /// <summary>
    /// Represents a VDF entry
    /// </summary>
    public class VDFEntry
    {
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>The index.</value>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the name of the app.
        /// </summary>
        /// <value>The name of the app.</value>
        [VDFField("appname")]
        public string AppName { get; set; }

        /// <summary>
        /// Gets or sets the app executable path. Extra arguments should be provided
        /// within this string and should use the following format:
        /// "/path/to/binary" -arg1 "argument with spaces"
        /// or the following format, if no argument is required:
        /// "/path/to/binary"
        /// </summary>
        /// <value>The executable path, along with its command line arguments</value>
        [VDFField("exe")]
        public string Exe { get; set; }

        /// <summary>
        /// Gets or sets the application start directory
        /// </summary>
        /// <value>The start directory</value>
        [VDFField("StartDir")]
        public string StartDir { get; set; }

        /// <summary>
        /// Gets or sets the application icon
        /// </summary>
        /// <value>The application icon</value>
        [VDFField("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the application shortcut path.
        /// </summary>
        /// <value>The application shortcut path.</value>
        [VDFField("ShortcutPath")]
        public string ShortcutPath { get; set; }

        /// <summary>
        /// Gets or sets whether the application is hidden. 
        /// Use 1 for true, or 0 otherwise.
        /// </summary>
        /// <value>Whether the application is hidden.</value>
        [VDFField("IsHidden", Type = VDFFieldType.Integer)]
        public int IsHidden { get; set; }

        /// <summary>
        /// Gets or sets whether desktop configuration is allowed.
        /// Use 1 for true, or 0 otherwise.
        /// </summary>
        /// <value>Whether the desktop configuration is allowed</value>
        [VDFField("AllowDesktopConfig", Type = VDFFieldType.Integer)]
        public int AllowDesktopConfig { get; set; }

        /// <summary>
        /// Gets or sets whether this is an OpenVR application
        /// Use 1 for true, or 0 otherwise.
        /// </summary>
        /// <value>Whether this is an OpenVR application</value>
        [VDFField("OpenVR", Type = VDFFieldType.Integer)]
        public int OpenVR { get; set; }

        /// <summary>
        /// Gets or sets a list of tags for the application
        /// </summary>
        /// <value>Tags list for the application</value>
        [VDFField("tags", Type = VDFFieldType.IndexedArray)]
        public string[] Tags { get; set; }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:VDFParser.Models.VDFEntry"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:VDFParser.Models.VDFEntry"/>.</returns>
        public override string ToString()
        {
            return string.Format("[VDFEntry: AppName={0}, Exe={1}, StartDir={2}, Icon={3}, ShortcutPath={4}, IsHidden={5}, AllowDesktopConfig={6}, OpenVR={7}, Tags={8}]", AppName, Exe, StartDir, Icon, ShortcutPath, IsHidden, AllowDesktopConfig, OpenVR, Tags == null ? "(null)" : string.Join(", ", Tags));
        }
    }
}
