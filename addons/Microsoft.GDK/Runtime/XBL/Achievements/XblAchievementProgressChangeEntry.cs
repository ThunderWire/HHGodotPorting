using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblAchievementProgressChangeEntry
    {
        internal XblAchievementProgressChangeEntry(Interop.XblAchievementProgressChangeEntry interopStruct)
        {
            AchievementId = interopStruct.achievementId.GetString();
            ProgressState = interopStruct.progressState;
            Progression = new XblAchievementProgression(interopStruct.progression);
        }

        public string AchievementId { get; }
        public XblAchievementProgressState ProgressState { get; }
        public XblAchievementProgression Progression { get; }
    }
}
