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
            List<string> names = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                names.Add(FakeData.NameData.GetFirstName());
            }

            names.RemoveAll(x => x.Length >= 5);
        }
        /*
             Homework 4:
             Bir dənə String List'iniz olsun (names) və FakeData ilə 1000 dənə Name əlavə edin.
             Sonra həmin list'dən adı 5 simvol və ya daha uzun olan adları silin. Bunu etmək üçün Remove və ya RemoveAll method'larını araşdırın və sonra edin.
        */
    }
}
