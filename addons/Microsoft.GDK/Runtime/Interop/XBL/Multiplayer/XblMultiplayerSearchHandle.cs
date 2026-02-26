using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    //typedef struct XblMultiplayerSearchHandleDetails* XblMultiplayerSearchHandle;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblMultiplayerSearchHandle
    {
        internal readonly IntPtr Ptr;
    }
}
