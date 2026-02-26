using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblCreateMatchTicketResponse
    {
        internal XblCreateMatchTicketResponse(Interop.XblCreateMatchTicketResponse interopHandle)
        {
            this.MatchTicketId = Converters.ByteArrayToString(interopHandle.matchTicketId);
            this.EstimatedWaitTime = interopHandle.estimatedWaitTime;
        }

        public string MatchTicketId { get; }

        public Int64 EstimatedWaitTime { get; }
    }
}
