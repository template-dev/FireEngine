// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace UI
{
    // ../../imgui/imgui.h:2535
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ImGuiPlatformIO
    {

        public IntPtr Platform_CreateWindow;
        public IntPtr Platform_DestroyWindow;
        public IntPtr Platform_ShowWindow;
        public IntPtr Platform_SetWindowPos;
        public IntPtr Platform_GetWindowPos;
        public IntPtr Platform_SetWindowSize;
        public IntPtr Platform_GetWindowSize;
        public IntPtr Platform_SetWindowFocus;
        public IntPtr Platform_GetWindowFocus;
        public IntPtr Platform_GetWindowMinimized;
        public IntPtr Platform_SetWindowTitle;
        public IntPtr Platform_SetWindowAlpha;
        public IntPtr Platform_UpdateWindow;
        public IntPtr Platform_RenderWindow;
        public IntPtr Platform_SwapBuffers;
        public IntPtr Platform_GetWindowDpiScale;
        public IntPtr Platform_OnChangedViewport;
        public IntPtr Platform_SetImeInputPos;
        public IntPtr Platform_CreateVkSurface;
        public IntPtr Renderer_CreateWindow;
        public IntPtr Renderer_DestroyWindow;
        public IntPtr Renderer_SetWindowSize;
        public IntPtr Renderer_RenderWindow;
        public IntPtr Renderer_SwapBuffers;
        public IntPtr Monitors;
        public IntPtr MainViewport;
        public IntPtr Viewports;
    }
}