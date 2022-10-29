using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Address
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Distinct { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        public City city;
    }
}
