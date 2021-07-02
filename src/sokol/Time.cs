// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

namespace Sokol
{
public static unsafe partial class Time
{
[DllImport("sokol", EntryPoint = "stm_setup")]
public static extern void Setup();

[DllImport("sokol", EntryPoint = "stm_now")]
public static extern ulong Now();

[DllImport("sokol", EntryPoint = "stm_diff")]
public static extern ulong Diff(ulong new_ticks, ulong old_ticks);

[DllImport("sokol", EntryPoint = "stm_since")]
public static extern ulong Since(ulong start_ticks);

[DllImport("sokol", EntryPoint = "stm_laptime")]
public static extern ulong Laptime(ref ulong last_time);

[DllImport("sokol", EntryPoint = "stm_round_to_common_refresh_rate")]
public static extern ulong RoundToCommonRefreshRate(ulong frame_ticks);

[DllImport("sokol", EntryPoint = "stm_sec")]
public static extern double Sec(ulong ticks);

[DllImport("sokol", EntryPoint = "stm_ms")]
public static extern double Ms(ulong ticks);

[DllImport("sokol", EntryPoint = "stm_us")]
public static extern double Us(ulong ticks);

[DllImport("sokol", EntryPoint = "stm_ns")]
public static extern double Ns(ulong ticks);

}
}
