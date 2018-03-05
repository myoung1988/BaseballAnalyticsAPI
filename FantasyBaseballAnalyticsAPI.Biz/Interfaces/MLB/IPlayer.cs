using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.Stats;
using FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure;
using FantasyBaseballAnalyticsAPI.Biz.Enumerators;

namespace Dynasty.Domain.Interfaces.MLB
{
    interface IPlayer
    {
        int PlayerID { get; set; }
        int Age { get; }
        
        string Name { get; }
        eBattingStance Batting { get; }
        eThrowingHand Throwing { get; }
        IList<ePosition> Positions { get; }

        List<IPlayerStats<IStat>> Stats { get; }

        List<IPlayerStats<IStat>> FindStatsBySeason(string season);
        List<IPlayerStats<IStat>> FindStatsByDates(List<DateTime> dates);

        ITeam Team { get; set; }
    }
}
