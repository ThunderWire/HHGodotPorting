using System;
using System.Runtime.InteropServices;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerActivityRecentPlayerUpdate
    {
        public XblMultiplayerActivityRecentPlayerUpdate()
        {

        }

        public UInt64 Xuid { get; set; }

        public XblMultiplayerActivityEncounterType EncounterType { get; set; }
    }
}
