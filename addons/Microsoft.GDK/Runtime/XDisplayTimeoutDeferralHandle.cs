using System;
using System.Runtime.InteropServices;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
    public class XDisplayTimeoutDeferralHandle : EquatableHandle
    {
        public XDisplayTimeoutDeferralHandle(IntPtr handle) :
            base(IntPtr.Zero, true, handle)
        {
        }

        protected override bool ReleaseHandle()
        {
            NativeMethods.XDisplayCloseTimeoutDeferralHandle(handle);
            SetHandle(IntPtr.Zero);
            return true;
        }

        public override bool IsInvalid
        {
            get { return this.Handle == IntPtr.Zero; }
        }
    }
}
