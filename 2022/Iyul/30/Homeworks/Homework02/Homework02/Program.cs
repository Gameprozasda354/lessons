using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            Console.Write("1-ci rəqəmi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2-ci rəqəmi daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3-cü rəqəmi daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = a + b + c;
            int f = a - b - c;
            int e = a / b / c;
            int g = a * b * c;



            Console.WriteLine("---------------------");
            Console.WriteLine("Nəticə: " + a + " + " + b + " + " + c + " = " + d);
            Console.WriteLine("Nəticə: " + a + " - " + b + " - " + c + " = " + f);
            Console.WriteLine("Nəticə: " + a + " * " + b + " * " + c + " = " + g);
            Console.WriteLine("Nəticə: " + a + " / " + b + " / " + c + " = " + e);

            Console.ReadLine();




        }
    }
}
