using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{
    //enum class XblMultiplayerSessionRestriction : uint32_t
    //{
    //    Unknown,
    //    None,
    //    Local,
    //    Followed
    //};

    public enum XblMultiplayerSessionRestriction : UInt32
    {
        Unknown = 0,
        None = 1,
        Local = 2,
        Followed = 3,
    }
}
