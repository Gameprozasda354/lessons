using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("True vəya False daxil edin:");
            bool Light = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Yazı daxil edin:");
            var st = Console.ReadLine();

            Console.Write("Kiçik bir rəqəm daxil edin:");
            short sh = Convert.ToInt16(Console.ReadLine());

            Console.Write("Uzun bir rəqəm daxil edin:");
            long lg = Convert.ToInt64(Console.ReadLine());

            Console.Write("Bir Simvol, Rəqəm və ya bi hərf daxil edin:");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.Write("Hər hansısa bir zamanı daxil edin:");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine(Light);
            Console.WriteLine(st);
            Console.WriteLine(sh);
            Console.WriteLine(lg);
            Console.WriteLine(ch);
            Console.WriteLine(dt);


            Console.ReadLine();

        }
    }
}
