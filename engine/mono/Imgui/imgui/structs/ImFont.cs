// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace UI
{
    // ../../imgui/imgui.h:2433
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ImFont
    {

        public IntPtr IndexAdvanceX;
        public float FallbackAdvanceX;
        public float FontSize;
        public IntPtr IndexLookup;
        public IntPtr Glyphs;
        public IntPtr FallbackGlyph;
        public Vector2 DisplayOffset;
        public IntPtr ContainerAtlas;
        public IntPtr ConfigData;
        public short ConfigDataCount;
        public ushort FallbackChar;
        public ushort EllipsisChar;
        public bool DirtyLookupTables;
        public float Scale;
        public float Ascent;
        public float Descent;
        public int MetricsTotalSurface;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] public byte[] Used4kPagesMap;
    }
}
