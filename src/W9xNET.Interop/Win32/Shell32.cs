﻿using System.Runtime.InteropServices;

namespace W9xNET.Interop.Win32
{
    public static class Shell32
    {
        /// <summary>
        /// The name of the DLL file that is installed on the primary Windows partition.
        /// </summary>
        public const string Shell32Dll = "shell32.dll";


        #region Enum(s)

        [Flags]
        public enum SHGetFileInfoFlags : int
        {
            Icon = 0x000000100,     // get icon
            DisplayName = 0x000000200,     // get display name
            TypeName = 0x000000400,     // get type name
            Attributes = 0x000000800,     // get attributes
            IconLocation = 0x000001000,     // get icon location
            ExeType = 0x000002000,     // return exe type
            SysIconIndex = 0x000004000,     // get system icon index
            LinkOverlay = 0x000008000,     // put a link overlay on icon
            Selected = 0x000010000,     // show icon in selected state
            AttrSpecified = 0x000020000,     // get only specified attributes
            LargeIcon = 0x000000000,     // get large icon
            SmallIcon = 0x000000001,     // get small icon
            OpenIcon = 0x000000002,     // get open icon
            ShellIconSize = 0x000000004,     // get shell size icon
            PIDL = 0x000000008,     // pszPath is a pidl
            UseFileAttributes = 0x000000010      // use passed dwFileAttribute
        }

        #endregion

        #region Structure(s)

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        #endregion


        [DllImport(Shell32Dll)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, SHGetFileInfoFlags uFlags);
    }
}