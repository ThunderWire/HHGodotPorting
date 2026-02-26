using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionMemberRole
    {
        internal XblMultiplayerSessionMemberRole(Interop.XblMultiplayerSessionMemberRole interopHandle)
        {
            this.InteropHandle = interopHandle;

            this.RoleTypeName = interopHandle.roleTypeName.GetString();
            this.RoleName = interopHandle.roleName.GetString();
        }

        public string RoleTypeName { get; }
        public string RoleName { get; }

        internal Interop.XblMultiplayerSessionMemberRole InteropHandle { get; }
    }
}
