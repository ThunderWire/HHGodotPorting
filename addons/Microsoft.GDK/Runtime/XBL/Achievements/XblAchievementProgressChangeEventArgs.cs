using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{
    public class XblAchievementProgressChangeEventArgs
    {
        internal XblAchievementProgressChangeEventArgs(Interop.XblAchievementProgressChangeEventArgs interopEventArgs)
        {
            this.UpdatedAchievementEntries =
                InteropHelpers.MarshalArray<Interop.XblAchievementProgressChangeEntry, XblAchievementProgressChangeEntry>(interopEventArgs.updatedAchievementEntries, interopEventArgs.entryCount, (entriesInterop) => new XblAchievementProgressChangeEntry(entriesInterop));
            this.EntryCount = interopEventArgs.entryCount;
        }

        public XblAchievementProgressChangeEntry[] UpdatedAchievementEntries { get; private set; }
        public ulong EntryCount { get; private set; }
    }
}
