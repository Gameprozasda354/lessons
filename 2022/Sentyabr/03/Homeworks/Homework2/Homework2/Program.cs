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
            int[] dn;
            int mincount;
            int maxcount;
            long addcount = 0;
            
            Random rndcount = new Random();

            dn = new int[100];
            for (int i = 0; i < 100; i++)
            {
                dn[i] = rndcount.Next();
            }
            
            mincount = dn[0];
            maxcount = dn[0];

            foreach (int integer in dn)
            {
                if(mincount > integer)
                {
                    mincount = integer;
                }
            }

            foreach (int integer in dn)
            {
                if (maxcount < integer)
                {
                    maxcount = integer;
                }
                addcount = addcount + integer;
            }

            Console.WriteLine("Max Value:" + maxcount);
            Console.WriteLine("Min Value:" + mincount);
            Console.WriteLine("Sum Value:" + addcount);
            
            

        }
    }
}
