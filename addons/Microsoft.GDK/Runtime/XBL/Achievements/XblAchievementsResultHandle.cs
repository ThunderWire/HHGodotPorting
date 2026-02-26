using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblAchievementsResultHandle : EquatableHandle
    {
        internal XblAchievementsResultHandle(Interop.XblAchievementsResultHandle interopHandle) :
            base(IntPtr.Zero, true, interopHandle.handle)
        {
        }

        public override bool IsInvalid => this.Handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            XblInterop.XblAchievementsResultCloseHandle(this.Handle);
            SetHandle(IntPtr.Zero);
            return true;
        }
    }
}
