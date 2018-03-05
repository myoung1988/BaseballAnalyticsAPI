using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.Stats;
using FantasyBaseballAnalyticsAPI.Biz.Interfaces.MLB.LeagueStructure;

namespace Dynasty.Domain.Interfaces.MLB
{
    interface IPlayerRepository
    {
        int PlayerID { get; set; }
        DateTime Birthdate { get; set; }
        int Age { get; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }

        List<IPlayerStats<IStat>> Stats { get; }

        List<IPlayerStats<IStat>> FindStatsBySeason(string season);
        List<IPlayerStats<IStat>> FindStatsByDates(List<DateTime> dates);

        ITeam Team { get; set; }
    }
}
