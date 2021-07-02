# Sokol_csharp

C# bindings for Sokol generated from https://github.com/MichalStrehovsky/sokol/tree/gen_csharp.

The generator is not upstreamed to Sokol yet. I want to get some mileage on it before I try to contribute it.

To build a shared library with Sokol binaries cd into src/sokol/c and build the sokol.c file.

I'm building this without annoying CRT dependencies, but you don't have to. This is my build workflow:

On Windows, to build a shared library you can run:

```console
$ cl /EHs-c- /GR- /LD /Zi /Zl /GS- /O1 /Gs8192 sokol.c /link path_to_your\msvcrt.lib /noentry /opt:ref,icf
```

You can grab a msvcrt.lib from e.g. https://github.com/neosmart/msvcrt.lib.

On Windows, to build a static library suitable to be used with [bflat](https://github.com/MichalStrehovsky/bflat), run:

```console
cl /DBFLAT_LIB /c /EHs-c- /GR- /Zi /Zl /GS- /O1 /Gs8192 sokol.c
lib sokol.obj
```
