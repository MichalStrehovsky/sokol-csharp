using System;
using System.Runtime.InteropServices;

using Sokol;

App.Run(new() {
    InitCb = &Init,
    FrameCb = &Frame,
    CleanupCb = &Cleanup,
    Width = 640,
    Height = 480,
    GlForceGles2 = true,
    WindowTitle = "Clear (sokol-app)",
    Icon = { SokolDefault = true },
});

[UnmanagedCallersOnly]
static void Init()
{
    Gfx.Setup(new()
    {
        Context = App.Context(),
    });

    State.PassAction.Colors[0] = new()
    {
        Action = Gfx.Action.Clear,
        Value = new() { R = 1, G = 0, B = 0, A = 1 },
    };
}

[UnmanagedCallersOnly]
static void Frame()
{
    var g = State.PassAction.Colors[0].Value.G + 0.01f;
    State.PassAction.Colors[0].Value.G = g > 1.0 ? 0 : g;
    Gfx.BeginDefaultPass(State.PassAction, App.Width(), App.Height());
    Gfx.EndPass();
    Gfx.Commit();
}

[UnmanagedCallersOnly]
static void Cleanup()
{
    Gfx.Shutdown();
}

static class State
{
    public static Gfx.PassAction PassAction;
}
