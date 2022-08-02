using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string sentencs = " rəqəmi daxil edin:";

            int c;

            Console.Write("Birinci" + sentencs);
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci" + sentencs);
            int b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

        }

    }
}
