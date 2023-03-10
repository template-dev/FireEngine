// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace UI
{
    // ../../imgui/imgui.h:1747
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ImGuiPayload
    {

        public IntPtr Data;
        public int DataSize;
        public uint SourceId;
        public uint SourceParentId;
        public int DataFrameCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)] public sbyte[] DataType;
        public bool Preview;
        public bool Delivery;
    }
}
