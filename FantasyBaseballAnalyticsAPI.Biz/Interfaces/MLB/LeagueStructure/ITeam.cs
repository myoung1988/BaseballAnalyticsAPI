using Dynasty.Domain.Enumerators;
using FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure
{
    interface ITeam : IStructureBase
    {
        string City { get; set; }
        string Logo { get; set; }
    }
}
