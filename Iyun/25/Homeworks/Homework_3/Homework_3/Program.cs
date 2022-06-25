using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Read

            Console.Write("1-ci Seher adini daxil edin:");
            var city1 = Console.ReadLine();

            Console.Write("2-ci Seher adini daxil edin:");
            var city2 = Console.ReadLine();

            Console.Write("3-cü Seher adini daxil edin:");
            var city3 = Console.ReadLine();

            Console.Write("4-cü Seher adini daxil edin:");
            var city4 = Console.ReadLine();

            Console.Write("5-ci Seher adini daxil edin:");
            var city5 = Console.ReadLine();

            Console.Write("6-cı Seher adini daxil edin:");
            var city6 = Console.ReadLine();

            Console.Write("7-ci Seher adini daxil edin:");
            var city7 = Console.ReadLine();

            Console.Write("8-ci Seher adini daxil edin:");
            var city8 = Console.ReadLine();

            Console.Write("9-cu Seher adini daxil edin:");
            var city9 = Console.ReadLine();

            Console.Write("10-cu Seher adini daxil edin:");
            var city10 = Console.ReadLine();

            #endregion

            #region Print

            Console.WriteLine("-----------------------------------");

            Console.WriteLine(city1 + ", " + city2 + ", " + city3 + ", " + city4 + ", " + city5 +
                ", " + city6 + ", " + city7 + ", " + city8 + ", " + city9 + ", " + city10);

            Console.ReadLine();

            #endregion

        }
    }
}
