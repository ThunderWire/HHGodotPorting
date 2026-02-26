using System;


namespace GDK.XGamingRuntime
{

    public class XblHopperStatisticsResponse
    {
        internal XblHopperStatisticsResponse()
        {
                this.HopperName = "";
                this.EstimatedWaitTime = 0;
                this.PlayersWaitingToMatch = 0;
        }

        internal XblHopperStatisticsResponse(Interop.XblHopperStatisticsResponse interopHandle)
        {
            this.HopperName = interopHandle.hopperName.GetString();
            this.EstimatedWaitTime = interopHandle.estimatedWaitTime;
            this.PlayersWaitingToMatch = interopHandle.playersWaitingToMatch;
        }

        public string HopperName { get; set;}
        public Int64 EstimatedWaitTime { get; set; }
        public UInt32 PlayersWaitingToMatch { get; set; }
    }
}
