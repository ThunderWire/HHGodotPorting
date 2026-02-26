using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionQuery
    {
        public XblMultiplayerSessionQuery()
        {
        }

        public string Scid { get; set; }
        public UInt32 MaxItems { get; set; }
        public bool IncludePrivateSessions { get; set; }
        public bool IncludeReservations { get; set; }
        public bool IncludeInactiveSessions { get; set; }
        public UInt64[] XuidFilters { get; set; }
        public string KeywordFilter { get; set; }
        public string SessionTemplateNameFilter { get; set; }
        public XblMultiplayerSessionVisibility VisibilityFilter { get; set; }
        public UInt32 ContractVersionFilter { get; set; }

    }
}
