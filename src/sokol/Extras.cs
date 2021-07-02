using System;
using System.Runtime.InteropServices;

namespace Sokol
{
    static partial class App
    {
        [DllImport("sokol", EntryPoint = "sapp_sgcontext")]
        public static extern Gfx.ContextDesc Context();
    }

    partial class Gfx
    {
        public static unsafe Buffer MakeBuffer<T>(T[] bytes, string label) where T : unmanaged
        {
            fixed (T* pBytes = bytes)
            {
                return MakeBuffer(new()
                {
                    Data = { Ptr = pBytes, Size = (nuint)(bytes.Length * sizeof(T)) },
                    Label = label,
                });
            }
        }

        public static unsafe Buffer MakeBuffer<T>(ReadOnlySpan<T> bytes, string label) where T : unmanaged
        {
            fixed (T* pBytes = bytes)
            {
                return MakeBuffer(new()
                {
                    Data = { Ptr = pBytes, Size = (nuint)(bytes.Length * sizeof(T)) },
                    Label = label,
                });
            }
        }
    }
}
