using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblPresenceRecordHandle : EquatableHandle
    {
        internal XblPresenceRecordHandle(Interop.XblPresenceRecordHandle interopHandle) :
            base(IntPtr.Zero, true, interopHandle.intPtr)
        {
        }

        internal static Int32 WrapInteropHandleAndReturnHResult(Int32 hresult, Interop.XblPresenceRecordHandle interopHandle, out XblPresenceRecordHandle handle)
        {
            if (Interop.HR.SUCCEEDED(hresult))
            {
                handle = new XblPresenceRecordHandle(interopHandle);
            }
            else
            {
                handle = default(XblPresenceRecordHandle);
            }
            return hresult;
        }

        public override bool IsInvalid => this.Handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            XblInterop.XblPresenceRecordCloseHandle(this.Handle);
            SetHandle(IntPtr.Zero);
            return true;
        }
    }
}
