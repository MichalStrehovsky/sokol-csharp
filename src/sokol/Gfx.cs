// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

namespace Sokol
{
public static unsafe partial class Gfx
{
public struct Buffer
{
    public uint Id;
}
public struct Image
{
    public uint Id;
}
public struct Shader
{
    public uint Id;
}
public struct Pipeline
{
    public uint Id;
}
public struct Pass
{
    public uint Id;
}
public struct Context
{
    public uint Id;
}
public struct Range
{
    public void* Ptr;
    public nuint Size;
}
public const int InvalidId = 0;
public const int NumShaderStages = 2;
public const int NumInflightFrames = 2;
public const int MaxColorAttachments = 4;
public const int MaxShaderstageBuffers = 8;
public const int MaxShaderstageImages = 12;
public const int MaxShaderstageUbs = 4;
public const int MaxUbMembers = 16;
public const int MaxVertexAttributes = 16;
public const int MaxMipmaps = 16;
public const int MaxTexturearrayLayers = 128;
public struct Color
{
    public float R;
    public float G;
    public float B;
    public float A;
}
public enum Backend
{
    Glcore33,
    Gles2,
    Gles3,
    D3d11,
    MetalIos,
    MetalMacos,
    MetalSimulator,
    Wgpu,
    Dummy,
}
public enum PixelFormat
{
    Default,
    None,
    R8,
    R8sn,
    R8ui,
    R8si,
    R16,
    R16sn,
    R16ui,
    R16si,
    R16f,
    Rg8,
    Rg8sn,
    Rg8ui,
    Rg8si,
    R32ui,
    R32si,
    R32f,
    Rg16,
    Rg16sn,
    Rg16ui,
    Rg16si,
    Rg16f,
    Rgba8,
    Rgba8sn,
    Rgba8ui,
    Rgba8si,
    Bgra8,
    Rgb10a2,
    Rg11b10f,
    Rg32ui,
    Rg32si,
    Rg32f,
    Rgba16,
    Rgba16sn,
    Rgba16ui,
    Rgba16si,
    Rgba16f,
    Rgba32ui,
    Rgba32si,
    Rgba32f,
    Depth,
    DepthStencil,
    Bc1Rgba,
    Bc2Rgba,
    Bc3Rgba,
    Bc4R,
    Bc4Rsn,
    Bc5Rg,
    Bc5Rgsn,
    Bc6hRgbf,
    Bc6hRgbuf,
    Bc7Rgba,
    PvrtcRgb2bpp,
    PvrtcRgb4bpp,
    PvrtcRgba2bpp,
    PvrtcRgba4bpp,
    Etc2Rgb8,
    Etc2Rgb8a1,
    Etc2Rgba8,
    Etc2Rg11,
    Etc2Rg11sn,
    Num,
}
public struct PixelformatInfo
{
    [M(U.I1)] public bool Sample;
    [M(U.I1)] public bool Filter;
    [M(U.I1)] public bool Render;
    [M(U.I1)] public bool Blend;
    [M(U.I1)] public bool Msaa;
    [M(U.I1)] public bool Depth;
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
public struct Features
{
    [M(U.I1)] public bool Instancing;
    [M(U.I1)] public bool OriginTopLeft;
    [M(U.I1)] public bool MultipleRenderTargets;
    [M(U.I1)] public bool MsaaRenderTargets;
    [M(U.I1)] public bool Imagetype3d;
    [M(U.I1)] public bool ImagetypeArray;
    [M(U.I1)] public bool ImageClampToBorder;
    [M(U.I1)] public bool MrtIndependentBlendState;
    [M(U.I1)] public bool MrtIndependentWriteMask;
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
public struct Limits
{
    public int MaxImageSize2d;
    public int MaxImageSizeCube;
    public int MaxImageSize3d;
    public int MaxImageSizeArray;
    public int MaxImageArrayLayers;
    public int MaxVertexAttrs;
    public int GlMaxVertexUniformVectors;
}
public enum ResourceState
{
    Initial,
    Alloc,
    Valid,
    Failed,
    Invalid,
}
public enum Usage
{
    Default,
    Immutable,
    Dynamic,
    Stream,
    Num,
}
public enum BufferType
{
    Default,
    Vertexbuffer,
    Indexbuffer,
    Num,
}
public enum IndexType
{
    Default,
    None,
    Uint16,
    Uint32,
    Num,
}
public enum ImageType
{
    Default,
    _2d,
    Cube,
    _3d,
    Array,
    Num,
}
public enum SamplerType
{
    Default,
    Float,
    Sint,
    Uint,
}
public enum CubeFace
{
    PosX,
    NegX,
    PosY,
    NegY,
    PosZ,
    NegZ,
    Num,
}
public enum ShaderStage
{
    Vs,
    Fs,
}
public enum PrimitiveType
{
    Default,
    Points,
    Lines,
    LineStrip,
    Triangles,
    TriangleStrip,
    Num,
}
public enum Filter
{
    Default,
    Nearest,
    Linear,
    NearestMipmapNearest,
    NearestMipmapLinear,
    LinearMipmapNearest,
    LinearMipmapLinear,
    Num,
}
public enum Wrap
{
    Default,
    Repeat,
    ClampToEdge,
    ClampToBorder,
    MirroredRepeat,
    Num,
}
public enum BorderColor
{
    Default,
    TransparentBlack,
    OpaqueBlack,
    OpaqueWhite,
    Num,
}
public enum VertexFormat
{
    Invalid,
    Float,
    Float2,
    Float3,
    Float4,
    Byte4,
    Byte4n,
    Ubyte4,
    Ubyte4n,
    Short2,
    Short2n,
    Ushort2n,
    Short4,
    Short4n,
    Ushort4n,
    Uint10N2,
    Num,
}
public enum VertexStep
{
    Default,
    PerVertex,
    PerInstance,
    Num,
}
public enum UniformType
{
    Invalid,
    Float,
    Float2,
    Float3,
    Float4,
    Mat4,
    Num,
}
public enum CullMode
{
    Default,
    None,
    Front,
    Back,
    Num,
}
public enum FaceWinding
{
    Default,
    Ccw,
    Cw,
    Num,
}
public enum CompareFunc
{
    Default,
    Never,
    Less,
    Equal,
    LessEqual,
    Greater,
    NotEqual,
    GreaterEqual,
    Always,
    Num,
}
public enum StencilOp
{
    Default,
    Keep,
    Zero,
    Replace,
    IncrClamp,
    DecrClamp,
    Invert,
    IncrWrap,
    DecrWrap,
    Num,
}
public enum BlendFactor
{
    Default,
    Zero,
    One,
    SrcColor,
    OneMinusSrcColor,
    SrcAlpha,
    OneMinusSrcAlpha,
    DstColor,
    OneMinusDstColor,
    DstAlpha,
    OneMinusDstAlpha,
    SrcAlphaSaturated,
    BlendColor,
    OneMinusBlendColor,
    BlendAlpha,
    OneMinusBlendAlpha,
    Num,
}
public enum BlendOp
{
    Default,
    Add,
    Subtract,
    ReverseSubtract,
    Num,
}
public enum ColorMask
{
    Default = 0,
    None = 16,
    R = 1,
    G = 2,
    Rg = 3,
    B = 4,
    Rb = 5,
    Gb = 6,
    Rgb = 7,
    A = 8,
    Ra = 9,
    Ga = 10,
    Rga = 11,
    Ba = 12,
    Rba = 13,
    Gba = 14,
    Rgba = 15,
}
public enum Action
{
    Default,
    Clear,
    Load,
    Dontcare,
    Num,
}
public struct ColorAttachmentAction
{
    public Action Action;
    public Color Value;
}
public struct DepthAttachmentAction
{
    public Action Action;
    public float Value;
}
public struct StencilAttachmentAction
{
    public Action Action;
    public byte Value;
}
public struct PassAction
{
    public uint StartCanary;
    #pragma warning disable 169
    public struct ColorsCollection
    {
        public ref ColorAttachmentAction this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 4)[index];
        private ColorAttachmentAction _item0;
        private ColorAttachmentAction _item1;
        private ColorAttachmentAction _item2;
        private ColorAttachmentAction _item3;
    }
    #pragma warning restore 169
    public ColorsCollection Colors;
    public DepthAttachmentAction Depth;
    public StencilAttachmentAction Stencil;
    public uint EndCanary;
}
public struct Bindings
{
    public uint StartCanary;
    #pragma warning disable 169
    public struct VertexBuffersCollection
    {
        public ref Buffer this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 8)[index];
        private Buffer _item0;
        private Buffer _item1;
        private Buffer _item2;
        private Buffer _item3;
        private Buffer _item4;
        private Buffer _item5;
        private Buffer _item6;
        private Buffer _item7;
    }
    #pragma warning restore 169
    public VertexBuffersCollection VertexBuffers;
    #pragma warning disable 169
    public struct VertexBufferOffsetsCollection
    {
        public ref int this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 8)[index];
        private int _item0;
        private int _item1;
        private int _item2;
        private int _item3;
        private int _item4;
        private int _item5;
        private int _item6;
        private int _item7;
    }
    #pragma warning restore 169
    public VertexBufferOffsetsCollection VertexBufferOffsets;
    public Buffer IndexBuffer;
    public int IndexBufferOffset;
    #pragma warning disable 169
    public struct VsImagesCollection
    {
        public ref Image this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 12)[index];
        private Image _item0;
        private Image _item1;
        private Image _item2;
        private Image _item3;
        private Image _item4;
        private Image _item5;
        private Image _item6;
        private Image _item7;
        private Image _item8;
        private Image _item9;
        private Image _item10;
        private Image _item11;
    }
    #pragma warning restore 169
    public VsImagesCollection VsImages;
    #pragma warning disable 169
    public struct FsImagesCollection
    {
        public ref Image this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 12)[index];
        private Image _item0;
        private Image _item1;
        private Image _item2;
        private Image _item3;
        private Image _item4;
        private Image _item5;
        private Image _item6;
        private Image _item7;
        private Image _item8;
        private Image _item9;
        private Image _item10;
        private Image _item11;
    }
    #pragma warning restore 169
    public FsImagesCollection FsImages;
    public uint EndCanary;
}
public struct BufferDesc
{
    public uint StartCanary;
    public nuint Size;
    public BufferType Type;
    public Usage Usage;
    public Range Data;
    [M(U.LPUTF8Str)] public string Label;
    #pragma warning disable 169
    public struct GlBuffersCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private uint _item0;
        private uint _item1;
    }
    #pragma warning restore 169
    public GlBuffersCollection GlBuffers;
    #pragma warning disable 169
    public struct MtlBuffersCollection
    {
        public ref IntPtr this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private IntPtr _item0;
        private IntPtr _item1;
    }
    #pragma warning restore 169
    public MtlBuffersCollection MtlBuffers;
    public void* D3d11Buffer;
    public void* WgpuBuffer;
    public uint EndCanary;
}
public struct ImageData
{
    #pragma warning disable 169
    public struct SubimageCollection
    {
        public ref Range this[int x, int y] { get { fixed (Range* pTP = &_item0) return ref *(pTP + x + (y * 6)); } }
        private Range _item0;
        private Range _item1;
        private Range _item2;
        private Range _item3;
        private Range _item4;
        private Range _item5;
        private Range _item6;
        private Range _item7;
        private Range _item8;
        private Range _item9;
        private Range _item10;
        private Range _item11;
        private Range _item12;
        private Range _item13;
        private Range _item14;
        private Range _item15;
        private Range _item16;
        private Range _item17;
        private Range _item18;
        private Range _item19;
        private Range _item20;
        private Range _item21;
        private Range _item22;
        private Range _item23;
        private Range _item24;
        private Range _item25;
        private Range _item26;
        private Range _item27;
        private Range _item28;
        private Range _item29;
        private Range _item30;
        private Range _item31;
        private Range _item32;
        private Range _item33;
        private Range _item34;
        private Range _item35;
        private Range _item36;
        private Range _item37;
        private Range _item38;
        private Range _item39;
        private Range _item40;
        private Range _item41;
        private Range _item42;
        private Range _item43;
        private Range _item44;
        private Range _item45;
        private Range _item46;
        private Range _item47;
        private Range _item48;
        private Range _item49;
        private Range _item50;
        private Range _item51;
        private Range _item52;
        private Range _item53;
        private Range _item54;
        private Range _item55;
        private Range _item56;
        private Range _item57;
        private Range _item58;
        private Range _item59;
        private Range _item60;
        private Range _item61;
        private Range _item62;
        private Range _item63;
        private Range _item64;
        private Range _item65;
        private Range _item66;
        private Range _item67;
        private Range _item68;
        private Range _item69;
        private Range _item70;
        private Range _item71;
        private Range _item72;
        private Range _item73;
        private Range _item74;
        private Range _item75;
        private Range _item76;
        private Range _item77;
        private Range _item78;
        private Range _item79;
        private Range _item80;
        private Range _item81;
        private Range _item82;
        private Range _item83;
        private Range _item84;
        private Range _item85;
        private Range _item86;
        private Range _item87;
        private Range _item88;
        private Range _item89;
        private Range _item90;
        private Range _item91;
        private Range _item92;
        private Range _item93;
        private Range _item94;
        private Range _item95;
    }
    #pragma warning restore 169
    public SubimageCollection Subimage;
}
public struct ImageDesc
{
    public uint StartCanary;
    public ImageType Type;
    [M(U.I1)] public bool RenderTarget;
    public int Width;
    public int Height;
    public int NumSlices;
    public int NumMipmaps;
    public Usage Usage;
    public PixelFormat PixelFormat;
    public int SampleCount;
    public Filter MinFilter;
    public Filter MagFilter;
    public Wrap WrapU;
    public Wrap WrapV;
    public Wrap WrapW;
    public BorderColor BorderColor;
    public uint MaxAnisotropy;
    public float MinLod;
    public float MaxLod;
    public ImageData Data;
    [M(U.LPUTF8Str)] public string Label;
    #pragma warning disable 169
    public struct GlTexturesCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private uint _item0;
        private uint _item1;
    }
    #pragma warning restore 169
    public GlTexturesCollection GlTextures;
    public uint GlTextureTarget;
    #pragma warning disable 169
    public struct MtlTexturesCollection
    {
        public ref IntPtr this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private IntPtr _item0;
        private IntPtr _item1;
    }
    #pragma warning restore 169
    public MtlTexturesCollection MtlTextures;
    public void* D3d11Texture;
    public void* D3d11ShaderResourceView;
    public void* WgpuTexture;
    public uint EndCanary;
}
public struct ShaderAttrDesc
{
    [M(U.LPUTF8Str)] public string Name;
    [M(U.LPUTF8Str)] public string SemName;
    public int SemIndex;
}
public struct ShaderUniformDesc
{
    [M(U.LPUTF8Str)] public string Name;
    public UniformType Type;
    public int ArrayCount;
}
public struct ShaderUniformBlockDesc
{
    public nuint Size;
    #pragma warning disable 169
    public struct UniformsCollection
    {
        public ref ShaderUniformDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 16)[index];
        private ShaderUniformDesc _item0;
        private ShaderUniformDesc _item1;
        private ShaderUniformDesc _item2;
        private ShaderUniformDesc _item3;
        private ShaderUniformDesc _item4;
        private ShaderUniformDesc _item5;
        private ShaderUniformDesc _item6;
        private ShaderUniformDesc _item7;
        private ShaderUniformDesc _item8;
        private ShaderUniformDesc _item9;
        private ShaderUniformDesc _item10;
        private ShaderUniformDesc _item11;
        private ShaderUniformDesc _item12;
        private ShaderUniformDesc _item13;
        private ShaderUniformDesc _item14;
        private ShaderUniformDesc _item15;
    }
    #pragma warning restore 169
    public UniformsCollection Uniforms;
}
public struct ShaderImageDesc
{
    [M(U.LPUTF8Str)] public string Name;
    public ImageType ImageType;
    public SamplerType SamplerType;
}
public struct ShaderStageDesc
{
    [M(U.LPUTF8Str)] public string Source;
    public Range Bytecode;
    [M(U.LPUTF8Str)] public string Entry;
    [M(U.LPUTF8Str)] public string D3d11Target;
    #pragma warning disable 169
    public struct UniformBlocksCollection
    {
        public ref ShaderUniformBlockDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 4)[index];
        private ShaderUniformBlockDesc _item0;
        private ShaderUniformBlockDesc _item1;
        private ShaderUniformBlockDesc _item2;
        private ShaderUniformBlockDesc _item3;
    }
    #pragma warning restore 169
    public UniformBlocksCollection UniformBlocks;
    #pragma warning disable 169
    public struct ImagesCollection
    {
        public ref ShaderImageDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 12)[index];
        private ShaderImageDesc _item0;
        private ShaderImageDesc _item1;
        private ShaderImageDesc _item2;
        private ShaderImageDesc _item3;
        private ShaderImageDesc _item4;
        private ShaderImageDesc _item5;
        private ShaderImageDesc _item6;
        private ShaderImageDesc _item7;
        private ShaderImageDesc _item8;
        private ShaderImageDesc _item9;
        private ShaderImageDesc _item10;
        private ShaderImageDesc _item11;
    }
    #pragma warning restore 169
    public ImagesCollection Images;
}
public struct ShaderDesc
{
    public uint StartCanary;
    #pragma warning disable 169
    public struct AttrsCollection
    {
        public ref ShaderAttrDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 16)[index];
        private ShaderAttrDesc _item0;
        private ShaderAttrDesc _item1;
        private ShaderAttrDesc _item2;
        private ShaderAttrDesc _item3;
        private ShaderAttrDesc _item4;
        private ShaderAttrDesc _item5;
        private ShaderAttrDesc _item6;
        private ShaderAttrDesc _item7;
        private ShaderAttrDesc _item8;
        private ShaderAttrDesc _item9;
        private ShaderAttrDesc _item10;
        private ShaderAttrDesc _item11;
        private ShaderAttrDesc _item12;
        private ShaderAttrDesc _item13;
        private ShaderAttrDesc _item14;
        private ShaderAttrDesc _item15;
    }
    #pragma warning restore 169
    public AttrsCollection Attrs;
    public ShaderStageDesc Vs;
    public ShaderStageDesc Fs;
    [M(U.LPUTF8Str)] public string Label;
    public uint EndCanary;
}
public struct BufferLayoutDesc
{
    public int Stride;
    public VertexStep StepFunc;
    public int StepRate;
    #pragma warning disable 169
    public struct PadCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private uint _item0;
        private uint _item1;
    }
    #pragma warning restore 169
    public PadCollection Pad;
}
public struct VertexAttrDesc
{
    public int BufferIndex;
    public int Offset;
    public VertexFormat Format;
    #pragma warning disable 169
    public struct PadCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private uint _item0;
        private uint _item1;
    }
    #pragma warning restore 169
    public PadCollection Pad;
}
public struct LayoutDesc
{
    #pragma warning disable 169
    public struct BuffersCollection
    {
        public ref BufferLayoutDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 8)[index];
        private BufferLayoutDesc _item0;
        private BufferLayoutDesc _item1;
        private BufferLayoutDesc _item2;
        private BufferLayoutDesc _item3;
        private BufferLayoutDesc _item4;
        private BufferLayoutDesc _item5;
        private BufferLayoutDesc _item6;
        private BufferLayoutDesc _item7;
    }
    #pragma warning restore 169
    public BuffersCollection Buffers;
    #pragma warning disable 169
    public struct AttrsCollection
    {
        public ref VertexAttrDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 16)[index];
        private VertexAttrDesc _item0;
        private VertexAttrDesc _item1;
        private VertexAttrDesc _item2;
        private VertexAttrDesc _item3;
        private VertexAttrDesc _item4;
        private VertexAttrDesc _item5;
        private VertexAttrDesc _item6;
        private VertexAttrDesc _item7;
        private VertexAttrDesc _item8;
        private VertexAttrDesc _item9;
        private VertexAttrDesc _item10;
        private VertexAttrDesc _item11;
        private VertexAttrDesc _item12;
        private VertexAttrDesc _item13;
        private VertexAttrDesc _item14;
        private VertexAttrDesc _item15;
    }
    #pragma warning restore 169
    public AttrsCollection Attrs;
}
public struct StencilFaceState
{
    public CompareFunc Compare;
    public StencilOp FailOp;
    public StencilOp DepthFailOp;
    public StencilOp PassOp;
}
public struct StencilState
{
    [M(U.I1)] public bool Enabled;
    public StencilFaceState Front;
    public StencilFaceState Back;
    public byte ReadMask;
    public byte WriteMask;
    public byte Ref;
}
public struct DepthState
{
    public PixelFormat PixelFormat;
    public CompareFunc Compare;
    [M(U.I1)] public bool WriteEnabled;
    public float Bias;
    public float BiasSlopeScale;
    public float BiasClamp;
}
public struct BlendState
{
    [M(U.I1)] public bool Enabled;
    public BlendFactor SrcFactorRgb;
    public BlendFactor DstFactorRgb;
    public BlendOp OpRgb;
    public BlendFactor SrcFactorAlpha;
    public BlendFactor DstFactorAlpha;
    public BlendOp OpAlpha;
}
public struct ColorState
{
    public PixelFormat PixelFormat;
    public ColorMask WriteMask;
    public BlendState Blend;
}
public struct PipelineDesc
{
    public uint StartCanary;
    public Shader Shader;
    public LayoutDesc Layout;
    public DepthState Depth;
    public StencilState Stencil;
    public int ColorCount;
    #pragma warning disable 169
    public struct ColorsCollection
    {
        public ref ColorState this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 4)[index];
        private ColorState _item0;
        private ColorState _item1;
        private ColorState _item2;
        private ColorState _item3;
    }
    #pragma warning restore 169
    public ColorsCollection Colors;
    public PrimitiveType PrimitiveType;
    public IndexType IndexType;
    public CullMode CullMode;
    public FaceWinding FaceWinding;
    public int SampleCount;
    public Color BlendColor;
    [M(U.I1)] public bool AlphaToCoverageEnabled;
    [M(U.LPUTF8Str)] public string Label;
    public uint EndCanary;
}
public struct PassAttachmentDesc
{
    public Image Image;
    public int MipLevel;
    public int Slice;
}
public struct PassDesc
{
    public uint StartCanary;
    #pragma warning disable 169
    public struct ColorAttachmentsCollection
    {
        public ref PassAttachmentDesc this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 4)[index];
        private PassAttachmentDesc _item0;
        private PassAttachmentDesc _item1;
        private PassAttachmentDesc _item2;
        private PassAttachmentDesc _item3;
    }
    #pragma warning restore 169
    public ColorAttachmentsCollection ColorAttachments;
    public PassAttachmentDesc DepthStencilAttachment;
    [M(U.LPUTF8Str)] public string Label;
    public uint EndCanary;
}
public struct SlotInfo
{
    public ResourceState State;
    public uint ResId;
    public uint CtxId;
}
public struct BufferInfo
{
    public SlotInfo Slot;
    public uint UpdateFrameIndex;
    public uint AppendFrameIndex;
    public int AppendPos;
    [M(U.I1)] public bool AppendOverflow;
    public int NumSlots;
    public int ActiveSlot;
}
public struct ImageInfo
{
    public SlotInfo Slot;
    public uint UpdFrameIndex;
    public int NumSlots;
    public int ActiveSlot;
    public int Width;
    public int Height;
}
public struct ShaderInfo
{
    public SlotInfo Slot;
}
public struct PipelineInfo
{
    public SlotInfo Slot;
}
public struct PassInfo
{
    public SlotInfo Slot;
}
public struct GlContextDesc
{
    [M(U.I1)] public bool ForceGles2;
}
public struct MetalContextDesc
{
    public void* Device;
    public delegate* unmanaged<void*> RenderpassDescriptorCb;
    public delegate* unmanaged<void*, void*> RenderpassDescriptorUserdataCb;
    public delegate* unmanaged<void*> DrawableCb;
    public delegate* unmanaged<void*, void*> DrawableUserdataCb;
    public void* UserData;
}
public struct D3d11ContextDesc
{
    public void* Device;
    public void* DeviceContext;
    public delegate* unmanaged<void*> RenderTargetViewCb;
    public delegate* unmanaged<void*, void*> RenderTargetViewUserdataCb;
    public delegate* unmanaged<void*> DepthStencilViewCb;
    public delegate* unmanaged<void*, void*> DepthStencilViewUserdataCb;
    public void* UserData;
}
public struct WgpuContextDesc
{
    public void* Device;
    public delegate* unmanaged<void*> RenderViewCb;
    public delegate* unmanaged<void*, void*> RenderViewUserdataCb;
    public delegate* unmanaged<void*> ResolveViewCb;
    public delegate* unmanaged<void*, void*> ResolveViewUserdataCb;
    public delegate* unmanaged<void*> DepthStencilViewCb;
    public delegate* unmanaged<void*, void*> DepthStencilViewUserdataCb;
    public void* UserData;
}
public struct ContextDesc
{
    public PixelFormat ColorFormat;
    public PixelFormat DepthFormat;
    public int SampleCount;
    public GlContextDesc Gl;
    public MetalContextDesc Metal;
    public D3d11ContextDesc D3d11;
    public WgpuContextDesc Wgpu;
}
public struct Desc
{
    public uint StartCanary;
    public int BufferPoolSize;
    public int ImagePoolSize;
    public int ShaderPoolSize;
    public int PipelinePoolSize;
    public int PassPoolSize;
    public int ContextPoolSize;
    public int UniformBufferSize;
    public int StagingBufferSize;
    public int SamplerCacheSize;
    public ContextDesc Context;
    public uint EndCanary;
}
[DllImport("sokol", EntryPoint = "sg_setup")]
public static extern void Setup(in Desc desc);

[DllImport("sokol", EntryPoint = "sg_shutdown")]
public static extern void Shutdown();

[DllImport("sokol", EntryPoint = "sg_isvalid")]
public static extern bool Isvalid();

[DllImport("sokol", EntryPoint = "sg_reset_state_cache")]
public static extern void ResetStateCache();

[DllImport("sokol", EntryPoint = "sg_push_debug_group")]
public static extern void PushDebugGroup([M(U.LPUTF8Str)] string name);

[DllImport("sokol", EntryPoint = "sg_pop_debug_group")]
public static extern void PopDebugGroup();

[DllImport("sokol", EntryPoint = "sg_make_buffer")]
public static extern Buffer MakeBuffer(in BufferDesc desc);

[DllImport("sokol", EntryPoint = "sg_make_image")]
public static extern Image MakeImage(in ImageDesc desc);

[DllImport("sokol", EntryPoint = "sg_make_shader")]
public static extern Shader MakeShader(in ShaderDesc desc);

[DllImport("sokol", EntryPoint = "sg_make_pipeline")]
public static extern Pipeline MakePipeline(in PipelineDesc desc);

[DllImport("sokol", EntryPoint = "sg_make_pass")]
public static extern Pass MakePass(in PassDesc desc);

[DllImport("sokol", EntryPoint = "sg_destroy_buffer")]
public static extern void DestroyBuffer(Buffer buf);

[DllImport("sokol", EntryPoint = "sg_destroy_image")]
public static extern void DestroyImage(Image img);

[DllImport("sokol", EntryPoint = "sg_destroy_shader")]
public static extern void DestroyShader(Shader shd);

[DllImport("sokol", EntryPoint = "sg_destroy_pipeline")]
public static extern void DestroyPipeline(Pipeline pip);

[DllImport("sokol", EntryPoint = "sg_destroy_pass")]
public static extern void DestroyPass(Pass pass);

[DllImport("sokol", EntryPoint = "sg_update_buffer")]
public static extern void UpdateBuffer(Buffer buf, in Range data);

[DllImport("sokol", EntryPoint = "sg_update_image")]
public static extern void UpdateImage(Image img, in ImageData data);

[DllImport("sokol", EntryPoint = "sg_append_buffer")]
public static extern int AppendBuffer(Buffer buf, in Range data);

[DllImport("sokol", EntryPoint = "sg_query_buffer_overflow")]
public static extern bool QueryBufferOverflow(Buffer buf);

[DllImport("sokol", EntryPoint = "sg_begin_default_pass")]
public static extern void BeginDefaultPass(in PassAction pass_action, int width, int height);

[DllImport("sokol", EntryPoint = "sg_begin_default_passf")]
public static extern void BeginDefaultPassf(in PassAction pass_action, float width, float height);

[DllImport("sokol", EntryPoint = "sg_begin_pass")]
public static extern void BeginPass(Pass pass, in PassAction pass_action);

[DllImport("sokol", EntryPoint = "sg_apply_viewport")]
public static extern void ApplyViewport(int x, int y, int width, int height, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sg_apply_viewportf")]
public static extern void ApplyViewportf(float x, float y, float width, float height, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sg_apply_scissor_rect")]
public static extern void ApplyScissorRect(int x, int y, int width, int height, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sg_apply_scissor_rectf")]
public static extern void ApplyScissorRectf(float x, float y, float width, float height, bool origin_top_left);

[DllImport("sokol", EntryPoint = "sg_apply_pipeline")]
public static extern void ApplyPipeline(Pipeline pip);

[DllImport("sokol", EntryPoint = "sg_apply_bindings")]
public static extern void ApplyBindings(in Bindings bindings);

[DllImport("sokol", EntryPoint = "sg_apply_uniforms")]
public static extern void ApplyUniforms(ShaderStage stage, uint ub_index, in Range data);

[DllImport("sokol", EntryPoint = "sg_draw")]
public static extern void Draw(uint base_element, uint num_elements, uint num_instances);

[DllImport("sokol", EntryPoint = "sg_end_pass")]
public static extern void EndPass();

[DllImport("sokol", EntryPoint = "sg_commit")]
public static extern void Commit();

[DllImport("sokol", EntryPoint = "sg_query_desc")]
public static extern Desc QueryDesc();

[DllImport("sokol", EntryPoint = "sg_query_backend")]
public static extern Backend QueryBackend();

[DllImport("sokol", EntryPoint = "sg_query_features")]
public static extern Features QueryFeatures();

[DllImport("sokol", EntryPoint = "sg_query_limits")]
public static extern Limits QueryLimits();

[DllImport("sokol", EntryPoint = "sg_query_pixelformat")]
public static extern PixelformatInfo QueryPixelformat(PixelFormat fmt);

[DllImport("sokol", EntryPoint = "sg_query_buffer_state")]
public static extern ResourceState QueryBufferState(Buffer buf);

[DllImport("sokol", EntryPoint = "sg_query_image_state")]
public static extern ResourceState QueryImageState(Image img);

[DllImport("sokol", EntryPoint = "sg_query_shader_state")]
public static extern ResourceState QueryShaderState(Shader shd);

[DllImport("sokol", EntryPoint = "sg_query_pipeline_state")]
public static extern ResourceState QueryPipelineState(Pipeline pip);

[DllImport("sokol", EntryPoint = "sg_query_pass_state")]
public static extern ResourceState QueryPassState(Pass pass);

[DllImport("sokol", EntryPoint = "sg_query_buffer_info")]
public static extern BufferInfo QueryBufferInfo(Buffer buf);

[DllImport("sokol", EntryPoint = "sg_query_image_info")]
public static extern ImageInfo QueryImageInfo(Image img);

[DllImport("sokol", EntryPoint = "sg_query_shader_info")]
public static extern ShaderInfo QueryShaderInfo(Shader shd);

[DllImport("sokol", EntryPoint = "sg_query_pipeline_info")]
public static extern PipelineInfo QueryPipelineInfo(Pipeline pip);

[DllImport("sokol", EntryPoint = "sg_query_pass_info")]
public static extern PassInfo QueryPassInfo(Pass pass);

[DllImport("sokol", EntryPoint = "sg_query_buffer_defaults")]
public static extern BufferDesc QueryBufferDefaults(in BufferDesc desc);

[DllImport("sokol", EntryPoint = "sg_query_image_defaults")]
public static extern ImageDesc QueryImageDefaults(in ImageDesc desc);

[DllImport("sokol", EntryPoint = "sg_query_shader_defaults")]
public static extern ShaderDesc QueryShaderDefaults(in ShaderDesc desc);

[DllImport("sokol", EntryPoint = "sg_query_pipeline_defaults")]
public static extern PipelineDesc QueryPipelineDefaults(in PipelineDesc desc);

[DllImport("sokol", EntryPoint = "sg_query_pass_defaults")]
public static extern PassDesc QueryPassDefaults(in PassDesc desc);

[DllImport("sokol", EntryPoint = "sg_alloc_buffer")]
public static extern Buffer AllocBuffer();

[DllImport("sokol", EntryPoint = "sg_alloc_image")]
public static extern Image AllocImage();

[DllImport("sokol", EntryPoint = "sg_alloc_shader")]
public static extern Shader AllocShader();

[DllImport("sokol", EntryPoint = "sg_alloc_pipeline")]
public static extern Pipeline AllocPipeline();

[DllImport("sokol", EntryPoint = "sg_alloc_pass")]
public static extern Pass AllocPass();

[DllImport("sokol", EntryPoint = "sg_dealloc_buffer")]
public static extern void DeallocBuffer(Buffer buf_id);

[DllImport("sokol", EntryPoint = "sg_dealloc_image")]
public static extern void DeallocImage(Image img_id);

[DllImport("sokol", EntryPoint = "sg_dealloc_shader")]
public static extern void DeallocShader(Shader shd_id);

[DllImport("sokol", EntryPoint = "sg_dealloc_pipeline")]
public static extern void DeallocPipeline(Pipeline pip_id);

[DllImport("sokol", EntryPoint = "sg_dealloc_pass")]
public static extern void DeallocPass(Pass pass_id);

[DllImport("sokol", EntryPoint = "sg_init_buffer")]
public static extern void InitBuffer(Buffer buf_id, in BufferDesc desc);

[DllImport("sokol", EntryPoint = "sg_init_image")]
public static extern void InitImage(Image img_id, in ImageDesc desc);

[DllImport("sokol", EntryPoint = "sg_init_shader")]
public static extern void InitShader(Shader shd_id, in ShaderDesc desc);

[DllImport("sokol", EntryPoint = "sg_init_pipeline")]
public static extern void InitPipeline(Pipeline pip_id, in PipelineDesc desc);

[DllImport("sokol", EntryPoint = "sg_init_pass")]
public static extern void InitPass(Pass pass_id, in PassDesc desc);

[DllImport("sokol", EntryPoint = "sg_uninit_buffer")]
public static extern bool UninitBuffer(Buffer buf_id);

[DllImport("sokol", EntryPoint = "sg_uninit_image")]
public static extern bool UninitImage(Image img_id);

[DllImport("sokol", EntryPoint = "sg_uninit_shader")]
public static extern bool UninitShader(Shader shd_id);

[DllImport("sokol", EntryPoint = "sg_uninit_pipeline")]
public static extern bool UninitPipeline(Pipeline pip_id);

[DllImport("sokol", EntryPoint = "sg_uninit_pass")]
public static extern bool UninitPass(Pass pass_id);

[DllImport("sokol", EntryPoint = "sg_fail_buffer")]
public static extern void FailBuffer(Buffer buf_id);

[DllImport("sokol", EntryPoint = "sg_fail_image")]
public static extern void FailImage(Image img_id);

[DllImport("sokol", EntryPoint = "sg_fail_shader")]
public static extern void FailShader(Shader shd_id);

[DllImport("sokol", EntryPoint = "sg_fail_pipeline")]
public static extern void FailPipeline(Pipeline pip_id);

[DllImport("sokol", EntryPoint = "sg_fail_pass")]
public static extern void FailPass(Pass pass_id);

[DllImport("sokol", EntryPoint = "sg_setup_context")]
public static extern Context SetupContext();

[DllImport("sokol", EntryPoint = "sg_activate_context")]
public static extern void ActivateContext(Context ctx_id);

[DllImport("sokol", EntryPoint = "sg_discard_context")]
public static extern void DiscardContext(Context ctx_id);

[DllImport("sokol", EntryPoint = "sg_d3d11_device")]
public static extern void* D3d11Device();

[DllImport("sokol", EntryPoint = "sg_mtl_device")]
public static extern void* MtlDevice();

[DllImport("sokol", EntryPoint = "sg_mtl_render_command_encoder")]
public static extern void* MtlRenderCommandEncoder();

}
}
