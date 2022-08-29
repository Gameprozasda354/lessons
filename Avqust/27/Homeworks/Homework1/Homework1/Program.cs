using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool count = true;
            int c = 0;
            while (count)
            {
                Console.WriteLine("Reqem daxil edin:");
                int line = Convert.ToInt32(Console.ReadLine());
                
                if (line > 0)
                {
                    c = c + line; 
                }

                else
                    count = false;

            }

            Console.WriteLine($"Netice:{c}");

            Console.ReadLine();

        }
    }
}
