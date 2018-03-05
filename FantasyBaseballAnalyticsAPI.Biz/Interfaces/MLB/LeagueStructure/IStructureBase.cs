using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure
{
    interface IStructureBase
    {
        int Id { get; }
        string Name { get; }
        string Abbreviation { get; }
    }
}
