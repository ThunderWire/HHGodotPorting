using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblTournamentGameResultWithRank
    {
        internal XblTournamentGameResultWithRank(Interop.XblTournamentGameResultWithRank interopStruct)
        {
            this.Result = interopStruct.Result;
            this.Ranking = interopStruct.Ranking;
        }

        public XblTournamentGameResult Result { get; }
        public UInt64 Ranking { get; }
    }
}
