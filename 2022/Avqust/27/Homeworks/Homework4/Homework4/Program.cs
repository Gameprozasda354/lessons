using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir reqem daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            bool zero = false;

            while(zero == false)
            {
                count = count - 1;
                Console.WriteLine(count);
                if (count == 0)
                {
                    zero = true;
                }
            }
            Console.ReadLine();
        }
    }
}
