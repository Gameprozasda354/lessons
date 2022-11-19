using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    public partial class Car : BaseClass<Car>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; }
        public string SeatMaterial { get; set; }
        public int Door { get; set; }
        public int Engine { get; set; }
        public string FuelType { get; set; }

        public override int Add(Car item)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Car[] Get()
        {
            throw new NotImplementedException();
        }

        public override Car Update(Car item)
        {
            throw new NotImplementedException();
        }
    }
}
