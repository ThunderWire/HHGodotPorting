using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerConnectionAddressDeviceTokenPair
    {
        internal XblMultiplayerConnectionAddressDeviceTokenPair(Interop.XblMultiplayerConnectionAddressDeviceTokenPair interopStruct)
        {
            this.ConnectionAddress = interopStruct.connectionAddress.GetString();
            this.DeviceToken = new XblDeviceToken(interopStruct.deviceToken);
        }

        public string ConnectionAddress { get; }
        public XblDeviceToken DeviceToken { get; }
    }
}
