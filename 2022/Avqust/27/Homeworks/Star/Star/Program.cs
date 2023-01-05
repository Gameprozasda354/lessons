using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for(int i = 0; i <= 20; i++)
            {
                for (int c = 19; i <= c; c--)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("           ##################");
            }

        }
    }
}
