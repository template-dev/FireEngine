// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace UI
{
    // ../../imgui/imgui.h:1482
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ImGuiStyle
    {

        public float Alpha;
        public Vector2 WindowPadding;
        public float WindowRounding;
        public float WindowBorderSize;
        public Vector2 WindowMinSize;
        public Vector2 WindowTitleAlign;
        public int WindowMenuButtonPosition;
        public float ChildRounding;
        public float ChildBorderSize;
        public float PopupRounding;
        public float PopupBorderSize;
        public Vector2 FramePadding;
        public float FrameRounding;
        public float FrameBorderSize;
        public Vector2 ItemSpacing;
        public Vector2 ItemInnerSpacing;
        public Vector2 TouchExtraPadding;
        public float IndentSpacing;
        public float ColumnsMinSpacing;
        public float ScrollbarSize;
        public float ScrollbarRounding;
        public float GrabMinSize;
        public float GrabRounding;
        public float TabRounding;
        public float TabBorderSize;
        public float TabMinWidthForUnselectedCloseButton;
        public int ColorButtonPosition;
        public Vector2 ButtonTextAlign;
        public Vector2 SelectableTextAlign;
        public Vector2 DisplayWindowPadding;
        public Vector2 DisplaySafeAreaPadding;
        public float MouseCursorScale;
        public bool AntiAliasedLines;
        public bool AntiAliasedFill;
        public float CurveTessellationTol;
        public float CircleSegmentMaxError;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)] public Vector4[] Colors;
    }
}
