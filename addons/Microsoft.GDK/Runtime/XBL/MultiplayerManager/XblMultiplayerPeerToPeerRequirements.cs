using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerPeerToPeerRequirements
    {
        internal XblMultiplayerPeerToPeerRequirements(Interop.XblMultiplayerPeerToPeerRequirements interopStruct)
        {
            this.LatencyMaximum = interopStruct.LatencyMaximum;
            this.BandwidthMinimumInKbps = interopStruct.BandwidthMinimumInKbps;
        }

        public UInt64 LatencyMaximum { get; }
        public UInt64 BandwidthMinimumInKbps { get; }
    }
}
