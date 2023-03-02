using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskinLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Dictionary<string, string> translates = new Dictionary<string, string>();
            //    translates.Add("car", "maşın");
            //    translates.Add("class", "sinif");
            //    translates.Add("presentation", "təqdimat");

            //    Console.WriteLine("Axtardiginiz deyeri daxil edin:");
            //    string value = Console.ReadLine();
            //    string test = translates[value];
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Axtardiginiz deyer tapilmadi.");
            //    Console.WriteLine(
            //}
            //Console.ReadLine();

            Int64 Multiplication(params Int64[] numbers)
            {
                if(numbers.Length == 2)
                {
                    return numbers[0] * numbers[1];
                }
                else
                {
                    return numbers[0] * 10;
                }
            }

            var result = Multiplication(2, 5);
            var wrongResult = Multiplication(2);

            Console.WriteLine($"True input result:{result}, wrong input result:{wrongResult} ");

            
        }
    }
}
