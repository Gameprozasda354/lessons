using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Phone : Country
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool FastCharge { get; set; }
        public bool MadeInCountry { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
