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
            Item item = new Item();

            Item overload1 = new Item("Mercedes");
            Item overload2 = new Item("Mercedes", "C63S");
            Item overload3 = new Item("Mercedes", "C63S", 1999);
            Item overload4 = new Item("Mercedes", "C63S", 1999, 50000);
            Item overload5 = new Item("Mercedes", "C63S", 1999, 50000, "Dizel");
            Item overload6 = new Item("Mercedes", "C63S", 1999, 50000, "Dizel", 2.7M);
            Item overload7 = new Item("Mercedes", "C63S", 1999, 50000, "Dizel", 2.7M, 30000);
            Item overload8 = new Item("Mercedes", "C63S", 1999, 50000, "Dizel", 2.7M, 30000, 40000);
            Item overload9 = new Item("Mercedes", "C63S", 1999, 50000, "Dizel", 2.7M, 30000, 40000, 200);

            Console.WriteLine("Qiyməti daxil edin:");
            int price = Convert.ToInt32(Console.ReadLine());

            item.Calculator(price);
            Console.WriteLine("------------------");
            item.Print();

            /*
             Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.

             Məhsul (item) Class'ında olacaq property'lər:
                 Marka
                 Model
                 İstehsal ili
                 Km
                 Yanacaq növü
                 Sürətlər qutusu
                 Alış qiyməti
                 Satış qiyməti
                 Max endirim məbləği
                 Qiymət (private olması mütləqdir!)

                Constructor overload'ları aşağıdakı kimi olmalıdır:
                 1. marka, model
                 2. marka, model, istehsal ili
                 3. marka, model, istehsal ili, km
                 4. bütün property'lər

                Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
                satış qiymətini təyin edəcək. Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
                olmalıdır. Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
                Məsələn:
                Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
                satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
             */

        }
    }
}
