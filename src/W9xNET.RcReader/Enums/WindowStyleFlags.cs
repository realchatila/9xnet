﻿using System;
using QWORD = System.Int64;

namespace W9xNET.RcReader.Enums
{
    [Flags]
    public enum WindowStyleFlags : QWORD
    {
        /*
         * Dialog Styles
         */
        DS_ABSALIGN = 0x01L,
        DS_SYSMODAL = 0x02L,
        DS_LOCALEDIT = 0x20L,
        DS_SETFONT = 0x40L,
        DS_MODALFRAME = 0x80L,
        DS_NOIDLEMSG = 0x100L,
        DS_SETFOREGROUND = 0x200L,
        DS_3DLOOK = 0x0004L,
        DS_FIXEDSYS = 0x0008L,
        DS_NOFAILCREATE = 0x0010L,
        DS_CONTROL = 0x0400L,
        DS_CENTER = 0x0800L,
        DS_CENTERMOUSE = 0x1000L,
        DS_CONTEXTHELP = 0x2000L,
        DS_SHELLFONT = (DS_SETFONT | DS_FIXEDSYS),
        DS_USEPIXELS = 0x8000L,

        /*
         * Window Styles
         */

        WS_OVERLAPPED = 0x00000000L,
        WS_POPUP = 0x80000000L,
        WS_CHILD = 0x40000000L,
        WS_MINIMIZE = 0x20000000L,
        WS_VISIBLE = 0x10000000L,
        WS_DISABLED = 0x08000000L,
        WS_CLIPSIBLINGS = 0x04000000L,
        WS_CLIPCHILDREN = 0x02000000L,
        WS_MAXIMIZE = 0x01000000L,
        WS_CAPTION = 0x00C00000L,
        WS_BORDER = 0x00800000L,
        WS_DLGFRAME = 0x00400000L,
        WS_VSCROLL = 0x00200000L,
        WS_HSCROLL = 0x00100000L,
        WS_SYSMENU = 0x00080000L,
        WS_THICKFRAME = 0x00040000L,
        WS_GROUP = 0x00020000L,
        WS_TABSTOP = 0x00010000L,
        WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
        WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU,
        WS_MINIMIZEBOX = 0x00020000L,
        WS_MAXIMIZEBOX = 0x00010000L,
        WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX
    }
}