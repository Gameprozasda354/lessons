using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    internal class FlightData
    {
        public int FlightID { get; set; }
        public string FlightNo { get; set; }
        public string FlightDate { get; set; }
        FlightRoute flightRoute;
        public string Arrival { get; set; }
        public string Departure { get; set; }
        public int AdultPrice { get; set; }
        public int ChildPrice { get; set; }
        public int Stock { get; set; }
        public int TotalPrice { get; set; }
        public string Active { get; set; }
    }
}
