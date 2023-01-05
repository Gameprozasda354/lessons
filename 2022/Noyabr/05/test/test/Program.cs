using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.ShowAllInfo();

            Console.WriteLine("-----------------------");

            Person _person = new Person();
            _person.ShowAllInfo();
        }
    }
}
