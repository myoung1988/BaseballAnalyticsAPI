using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynasty.Domain.Interfaces.MLB
{
    interface IPlayerStats<IStat>
    {
        DateTime Date { get; set; }
        string Season { get; set; }
        IStat Stat { get; set; }
    }
}
