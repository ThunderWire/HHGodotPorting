using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerInviteHandle
    {
        internal XblMultiplayerInviteHandle(Interop.XblMultiplayerInviteHandle interopStruct)
        {
            this.Data = interopStruct.GetData();
        }

        public string Data { get; }
    }
}
