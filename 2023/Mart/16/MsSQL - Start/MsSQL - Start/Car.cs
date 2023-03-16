using MsSQL___Start.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSQL___Start
{
    public class Car
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public ColorEnum Color { get; set; }
        public int Engine { get; set; }
        public int HP { get; set; }
        public decimal Km { get; set; }
        public GearBoxTypeEnum GearboxType { get; set; }
        public decimal Price { get; set; }
    }
}
