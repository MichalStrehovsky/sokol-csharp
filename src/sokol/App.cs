// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

namespace Sokol
{
public static unsafe partial class App
{
public const int MaxTouchpoints = 8;
public const int MaxMousebuttons = 3;
public const int MaxKeycodes = 512;
public const int MaxIconimages = 8;
public enum EventType
{
    Invalid,
    KeyDown,
    KeyUp,
    Char,
    MouseDown,
    MouseUp,
    MouseScroll,
    MouseMove,
    MouseEnter,
    MouseLeave,
    TouchesBegan,
    TouchesMoved,
    TouchesEnded,
    TouchesCancelled,
    Resized,
    Iconified,
    Restored,
    Suspended,
    Resumed,
    UpdateCursor,
    QuitRequested,
    ClipboardPasted,
    FilesDropped,
    Num,
}
public enum Keycode
{
    Invalid = 0,
    Space = 32,
    Apostrophe = 39,
    Comma = 44,
    Minus = 45,
    Period = 46,
    Slash = 47,
    _0 = 48,
    _1 = 49,
    _2 = 50,
    _3 = 51,
    _4 = 52,
    _5 = 53,
    _6 = 54,
    _7 = 55,
    _8 = 56,
    _9 = 57,
    Semicolon = 59,
    Equal = 61,
    A = 65,
    B = 66,
    C = 67,
    D = 68,
    E = 69,
    F = 70,
    G = 71,
    H = 72,
    I = 73,
    J = 74,
    K = 75,
    L = 76,
    M = 77,
    N = 78,
    O = 79,
    P = 80,
    Q = 81,
    R = 82,
    S = 83,
    T = 84,
    U = 85,
    V = 86,
    W = 87,
    X = 88,
    Y = 89,
    Z = 90,
    LeftBracket = 91,
    Backslash = 92,
    RightBracket = 93,
    GraveAccent = 96,
    World1 = 161,
    World2 = 162,
    Escape = 256,
    Enter = 257,
    Tab = 258,
    Backspace = 259,
    Insert = 260,
    Delete = 261,
    Right = 262,
    Left = 263,
    Down = 264,
    Up = 265,
    PageUp = 266,
    PageDown = 267,
    Home = 268,
    End = 269,
    CapsLock = 280,
    ScrollLock = 281,
    NumLock = 282,
    PrintScreen = 283,
    Pause = 284,
    F1 = 290,
    F2 = 291,
    F3 = 292,
    F4 = 293,
    F5 = 294,
    F6 = 295,
    F7 = 296,
    F8 = 297,
    F9 = 298,
    F10 = 299,
    F11 = 300,
    F12 = 301,
    F13 = 302,
    F14 = 303,
    F15 = 304,
    F16 = 305,
    F17 = 306,
    F18 = 307,
    F19 = 308,
    F20 = 309,
    F21 = 310,
    F22 = 311,
    F23 = 312,
    F24 = 313,
    F25 = 314,
    Kp0 = 320,
    Kp1 = 321,
    Kp2 = 322,
    Kp3 = 323,
    Kp4 = 324,
    Kp5 = 325,
    Kp6 = 326,
    Kp7 = 327,
    Kp8 = 328,
    Kp9 = 329,
    KpDecimal = 330,
    KpDivide = 331,
    KpMultiply = 332,
    KpSubtract = 333,
    KpAdd = 334,
    KpEnter = 335,
    KpEqual = 336,
    LeftShift = 340,
    LeftControl = 341,
    LeftAlt = 342,
    LeftSuper = 343,
    RightShift = 344,
    RightControl = 345,
    RightAlt = 346,
    RightSuper = 347,
    Menu = 348,
}
public struct Touchpoint
{
    public nuint Identifier;
    public float PosX;
    public float PosY;
    [M(U.I1)] public bool Changed;
}
public enum Mousebutton
{
    Left = 0,
    Right = 1,
    Middle = 2,
    Invalid = 256,
}
public const int ModifierShift = 1;
public const int ModifierCtrl = 2;
public const int ModifierAlt = 4;
public const int ModifierSuper = 8;
public const int ModifierLmb = 256;
public const int ModifierRmb = 512;
public const int ModifierMmb = 1024;
public struct Event
{
    public ulong FrameCount;
    public EventType Type;
    public Keycode KeyCode;
    public uint CharCode;
    [M(U.I1)] public bool KeyRepeat;
    public uint Modifiers;
    public Mousebutton MouseButton;
    public float MouseX;
    public float MouseY;
    public float MouseDx;
    public float MouseDy;
    public float ScrollX;
    public float ScrollY;
    public int NumTouches;
    #pragma warning disable 169
    public struct TouchesCollection
    {
        public ref Touchpoint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 8)[index];
        private Touchpoint _item0;
        private Touchpoint _item1;
        private Touchpoint _item2;
        private Touchpoint _item3;
        private Touchpoint _item4;
        private Touchpoint _item5;
        private Touchpoint _item6;
        private Touchpoint _item7;
    }
    #pragma warning restore 169
    public TouchesCollection Touches;
    public int WindowWidth;
    public int WindowHeight;
    public int FramebufferWidth;
    public int FramebufferHeight;
}
public struct Range
{
    public void* Ptr;
    public nuint Size;
}
public struct ImageDesc
{
    public int Width;
    public int Height;
    public Range Pixels;
}
public struct IconDesc
{
    [M(U.I1)] public bool SokolDefault;
    #pragma warning disable 169
    public struct ImagesCollection
    {
        public ref ImageDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 8)[index];
        private ImageDesc _item0;
        private ImageDesc _item1;
        private ImageDesc _item2;
        private ImageDesc _item3;
        private ImageDesc _item4;
        private ImageDesc _item5;
        private ImageDesc _item6;
        private ImageDesc _item7;
    }
    #pragma warning restore 169
    public ImagesCollection Images;
}
public struct Desc
{
    public delegate* unmanaged<void> InitCb;
    public delegate* unmanaged<void> FrameCb;
    public delegate* unmanaged<void> CleanupCb;
    public delegate* unmanaged<Event*, void> EventCb;
    public delegate* unmanaged<byte*, void> FailCb;
    public void* UserData;
    public delegate* unmanaged<void*, void> InitUserdataCb;
    public delegate* unmanaged<void*, void> FrameUserdataCb;
    public delegate* unmanaged<void*, void> CleanupUserdataCb;
    public delegate* unmanaged<Event*, void*, void> EventUserdataCb;
    public delegate* unmanaged<byte*, void*, void> FailUserdataCb;
    public int Width;
    public int Height;
    public int SampleCount;
    public int SwapInterval;
    [M(U.I1)] public bool HighDpi;
    [M(U.I1)] public bool Fullscreen;
    [M(U.I1)] public bool Alpha;
    [M(U.LPUTF8Str)] public string WindowTitle;
    [M(U.I1)] public bool UserCursor;
    [M(U.I1)] public bool EnableClipboard;
    public int ClipboardSize;
    [M(U.I1)] public bool EnableDragndrop;
    public int MaxDroppedFiles;
    public int MaxDroppedFilePathLength;
    public IconDesc Icon;
    [M(U.I1)] public bool GlForceGles2;
    [M(U.I1)] public bool Win32ConsoleUtf8;
    [M(U.I1)] public bool Win32ConsoleCreate;
    [M(U.I1)] public bool Win32ConsoleAttach;
    [M(U.LPUTF8Str)] public string Html5CanvasName;
    [M(U.I1)] public bool Html5CanvasResize;
    [M(U.I1)] public bool Html5PreserveDrawingBuffer;
    [M(U.I1)] public bool Html5PremultipliedAlpha;
    [M(U.I1)] public bool Html5AskLeaveSite;
    [M(U.I1)] public bool IosKeyboardResizesCanvas;
}
public enum Html5FetchError
{
    FetchErrorNoError,
    FetchErrorBufferTooSmall,
    FetchErrorOther,
}
public struct Html5FetchResponse
{
    [M(U.I1)] public bool Succeeded;
    public Html5FetchError ErrorCode;
    public int FileIndex;
    public uint FetchedSize;
    public void* BufferPtr;
    public uint BufferSize;
    public void* UserData;
}
public struct Html5FetchRequest
{
    public int DroppedFileIndex;
    public delegate* unmanaged<Html5FetchResponse*, void> Callback;
    public void* BufferPtr;
    public uint BufferSize;
    public void* UserData;
}
[DllImport("sokol", EntryPoint = "sapp_isvalid")]
public static extern bool IsValid();

[DllImport("sokol", EntryPoint = "sapp_width")]
public static extern int Width();

[DllImport("sokol", EntryPoint = "sapp_widthf")]
public static extern float Widthf();

[DllImport("sokol", EntryPoint = "sapp_height")]
public static extern int Height();

[DllImport("sokol", EntryPoint = "sapp_heightf")]
public static extern float Heightf();

[DllImport("sokol", EntryPoint = "sapp_color_format")]
public static extern int ColorFormat();

[DllImport("sokol", EntryPoint = "sapp_depth_format")]
public static extern int DepthFormat();

[DllImport("sokol", EntryPoint = "sapp_sample_count")]
public static extern int SampleCount();

[DllImport("sokol", EntryPoint = "sapp_high_dpi")]
public static extern bool HighDpi();

[DllImport("sokol", EntryPoint = "sapp_dpi_scale")]
public static extern float DpiScale();

[DllImport("sokol", EntryPoint = "sapp_show_keyboard")]
public static extern void ShowKeyboard(bool show);

[DllImport("sokol", EntryPoint = "sapp_keyboard_shown")]
public static extern bool KeyboardShown();

[DllImport("sokol", EntryPoint = "sapp_is_fullscreen")]
public static extern bool IsFullscreen();

[DllImport("sokol", EntryPoint = "sapp_toggle_fullscreen")]
public static extern void ToggleFullscreen();

[DllImport("sokol", EntryPoint = "sapp_show_mouse")]
public static extern void ShowMouse(bool show);

[DllImport("sokol", EntryPoint = "sapp_mouse_shown")]
public static extern bool MouseShown();

[DllImport("sokol", EntryPoint = "sapp_lock_mouse")]
public static extern void LockMouse(bool dolock);

[DllImport("sokol", EntryPoint = "sapp_mouse_locked")]
public static extern bool MouseLocked();

[DllImport("sokol", EntryPoint = "sapp_userdata")]
public static extern void* Userdata();

[DllImport("sokol", EntryPoint = "sapp_query_desc")]
public static extern Desc QueryDesc();

[DllImport("sokol", EntryPoint = "sapp_request_quit")]
public static extern void RequestQuit();

[DllImport("sokol", EntryPoint = "sapp_cancel_quit")]
public static extern void CancelQuit();

[DllImport("sokol", EntryPoint = "sapp_quit")]
public static extern void Quit();

[DllImport("sokol", EntryPoint = "sapp_consume_event")]
public static extern void ConsumeEvent();

[DllImport("sokol", EntryPoint = "sapp_frame_count")]
public static extern ulong FrameCount();

[DllImport("sokol", EntryPoint = "sapp_set_clipboard_string")]
public static extern void SetClipboardString([M(U.LPUTF8Str)] string str);

[DllImport("sokol", EntryPoint = "sapp_get_clipboard_string")]
[return:M(U.LPUTF8Str)]
public static extern string GetClipboardString();

[DllImport("sokol", EntryPoint = "sapp_set_window_title")]
public static extern void SetWindowTitle([M(U.LPUTF8Str)] string str);

[DllImport("sokol", EntryPoint = "sapp_set_icon")]
public static extern void SetIcon(in IconDesc icon_desc);

[DllImport("sokol", EntryPoint = "sapp_get_num_dropped_files")]
public static extern int GetNumDroppedFiles();

[DllImport("sokol", EntryPoint = "sapp_get_dropped_file_path")]
[return:M(U.LPUTF8Str)]
public static extern string GetDroppedFilePath(int index);

[DllImport("sokol", EntryPoint = "sapp_run")]
public static extern void Run(in Desc desc);

[DllImport("sokol", EntryPoint = "sapp_gles2")]
public static extern bool Gles2();

[DllImport("sokol", EntryPoint = "sapp_html5_ask_leave_site")]
public static extern void Html5AskLeaveSite(bool ask);

[DllImport("sokol", EntryPoint = "sapp_html5_get_dropped_file_size")]
public static extern uint Html5GetDroppedFileSize(int index);

[DllImport("sokol", EntryPoint = "sapp_html5_fetch_dropped_file")]
public static extern void Html5FetchDroppedFile(in Html5FetchRequest request);

[DllImport("sokol", EntryPoint = "sapp_metal_get_device")]
public static extern void* MetalGetDevice();

[DllImport("sokol", EntryPoint = "sapp_metal_get_renderpass_descriptor")]
public static extern void* MetalGetRenderpassDescriptor();

[DllImport("sokol", EntryPoint = "sapp_metal_get_drawable")]
public static extern void* MetalGetDrawable();

[DllImport("sokol", EntryPoint = "sapp_macos_get_window")]
public static extern void* MacosGetWindow();

[DllImport("sokol", EntryPoint = "sapp_ios_get_window")]
public static extern void* IosGetWindow();

[DllImport("sokol", EntryPoint = "sapp_d3d11_get_device")]
public static extern void* D3d11GetDevice();

[DllImport("sokol", EntryPoint = "sapp_d3d11_get_device_context")]
public static extern void* D3d11GetDeviceContext();

[DllImport("sokol", EntryPoint = "sapp_d3d11_get_swap_chain")]
public static extern void* D3d11GetSwapChain();

[DllImport("sokol", EntryPoint = "sapp_d3d11_get_render_target_view")]
public static extern void* D3d11GetRenderTargetView();

[DllImport("sokol", EntryPoint = "sapp_d3d11_get_depth_stencil_view")]
public static extern void* D3d11GetDepthStencilView();

[DllImport("sokol", EntryPoint = "sapp_win32_get_hwnd")]
public static extern void* Win32GetHwnd();

[DllImport("sokol", EntryPoint = "sapp_wgpu_get_device")]
public static extern void* WgpuGetDevice();

[DllImport("sokol", EntryPoint = "sapp_wgpu_get_render_view")]
public static extern void* WgpuGetRenderView();

[DllImport("sokol", EntryPoint = "sapp_wgpu_get_resolve_view")]
public static extern void* WgpuGetResolveView();

[DllImport("sokol", EntryPoint = "sapp_wgpu_get_depth_stencil_view")]
public static extern void* WgpuGetDepthStencilView();

[DllImport("sokol", EntryPoint = "sapp_android_get_native_activity")]
public static extern void* AndroidGetNativeActivity();

}
}
