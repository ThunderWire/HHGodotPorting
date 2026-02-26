using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    // typedef struct XblTitleStorageBlobMetadataResult* XblTitleStorageBlobMetadataResultHandle;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblTitleStorageBlobMetadataResultHandle
    {
        internal readonly IntPtr intPtr;
    }
}