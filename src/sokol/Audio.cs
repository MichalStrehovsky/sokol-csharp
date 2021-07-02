// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

namespace Sokol
{
public static unsafe partial class Audio
{
public struct Desc
{
    public int SampleRate;
    public int NumChannels;
    public int BufferFrames;
    public int PacketFrames;
    public int NumPackets;
    public delegate* unmanaged<float*, int, int, void> StreamCb;
    public delegate* unmanaged<float*, int, int, void*, void> StreamUserdataCb;
    public void* UserData;
}
[DllImport("sokol", EntryPoint = "saudio_setup")]
public static extern void Setup(in Desc desc);

[DllImport("sokol", EntryPoint = "saudio_shutdown")]
public static extern void Shutdown();

[DllImport("sokol", EntryPoint = "saudio_isvalid")]
public static extern bool Isvalid();

[DllImport("sokol", EntryPoint = "saudio_userdata")]
public static extern void* Userdata();

[DllImport("sokol", EntryPoint = "saudio_query_desc")]
public static extern Desc QueryDesc();

[DllImport("sokol", EntryPoint = "saudio_sample_rate")]
public static extern int SampleRate();

[DllImport("sokol", EntryPoint = "saudio_buffer_frames")]
public static extern int BufferFrames();

[DllImport("sokol", EntryPoint = "saudio_channels")]
public static extern int Channels();

[DllImport("sokol", EntryPoint = "saudio_expect")]
public static extern int Expect();

[DllImport("sokol", EntryPoint = "saudio_push")]
public static extern int Push(in float frames, int num_frames);

}
}
