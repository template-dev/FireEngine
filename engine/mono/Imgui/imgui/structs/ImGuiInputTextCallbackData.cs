// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace UI
{
    // ../../imgui/imgui.h:1688
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ImGuiInputTextCallbackData
    {

        public int EventFlag;
        public int Flags;
        public IntPtr UserData;
        public ushort EventChar;
        public int EventKey;
        public IntPtr Buf;
        public int BufTextLen;
        public int BufSize;
        public bool BufDirty;
        public int CursorPos;
        public int SelectionStart;
        public int SelectionEnd;
    }
}
