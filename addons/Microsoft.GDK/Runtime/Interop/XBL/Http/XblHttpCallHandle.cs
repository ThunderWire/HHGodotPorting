using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    /// <summary>
    /// Handle to an Xbox live context. Needed to interact with Xbox live services.
    /// </summary>
    //typedef struct XblContext* XblContextHandle;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblHttpCallHandle
    {
        internal readonly IntPtr handle;
    }
}
