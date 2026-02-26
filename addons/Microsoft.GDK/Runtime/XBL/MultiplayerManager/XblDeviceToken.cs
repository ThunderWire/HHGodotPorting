using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblDeviceToken
    {
        internal XblDeviceToken(Interop.XblDeviceToken interopStruct)
        {
            this.Value = interopStruct.GetValue();
        }

        public string Value { get; set; }
    }
}
