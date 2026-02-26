using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    //typedef struct XblPresenceRecord* XblPresenceRecordHandle;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblPresenceRecordHandle
    {
        internal readonly IntPtr intPtr;
    }
}
