using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{
    //enum class XblTournamentArbitrationStatus : uint32_t
    //{
    //    Waiting,
    //    InProgress,
    //    Complete,
    //    Playing,
    //    Incomplete,
    //    Joining
    //};

    public enum XblTournamentArbitrationStatus : UInt32
    {
        Waiting = 0,
        InProgress = 1,
        Complete = 2,
        Playing = 3,
        Incomplete = 4,
        Joining = 5,
    }
}
