using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynasty.Domain.Interfaces.MLB
{
    interface IPlayerStats<IStat>
    {
        /// <summary>
        /// Stats are stored by month rather than by day to avoid just data sets for now.
        /// </summary>
        short MonthId { get; set; }
        short SeasonId { get; set; }
        IStat Stat { get; set; }
    }
}
