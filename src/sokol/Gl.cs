// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

using sg = Sokol.Gfx;

namespace Sokol
{
public static unsafe partial class Gl
{
public struct Pipeline
{
    public uint Id;
}
public enum Error
{
    Error = 0,
    VerticesFull,
    UniformsFull,
    CommandsFull,
    StackOverflow,
    StackUnderflow,
}
public struct Desc
{
    public int MaxVertices;
    public int MaxCommands;
    public int PipelinePoolSize;
    public sg.PixelFormat ColorFormat;
    public sg.PixelFormat DepthFormat;
    public int SampleCount;
    public sg.FaceWinding FaceWinding;
}
[DllImport("sokol", EntryPoint = "sgl_setup")]
public static extern void Setup(in Desc desc);

[DllImport("sokol", EntryPoint = "sgl_shutdown")]
public static extern void Shutdown();

[DllImport("sokol", EntryPoint = "sgl_error")]
public static extern Error GetError();

[DllImport("sokol", EntryPoint = "sgl_defaults")]
public static extern void Defaults();

[DllImport("sokol", EntryPoint = "sgl_rad")]
public static extern float AsRadians(float deg);

[DllImport("sokol", EntryPoint = "sgl_deg")]
public static extern float AsDegrees(float rad);

[DllImport("sokol", EntryPoint = "sgl_make_pipeline")]
public static extern Pipeline MakePipeline(in sg.PipelineDesc desc);

[DllImport("sokol", EntryPoint = "sgl_destroy_pipeline")]
public static extern void DestroyPipeline(Pipeline pip);

[DllImport("sokol", EntryPoint = "sgl_viewport")]
public static extern void Viewport(int x, int y, int w, int h, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sgl_viewportf")]
public static extern void Viewportf(float x, float y, float w, float h, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sgl_scissor_rect")]
public static extern void ScissorRect(int x, int y, int w, int h, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sgl_scissor_rectf")]
public static extern void ScissorRectf(float x, float y, float w, float h, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sgl_enable_texture")]
public static extern void EnableTexture();

[DllImport("sokol", EntryPoint = "sgl_disable_texture")]
public static extern void DisableTexture();

[DllImport("sokol", EntryPoint = "sgl_texture")]
public static extern void Texture(sg.Image img);

[DllImport("sokol", EntryPoint = "sgl_default_pipeline")]
public static extern void DefaultPipeline();

[DllImport("sokol", EntryPoint = "sgl_load_pipeline")]
public static extern void LoadPipeline(Pipeline pip);

[DllImport("sokol", EntryPoint = "sgl_push_pipeline")]
public static extern void PushPipeline();

[DllImport("sokol", EntryPoint = "sgl_pop_pipeline")]
public static extern void PopPipeline();

[DllImport("sokol", EntryPoint = "sgl_matrix_mode_modelview")]
public static extern void MatrixModeModelview();

[DllImport("sokol", EntryPoint = "sgl_matrix_mode_projection")]
public static extern void MatrixModeProjection();

[DllImport("sokol", EntryPoint = "sgl_matrix_mode_texture")]
public static extern void MatrixModeTexture();

[DllImport("sokol", EntryPoint = "sgl_load_identity")]
public static extern void LoadIdentity();

[DllImport("sokol", EntryPoint = "sgl_load_matrix")]
public static extern void LoadMatrix(in float m);

[DllImport("sokol", EntryPoint = "sgl_load_transpose_matrix")]
public static extern void LoadTransposeMatrix(in float m);

[DllImport("sokol", EntryPoint = "sgl_mult_matrix")]
public static extern void MultMatrix(in float m);

[DllImport("sokol", EntryPoint = "sgl_mult_transpose_matrix")]
public static extern void MultTransposeMatrix(in float m);

[DllImport("sokol", EntryPoint = "sgl_rotate")]
public static extern void Rotate(float angle_rad, float x, float y, float z);

[DllImport("sokol", EntryPoint = "sgl_scale")]
public static extern void Scale(float x, float y, float z);

[DllImport("sokol", EntryPoint = "sgl_translate")]
public static extern void Translate(float x, float y, float z);

[DllImport("sokol", EntryPoint = "sgl_frustum")]
public static extern void Frustum(float l, float r, float b, float t, float n, float f);

[DllImport("sokol", EntryPoint = "sgl_ortho")]
public static extern void Ortho(float l, float r, float b, float t, float n, float f);

[DllImport("sokol", EntryPoint = "sgl_perspective")]
public static extern void Perspective(float fov_y, float aspect, float z_near, float z_far);

[DllImport("sokol", EntryPoint = "sgl_lookat")]
public static extern void Lookat(float eye_x, float eye_y, float eye_z, float center_x, float center_y, float center_z, float up_x, float up_y, float up_z);

[DllImport("sokol", EntryPoint = "sgl_push_matrix")]
public static extern void PushMatrix();

[DllImport("sokol", EntryPoint = "sgl_pop_matrix")]
public static extern void PopMatrix();

[DllImport("sokol", EntryPoint = "sgl_t2f")]
public static extern void T2f(float u, float v);

[DllImport("sokol", EntryPoint = "sgl_c3f")]
public static extern void C3f(float r, float g, float b);

[DllImport("sokol", EntryPoint = "sgl_c4f")]
public static extern void C4f(float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sgl_c3b")]
public static extern void C3b(byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sgl_c4b")]
public static extern void C4b(byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sgl_c1i")]
public static extern void C1i(uint rgba);

[DllImport("sokol", EntryPoint = "sgl_begin_points")]
public static extern void BeginPoints();

[DllImport("sokol", EntryPoint = "sgl_begin_lines")]
public static extern void BeginLines();

[DllImport("sokol", EntryPoint = "sgl_begin_line_strip")]
public static extern void BeginLineStrip();

[DllImport("sokol", EntryPoint = "sgl_begin_triangles")]
public static extern void BeginTriangles();

[DllImport("sokol", EntryPoint = "sgl_begin_triangle_strip")]
public static extern void BeginTriangleStrip();

[DllImport("sokol", EntryPoint = "sgl_begin_quads")]
public static extern void BeginQuads();

[DllImport("sokol", EntryPoint = "sgl_v2f")]
public static extern void V2f(float x, float y);

[DllImport("sokol", EntryPoint = "sgl_v3f")]
public static extern void V3f(float x, float y, float z);

[DllImport("sokol", EntryPoint = "sgl_v2f_t2f")]
public static extern void V2fT2f(float x, float y, float u, float v);

[DllImport("sokol", EntryPoint = "sgl_v3f_t2f")]
public static extern void V3fT2f(float x, float y, float z, float u, float v);

[DllImport("sokol", EntryPoint = "sgl_v2f_c3f")]
public static extern void V2fC3f(float x, float y, float r, float g, float b);

[DllImport("sokol", EntryPoint = "sgl_v2f_c3b")]
public static extern void V2fC3b(float x, float y, byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sgl_v2f_c4f")]
public static extern void V2fC4f(float x, float y, float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sgl_v2f_c4b")]
public static extern void V2fC4b(float x, float y, byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sgl_v2f_c1i")]
public static extern void V2fC1i(float x, float y, uint rgba);

[DllImport("sokol", EntryPoint = "sgl_v3f_c3f")]
public static extern void V3fC3f(float x, float y, float z, float r, float g, float b);

[DllImport("sokol", EntryPoint = "sgl_v3f_c3b")]
public static extern void V3fC3b(float x, float y, float z, byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sgl_v3f_c4f")]
public static extern void V3fC4f(float x, float y, float z, float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sgl_v3f_c4b")]
public static extern void V3fC4b(float x, float y, float z, byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sgl_v3f_c1i")]
public static extern void V3fC1i(float x, float y, float z, uint rgba);

[DllImport("sokol", EntryPoint = "sgl_v2f_t2f_c3f")]
public static extern void V2fT2fC3f(float x, float y, float u, float v, float r, float g, float b);

[DllImport("sokol", EntryPoint = "sgl_v2f_t2f_c3b")]
public static extern void V2fT2fC3b(float x, float y, float u, float v, byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sgl_v2f_t2f_c4f")]
public static extern void V2fT2fC4f(float x, float y, float u, float v, float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sgl_v2f_t2f_c4b")]
public static extern void V2fT2fC4b(float x, float y, float u, float v, byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sgl_v2f_t2f_c1i")]
public static extern void V2fT2fC1i(float x, float y, float u, float v, uint rgba);

[DllImport("sokol", EntryPoint = "sgl_v3f_t2f_c3f")]
public static extern void V3fT2fC3f(float x, float y, float z, float u, float v, float r, float g, float b);

[DllImport("sokol", EntryPoint = "sgl_v3f_t2f_c3b")]
public static extern void V3fT2fC3b(float x, float y, float z, float u, float v, byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sgl_v3f_t2f_c4f")]
public static extern void V3fT2fC4f(float x, float y, float z, float u, float v, float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sgl_v3f_t2f_c4b")]
public static extern void V3fT2fC4b(float x, float y, float z, float u, float v, byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sgl_v3f_t2f_c1i")]
public static extern void V3fT2fC1i(float x, float y, float z, float u, float v, uint rgba);

[DllImport("sokol", EntryPoint = "sgl_end")]
public static extern void End();

[DllImport("sokol", EntryPoint = "sgl_draw")]
public static extern void Draw();

}
}
