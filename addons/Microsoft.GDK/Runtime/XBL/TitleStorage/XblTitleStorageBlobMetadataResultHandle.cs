using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblTitleStorageBlobMetadataResultHandle : EquatableHandle
    {
        internal XblTitleStorageBlobMetadataResultHandle(Interop.XblTitleStorageBlobMetadataResultHandle interopHandle) :
            base(IntPtr.Zero, true, interopHandle.intPtr)
        {
        }

        public override bool IsInvalid => this.handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            XblInterop.XblTitleStorageBlobMetadataResultCloseHandle(this.Handle);
            SetHandle(this.handle);
            return true;
        }
    }
}
