using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    //typedef struct XblMultiplayerSession* XblMultiplayerSessionHandle;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblMultiplayerSessionHandle
    {
        internal readonly IntPtr intPtr;
    }
}
