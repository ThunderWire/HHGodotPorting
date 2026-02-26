using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{
    /// <summary>Enumeration values that specify the order we display the results in.</summary>

    public enum XblAchievementsManagerSortOrder : UInt32
    {
        /// <summary>Unsorted sort order will skip the sort operation.</summary>
        Unsorted = 0,

        /// <summary>Elements in the response are in ascending order of the field specified by XblAchievementsManagerSortValue.</summary>
        Ascending = 1,

        /// <summary>Elements in the response are in descending order of the field specified by XblAchievementsManagerSortValue.</summary>
        Descending = 2
    };
}
