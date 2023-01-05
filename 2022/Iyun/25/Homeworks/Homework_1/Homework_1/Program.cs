using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adinizi daxil edin:");
            var name = Console.ReadLine();

            Console.Write("Soyadinizi daxil edin:");
            var surName = Console.ReadLine();

            Console.Write("Yasadiginiz olkeni daxil edin:");
            var country = Console.ReadLine();

            //Men elave olaraq Onlari Ekrana cixardim

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Adiniz:" + name);
            Console.WriteLine("Soyadiniz:" + surName);
            Console.WriteLine("Yasadiginiz olke:" + country);

            Console.ReadLine();

            

        }
    }
}
