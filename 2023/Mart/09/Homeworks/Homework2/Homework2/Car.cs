using Homework2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Car
    {
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MadeYear { get; set; }
        public Color Color { get; set; }
        public int Engine { get; set; }
        public int Hp { get; set; }
        public int Km { get; set; }
        public GearBox GearBox { get; set; }
        public int Price { get; set; }
    }
}
