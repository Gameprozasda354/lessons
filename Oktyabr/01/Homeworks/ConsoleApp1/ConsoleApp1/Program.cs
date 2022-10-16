using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();

            string name = Console.ReadLine();
            string surName = Console.ReadLine();
            string gender = Console.ReadLine();

            staff.Name = name;
            staff.SurName = surName;
            staff.Gender = gender;

            Console.WriteLine(staff.Email);

        }
    }
}
