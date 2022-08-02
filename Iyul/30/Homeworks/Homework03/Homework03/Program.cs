using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("10 ədəd daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            int k = a + b + c + d + e + f + g + h + i + j + 1;
            int l = a - b - c - d - e - f - g - h - i - j - 1;
            int m = a * b * c * d * e * f * g * h * i * j * 20;
            int n = a / b / c / d / e / f / g / h / i / j / 20;


            Console.WriteLine("Nəticə: " + a + " + " + b + " + " + c + " + " + d + " + " + e + " + " + f + " + " + g
                 + " + " + h + " + " + i + " + " + j + " + " + "1" + " = " + k);

            Console.WriteLine("Nəticə: " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + f + " - " + g
                 + " - " + h + " - " + i + " - " + j + " - " + "1" + " = " + l);

            Console.WriteLine("Nəticə: " + a + " * " + b + " * " + c + " * " + d + " * " + e + " * " + f + " * " + g
                 + " * " + h + " * " + i + " * " + j + " * " + "20" + " = " + m);

            Console.WriteLine("Nəticə: " + a + " / " + b + " / " + c + " / " + d + " / " + e + " / " + f + " / " + g
                 + " / " + h + " / " + i + " / " + j + " / " + "20" + " = " + n);

            Console.ReadLine();


        }
    }
}
