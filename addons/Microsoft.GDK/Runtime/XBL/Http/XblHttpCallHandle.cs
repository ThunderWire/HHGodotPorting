using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblHttpCallHandle : EquatableHandle
    {
        internal XblHttpCallHandle(Interop.XblHttpCallHandle interopHandle) :
            base(IntPtr.Zero, true, interopHandle.handle)
        {
        }

        internal static Int32 WrapInteropHandleAndReturnHResult(Int32 hresult, Interop.XblHttpCallHandle interopHandle, out XblHttpCallHandle handle)
        {
            if (Interop.HR.SUCCEEDED(hresult))
            {
                handle = new XblHttpCallHandle(interopHandle);
            }
            else
            {
                handle = default(XblHttpCallHandle);
            }
            return hresult;
        }

        public override bool IsInvalid => this.Handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            XblInterop.XblHttpCallCloseHandle(this.Handle);
            SetHandle(IntPtr.Zero);
            return true;
        }
    }
}

