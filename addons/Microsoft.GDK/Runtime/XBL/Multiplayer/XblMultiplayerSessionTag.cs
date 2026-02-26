using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionTag
    {
        public XblMultiplayerSessionTag(string value)
        {
            Value = value;
        }

        internal XblMultiplayerSessionTag(Interop.XblMultiplayerSessionTag interopStruct)
        {
            this.Value = interopStruct.GetValue();
        }

        public string Value { get; }
    }
}
