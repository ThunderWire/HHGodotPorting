using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime

{
    //enum class XblSocialNotificationType : uint32_t
    //{
    //    Unknown,
    //    Added,
    //    Changed,
    //    Removed
    //};


    public enum XblSocialNotificationType : UInt32
    {
        Unknown = 0,
        Added,
        Changed,
        Removed
    }
}
