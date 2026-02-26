using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionHandleId
    {
        internal XblMultiplayerSessionHandleId(Interop.XblMultiplayerSessionHandleId interopHandle)
        {
            this.Value = interopHandle.GetValue();
        }

        public string Value { get; }
    }
}
