using FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

namespace FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct ShaderPackageResourceHandle {
    [FieldOffset(0x0)] public ResourceHandle ResourceHandle;
    [FieldOffset(0xB0)] public ShaderPackage* ShaderPackage;
}
