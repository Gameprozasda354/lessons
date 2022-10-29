using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Car : Country
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Km { get; set; }
        public string Engine { get; set; }
        public string Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ?EditDate { get; set; }
    }
}
