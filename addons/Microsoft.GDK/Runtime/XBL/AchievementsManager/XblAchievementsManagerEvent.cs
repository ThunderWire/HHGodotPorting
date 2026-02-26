using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblAchievementsManagerEvent
    {
        internal XblAchievementsManagerEvent(Interop.XblAchievementsManagerEvent interopStruct)
        {
            this.progressInfo = new XblAchievementProgressChangeEntry(interopStruct.progressInfo);
            this.xboxUserId = interopStruct.xboxUserId;
            this.eventType = interopStruct.eventType;
        }

        public XblAchievementProgressChangeEntry progressInfo { get; }
        public UInt64 xboxUserId { get; }
        public XblAchievementsManagerEventType eventType { get; }
    }
}
