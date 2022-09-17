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
            Console.WriteLine("Nece reqem olacagini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] ints = new int[count];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i + 1}.reqemi daxil edin.");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            int c = 0;
            for (int i = 0; i < count; i++)
            {
                c = ints[i] + c;
            }
            c = c / count;
            Console.WriteLine("------------");
            Console.WriteLine(c);
            /*
            Homework 1:
                Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.Bunun üçün öncə bütün elementlərin toplamını
                tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
        */
        }
    }
}
