using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    internal class ExcursionPeriod
    {
        public int ExcursionPeriodID { get; set; }
        public int FromDate { get; set; }
        public DateTime ToDate { get; set; }
        Excursion excursion;
        public int ExcursionPrice { get; set; }
        public int TotalExcursion { get; set; }
    }
}
