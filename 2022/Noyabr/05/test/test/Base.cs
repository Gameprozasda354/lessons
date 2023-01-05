using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Base
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public virtual void ShowAllInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Surname:" + SurName);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Job:" + Job);
        }
    }
}
