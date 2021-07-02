// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

using sg = Sokol.Gfx;

namespace Sokol
{
public static unsafe partial class DebugText
{
public struct Context
{
    public uint Id;
}
public struct Range
{
    public void* Ptr;
    public nuint Size;
}
public struct FontDesc
{
    public Range Data;
    public byte FirstChar;
    public byte LastChar;
}
public struct ContextDesc
{
    public int CharBufSize;
    public float CanvasWidth;
    public float CanvasHeight;
    public int TabWidth;
    public sg.PixelFormat ColorFormat;
    public sg.PixelFormat DepthFormat;
    public int SampleCount;
}
public struct Desc
{
    public int ContextPoolSize;
    public int PrintfBufSize;
    #pragma warning disable 169
    public struct FontsCollection
    {
        public ref FontDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 8)[index];
        private FontDesc _item0;
        private FontDesc _item1;
        private FontDesc _item2;
        private FontDesc _item3;
        private FontDesc _item4;
        private FontDesc _item5;
        private FontDesc _item6;
        private FontDesc _item7;
    }
    #pragma warning restore 169
    public FontsCollection Fonts;
    public ContextDesc Context;
}
[DllImport("sokol", EntryPoint = "sdtx_setup")]
public static extern void Setup(in Desc desc);

[DllImport("sokol", EntryPoint = "sdtx_shutdown")]
public static extern void Shutdown();

[DllImport("sokol", EntryPoint = "sdtx_font_kc853")]
public static extern FontDesc FontKc853();

[DllImport("sokol", EntryPoint = "sdtx_font_kc854")]
public static extern FontDesc FontKc854();

[DllImport("sokol", EntryPoint = "sdtx_font_z1013")]
public static extern FontDesc FontZ1013();

[DllImport("sokol", EntryPoint = "sdtx_font_cpc")]
public static extern FontDesc FontCpc();

[DllImport("sokol", EntryPoint = "sdtx_font_c64")]
public static extern FontDesc FontC64();

[DllImport("sokol", EntryPoint = "sdtx_font_oric")]
public static extern FontDesc FontOric();

[DllImport("sokol", EntryPoint = "sdtx_make_context")]
public static extern Context MakeContext(in ContextDesc desc);

[DllImport("sokol", EntryPoint = "sdtx_destroy_context")]
public static extern void DestroyContext(Context ctx);

[DllImport("sokol", EntryPoint = "sdtx_set_context")]
public static extern void SetContext(Context ctx);

[DllImport("sokol", EntryPoint = "sdtx_get_context")]
public static extern Context GetContext();

[DllImport("sokol", EntryPoint = "sdtx_draw")]
public static extern void Draw();

[DllImport("sokol", EntryPoint = "sdtx_font")]
public static extern void Font(uint font_index);

[DllImport("sokol", EntryPoint = "sdtx_canvas")]
public static extern void Canvas(float w, float h);

[DllImport("sokol", EntryPoint = "sdtx_origin")]
public static extern void Origin(float x, float y);

[DllImport("sokol", EntryPoint = "sdtx_home")]
public static extern void Home();

[DllImport("sokol", EntryPoint = "sdtx_pos")]
public static extern void Pos(float x, float y);

[DllImport("sokol", EntryPoint = "sdtx_pos_x")]
public static extern void PosX(float x);

[DllImport("sokol", EntryPoint = "sdtx_pos_y")]
public static extern void PosY(float y);

[DllImport("sokol", EntryPoint = "sdtx_move")]
public static extern void Move(float dx, float dy);

[DllImport("sokol", EntryPoint = "sdtx_move_x")]
public static extern void MoveX(float dx);

[DllImport("sokol", EntryPoint = "sdtx_move_y")]
public static extern void MoveY(float dy);

[DllImport("sokol", EntryPoint = "sdtx_crlf")]
public static extern void Crlf();

[DllImport("sokol", EntryPoint = "sdtx_color3b")]
public static extern void Color3b(byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sdtx_color3f")]
public static extern void Color3f(float r, float g, float b);

[DllImport("sokol", EntryPoint = "sdtx_color4b")]
public static extern void Color4b(byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sdtx_color4f")]
public static extern void Color4f(float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sdtx_color1i")]
public static extern void Color1i(uint rgba);

[DllImport("sokol", EntryPoint = "sdtx_putc")]
public static extern void Putc(byte c);

[DllImport("sokol", EntryPoint = "sdtx_puts")]
public static extern void Puts([M(U.LPUTF8Str)] string str);

[DllImport("sokol", EntryPoint = "sdtx_putr")]
public static extern void Putr([M(U.LPUTF8Str)] string str, int len);

}
}
