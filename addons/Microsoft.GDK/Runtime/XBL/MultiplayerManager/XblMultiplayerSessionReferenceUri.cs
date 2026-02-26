using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionReferenceUri
    {
        internal XblMultiplayerSessionReferenceUri(Interop.XblMultiplayerSessionReferenceUri interopStruct)
        {
            this.Value = interopStruct.GetValue();
        }

        public string Value { get; }
    }
}
