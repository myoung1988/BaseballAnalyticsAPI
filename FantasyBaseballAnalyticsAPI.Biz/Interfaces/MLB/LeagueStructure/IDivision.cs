using FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure
{
    interface IDivision : IStructureBase
    {
        IList<ITeam> Teams { get; }
    }
}
