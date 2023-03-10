// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace UI
{
    public static partial class ImGui
    {
        // ../../imgui/examples/imgui_impl_win32.h:14
        [DllImport(Engine.Paths.Exe, EntryPoint = "?ImGui_ImplWin32_Init@@YA_NPEAX@Z")]
        public static extern bool ImGui_ImplWin32_Init(
            IntPtr hwnd
        );

        // ../../imgui/examples/imgui_impl_win32.h:15
        [DllImport(Engine.Paths.Exe, EntryPoint = "?ImGui_ImplWin32_Shutdown@@YAXXZ")]
        public static extern void ImGui_ImplWin32_Shutdown(
        );

        // ../../imgui/examples/imgui_impl_win32.h:16
        [DllImport(Engine.Paths.Exe, EntryPoint = "?ImGui_ImplWin32_NewFrame@@YAXXZ")]
        public static extern void ImGui_ImplWin32_NewFrame(
        );

        // ../../imgui/examples/imgui_impl_win32.h:36
        [DllImport(Engine.Paths.Exe, EntryPoint = "?ImGui_ImplWin32_EnableDpiAwareness@@YAXXZ")]
        public static extern void ImGui_ImplWin32_EnableDpiAwareness(
        );

        // ../../imgui/examples/imgui_impl_win32.h:37
        [DllImport(Engine.Paths.Exe, EntryPoint = "?ImGui_ImplWin32_GetDpiScaleForHwnd@@YAMPEAX@Z")]
        public static extern float ImGui_ImplWin32_GetDpiScaleForHwnd(
            IntPtr hwnd
        );

        // ../../imgui/examples/imgui_impl_win32.h:38
        [DllImport(Engine.Paths.Exe, EntryPoint = "?ImGui_ImplWin32_GetDpiScaleForMonitor@@YAMPEAX@Z")]
        public static extern float ImGui_ImplWin32_GetDpiScaleForMonitor(
            IntPtr monitor
        );

    }
}
