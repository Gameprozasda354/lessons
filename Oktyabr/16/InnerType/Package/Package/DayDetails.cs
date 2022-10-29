using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    internal class DayDetails
    {
        public int DayDetailsID { get; set; }
        DurationDetails durationDetails;
        FlightRoute flightRoute;
        Hotel hotel;
        Excursion excursion;
        TransferType transferType;

    }
}
