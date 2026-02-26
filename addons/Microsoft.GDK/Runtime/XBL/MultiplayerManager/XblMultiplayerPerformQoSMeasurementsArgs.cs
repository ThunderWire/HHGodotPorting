using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerPerformQoSMeasurementsArgs
    {
        internal XblMultiplayerPerformQoSMeasurementsArgs(Interop.XblMultiplayerPerformQoSMeasurementsArgs interopStruct)
        {
            this.RemoteClients = interopStruct.GetRemoteClients(x => new XblMultiplayerConnectionAddressDeviceTokenPair(x));
        }

        public XblMultiplayerConnectionAddressDeviceTokenPair[] RemoteClients { get; }
    }
}
