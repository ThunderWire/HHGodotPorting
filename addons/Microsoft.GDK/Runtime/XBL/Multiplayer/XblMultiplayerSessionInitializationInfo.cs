using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionInitializationInfo
    {
        internal XblMultiplayerSessionInitializationInfo(Interop.XblMultiplayerSessionInitializationInfo interopHandle)
        {
            this.Stage = interopHandle.Stage;
            this.StageStartTime = interopHandle.StageStartTime.DateTime;
            this.Episode = interopHandle.Episode;
        }

        public XblMultiplayerInitializationStage Stage { get; }

        public DateTime StageStartTime { get; }

        public UInt32 Episode { get; }
    }
}
