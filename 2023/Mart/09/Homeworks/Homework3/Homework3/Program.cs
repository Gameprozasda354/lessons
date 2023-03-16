using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[998];
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var list  = numbers.Where(x => x%2==0).ToList();

            var list2 = numbers.Where(x => x%2!=0 && x>400 && x<=550).ToList();

        }
        /*
         Homework 3:
             Bir dənə int array'ında 1-1000 arası rəqəmləriniz olsun (for ilə edin).
             1. Array'dan cüt rəqəmləri sorğu ilə götürün.
             2. Arrayda 400-dən böyük, 550-yə bərabər və ya kiçik olan, tək rəqəmləri götürün.
         */
    }
}
