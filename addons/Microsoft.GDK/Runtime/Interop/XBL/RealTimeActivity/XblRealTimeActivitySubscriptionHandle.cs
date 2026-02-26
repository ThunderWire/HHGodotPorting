using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    //typedef struct XblRealTimeActivitySubscription* XblRealTimeActivitySubscriptionHandle;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblRealTimeActivitySubscriptionHandle
    {
        private readonly IntPtr intPtr;
    }
}
