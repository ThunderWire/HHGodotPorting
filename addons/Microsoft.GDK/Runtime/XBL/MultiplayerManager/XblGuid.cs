using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblGuid
    {
        internal XblGuid(Interop.XblGuid interopStruct)
        {
            this.Value = interopStruct.GetValue();
        }

        public string Value { get; }
    }
}
