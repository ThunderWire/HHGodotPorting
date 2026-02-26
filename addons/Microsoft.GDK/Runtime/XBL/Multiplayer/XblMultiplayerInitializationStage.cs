using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{
    //enum class XblMultiplayerInitializationStage : uint32_t
    //{
    //    Unknown,
    //    None,
    //    Joining,
    //    Measuring,
    //    Evaluating,
    //    Failed
    //};

    public enum XblMultiplayerInitializationStage : UInt32
    {
        Unknown,
        None,
        Joining,
        Measuring,
        Evaluating,
        Failed
    }
}
