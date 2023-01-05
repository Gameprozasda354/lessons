using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int b = 0; b < 10; b++)
                {
                    int c = i * b;
                    Console.Write($"{i}*{b}={c}\t");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
