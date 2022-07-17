using System;
using System.Text;

namespace VariablesAndDataTypesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple form app
            //Unicode = Universal Code
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Salam, xoş gəlmisiniz!");

            Console.WriteLine("Adınızı daxil edin:");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı daxil edin:");
            string surname = Console.ReadLine();

            Console.WriteLine("Doğulduğunuz ölkəni daxil edin:");
            string country = Console.ReadLine();

            Console.WriteLine("Boyunuzu daxil edin:");
            string height = Console.ReadLine();

            Console.WriteLine("Çəkinizi daxil edin:");
            string weight = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Weight: " + weight);
            Console.ReadLine();
            #endregion
        }
    }
}
