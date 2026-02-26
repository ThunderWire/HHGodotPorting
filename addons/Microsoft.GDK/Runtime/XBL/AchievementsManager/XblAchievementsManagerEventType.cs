using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{
    /// <summary>Defines values used to indicate event types for an achievement.</summary>

    public enum XblAchievementsManagerEventType : UInt32
    {
        /// <summary>Indicates that a local user was added and has been initialized.</summary>
        LocalUserInitialStateSynced = 0,

        /// <summary>Indicates the achievement was unlocked.</summary>
        AchievementUnlocked = 1,

        /// <summary>Indicates progress has been made on (a requirement of) an achievement.</summary>
        AchievementProgressUpdated = 2
    };
}
