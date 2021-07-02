// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

using sg = Sokol.Gfx;

namespace Sokol
{
public static unsafe partial class Shape
{
public struct Range
{
    public void* Ptr;
    public nuint Size;
}
public struct Mat4
{
    #pragma warning disable 169
    public struct MCollection
    {
        public ref float this[int x, int y] { get { fixed (float* pTP = &_item0) return ref *(pTP + x + (y * 4)); } }
        private float _item0;
        private float _item1;
        private float _item2;
        private float _item3;
        private float _item4;
        private float _item5;
        private float _item6;
        private float _item7;
        private float _item8;
        private float _item9;
        private float _item10;
        private float _item11;
        private float _item12;
        private float _item13;
        private float _item14;
        private float _item15;
    }
    #pragma warning restore 169
    public MCollection M;
}
public struct Vertex
{
    public float X;
    public float Y;
    public float Z;
    public uint Normal;
    public ushort U;
    public ushort V;
    public uint Color;
}
public struct ElementRange
{
    public int BaseElement;
    public int NumElements;
    #pragma warning disable 169
    public struct PadCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 3)[index];
        private uint _item0;
        private uint _item1;
        private uint _item2;
    }
    #pragma warning restore 169
    public PadCollection Pad;
}
public struct SizesItem
{
    public uint Num;
    public uint Size;
    #pragma warning disable 169
    public struct PadCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 3)[index];
        private uint _item0;
        private uint _item1;
        private uint _item2;
    }
    #pragma warning restore 169
    public PadCollection Pad;
}
public struct Sizes
{
    public SizesItem Vertices;
    public SizesItem Indices;
}
public struct BufferItem
{
    public Range Buffer;
    public nuint DataSize;
    public nuint ShapeOffset;
}
public struct Buffer
{
    [M(U.I1)] public bool Valid;
    public BufferItem Vertices;
    public BufferItem Indices;
}
public struct Plane
{
    public float Width;
    public float Depth;
    public ushort Tiles;
    public uint Color;
    [M(U.I1)] public bool RandomColors;
    [M(U.I1)] public bool Merge;
    public Mat4 Transform;
}
public struct Box
{
    public float Width;
    public float Height;
    public float Depth;
    public ushort Tiles;
    public uint Color;
    [M(U.I1)] public bool RandomColors;
    [M(U.I1)] public bool Merge;
    public Mat4 Transform;
}
public struct Sphere
{
    public float Radius;
    public ushort Slices;
    public ushort Stacks;
    public uint Color;
    [M(U.I1)] public bool RandomColors;
    [M(U.I1)] public bool Merge;
    public Mat4 Transform;
}
public struct Cylinder
{
    public float Radius;
    public float Height;
    public ushort Slices;
    public ushort Stacks;
    public uint Color;
    [M(U.I1)] public bool RandomColors;
    [M(U.I1)] public bool Merge;
    public Mat4 Transform;
}
public struct Torus
{
    public float Radius;
    public float RingRadius;
    public ushort Sides;
    public ushort Rings;
    public uint Color;
    [M(U.I1)] public bool RandomColors;
    [M(U.I1)] public bool Merge;
    public Mat4 Transform;
}
[DllImport("sokol", EntryPoint = "sshape_build_plane")]
public static extern Buffer BuildPlane(in Buffer buf, in Plane parameters);

[DllImport("sokol", EntryPoint = "sshape_build_box")]
public static extern Buffer BuildBox(in Buffer buf, in Box parameters);

[DllImport("sokol", EntryPoint = "sshape_build_sphere")]
public static extern Buffer BuildSphere(in Buffer buf, in Sphere parameters);

[DllImport("sokol", EntryPoint = "sshape_build_cylinder")]
public static extern Buffer BuildCylinder(in Buffer buf, in Cylinder parameters);

[DllImport("sokol", EntryPoint = "sshape_build_torus")]
public static extern Buffer BuildTorus(in Buffer buf, in Torus parameters);

[DllImport("sokol", EntryPoint = "sshape_plane_sizes")]
public static extern Sizes PlaneSizes(uint tiles);

[DllImport("sokol", EntryPoint = "sshape_box_sizes")]
public static extern Sizes BoxSizes(uint tiles);

[DllImport("sokol", EntryPoint = "sshape_sphere_sizes")]
public static extern Sizes SphereSizes(uint slices, uint stacks);

[DllImport("sokol", EntryPoint = "sshape_cylinder_sizes")]
public static extern Sizes CylinderSizes(uint slices, uint stacks);

[DllImport("sokol", EntryPoint = "sshape_torus_sizes")]
public static extern Sizes TorusSizes(uint sides, uint rings);

[DllImport("sokol", EntryPoint = "sshape_element_range")]
public static extern ElementRange MakeElementRange(in Buffer buf);

[DllImport("sokol", EntryPoint = "sshape_vertex_buffer_desc")]
public static extern sg.BufferDesc VertexBufferDesc(in Buffer buf);

[DllImport("sokol", EntryPoint = "sshape_index_buffer_desc")]
public static extern sg.BufferDesc IndexBufferDesc(in Buffer buf);

[DllImport("sokol", EntryPoint = "sshape_buffer_layout_desc")]
public static extern sg.BufferLayoutDesc BufferLayoutDesc();

[DllImport("sokol", EntryPoint = "sshape_position_attr_desc")]
public static extern sg.VertexAttrDesc PositionAttrDesc();

[DllImport("sokol", EntryPoint = "sshape_normal_attr_desc")]
public static extern sg.VertexAttrDesc NormalAttrDesc();

[DllImport("sokol", EntryPoint = "sshape_texcoord_attr_desc")]
public static extern sg.VertexAttrDesc TexcoordAttrDesc();

[DllImport("sokol", EntryPoint = "sshape_color_attr_desc")]
public static extern sg.VertexAttrDesc ColorAttrDesc();

[DllImport("sokol", EntryPoint = "sshape_color_4f")]
public static extern uint Color4f(float r, float g, float b, float a);

[DllImport("sokol", EntryPoint = "sshape_color_3f")]
public static extern uint Color3f(float r, float g, float b);

[DllImport("sokol", EntryPoint = "sshape_color_4b")]
public static extern uint Color4b(byte r, byte g, byte b, byte a);

[DllImport("sokol", EntryPoint = "sshape_color_3b")]
public static extern uint Color3b(byte r, byte g, byte b);

[DllImport("sokol", EntryPoint = "sshape_mat4")]
public static extern Mat4 MakeMat4(in float m);

[DllImport("sokol", EntryPoint = "sshape_mat4_transpose")]
public static extern Mat4 Mat4Transpose(in float m);

}
}
