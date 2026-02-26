using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSearchHandle : EquatableHandle
    {
        internal XblMultiplayerSearchHandle(Interop.XblMultiplayerSearchHandle interopHandle) :
            base(IntPtr.Zero, true, interopHandle.Ptr)
        {
        }

        public override bool IsInvalid => this.Handle == IntPtr.Zero;

        internal static Int32 WrapInteropHandleAndReturnHResult(Int32 hresult, Interop.XblMultiplayerSearchHandle interopHandle, out XblMultiplayerSearchHandle userHandle)
        {
            if (HR.SUCCEEDED(hresult))
            {
                userHandle = new XblMultiplayerSearchHandle(interopHandle);
            }
            else
            {
                userHandle = default(XblMultiplayerSearchHandle);
            }
            return hresult;
        }

        protected override bool ReleaseHandle()
        {
            XblInterop.XblMultiplayerSearchHandleCloseHandle(this.Handle);
            SetHandle(IntPtr.Zero);
            return true;
        }
    }
}
