using FantasyBaseballAnalyticsAPI.Biz.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure
{
    interface IStadium : IStructureBase
    {
        eGrassType Grass { get; }
        eStadiumType StadiumType { get; }
        eTendancyType Tendancy { get; }
    }
}
