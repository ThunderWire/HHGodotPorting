using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblPermissionDenyReasonDetails
    {
        internal XblPermissionDenyReasonDetails(Interop.XblPermissionDenyReasonDetails interopStruct)
        {
            this.Reason = interopStruct.reason;
            this.RestrictedPrivilege = interopStruct.restrictedPrivilege;
            this.RestrictedPrivacySetting = interopStruct.restrictedPrivacySetting;
        }

        public XblPermissionDenyReason Reason { get; private set; }
        public XblPrivilege RestrictedPrivilege { get; private set; }
        public XblPrivacySetting RestrictedPrivacySetting { get; private set; }
    }
}
