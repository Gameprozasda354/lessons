using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Person : Base
    {
        public override void ShowAllInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Surname:" + SurName);
            Console.WriteLine("This man is Happy :)");
        }
    }
}
