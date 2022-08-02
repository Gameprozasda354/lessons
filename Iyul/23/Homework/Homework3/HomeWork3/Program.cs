using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız. Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
             edəcəksiniz. Daha sonra int dəyişənini byte tipinə cast edəcəksiniz (explicit conversion).
             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
             tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.
            */

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Yaşınızı daxil edin:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maaşınızı daxil edin:");
            int money = Convert.ToInt32(Console.ReadLine());

            Console.Write("Boyunuzu daxil edin:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Çəkinizi daxil edin:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Neçə dostunuz olduğunu daxil edin:");
            int friends = Convert.ToInt32(Console.ReadLine());

            checked
            {
                byte age1 = (byte)age;
                byte money1 = (byte)money;
            }
            
            byte height1 = (byte)height;
            byte weight1 = (byte)weight;
            byte friends1 = (byte)friends;

            Console.ReadLine()


        }
    }
}
