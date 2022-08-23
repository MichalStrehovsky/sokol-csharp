# Sokol_csharp

NuGet: https://www.nuget.org/packages/sokol_csharp.unofficial/

C# bindings for [Sokol](https://github.com/floooh/sokol) generated from https://github.com/MichalStrehovsky/sokol/tree/gen_csharp.

They follow the same model as the "official" bindings for Zig and Nim in the official Sokol repo at https://github.com/floooh/sokol.

The C# generator is not upstreamed to Sokol yet which is why I point to my private fork. I want to get some mileage on it before I try to contribute it.

To build a shared library with Sokol binaries that the C# source p/invokes into, cd into src/sokol/c and build the sokol.c file.

I'm building this without annoying CRT dependencies (`#define NO_CRT`), but you don't have to. This is my build workflow:

On Windows, to build a shared library you can run:

```console
cl /MT /DNO_CRT /EHs-c- /GR- /LD /Zi /GS- /O1 /Gs8192 sokol.c /link /opt:ref,icf /NODEFAULTLIB:libucrt.lib /DEFAULTLIB:ucrt.lib
```

On Windows, to build a static library suitable to be used with [bflat](https://github.com/bflattened/bflat), run:

```console
cl /DNO_CRT /DBFLAT_LIB /c /EHs-c- /GR- /Z7 /Zl /GS- /O1 /Fdsokol.pdb /Gs8192 sokol.c
lib sokol.obj
```
