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
            //Programda bir cox xetalar cixir,
            //bu xetalarin aradan qaldirilmasi exception handling adlanir.
            //Meselen:
            int a = Convert.ToInt32(Console.ReadLine());
            //Burda istifadeci reqem yerine soz yazsa "Input string was not in a correct format"
            //erroru cixacaq
            //Diger bir halda:
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(13);
            list.Add(14);

            //Console.WriteLine(list[5]);

            //Bu zaman "Index was out of range" erroru cixacaq lakin biz bunu istifadeciye aydin dilde catdirmaq ucun biz bu kodu bele deyisdirmeliyik:

            try
            {
                Console.WriteLine(list[5]);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Axtardiginiz element tapilmadi.");
            }

            //Bu zaman eger xeta cixarsa "Axtardiginiz element tapilmadi." mesaji cixacaq

            //Biz try catch ile yalniz bir yox bir cox error ucun kod yaza bilerik.
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());

                List<int> ints = new List<int>();   
                ints.Add(b);
                ints.Add(c);
                ints.Add(d);

                Console.WriteLine(ints[4]);


            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Axtardiginiz element tapilmadi.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin");
            }

            

        }
    }
}
