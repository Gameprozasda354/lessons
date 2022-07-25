using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;  

            Console.Write("Adınızı daxil edin:");
            var name = Console.ReadLine();

            Console.Write("Soyadınızı daxil edin:");
            var surName = Console.ReadLine();

            Console.Write("Cinsinizi daxil edin(K və ya Q):");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Doğum tarixinizi daxil edin(1990-10-10):");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Yaşadığınız ölkəni daxil edin:");
            var country = Console.ReadLine();

            Console.Write("Yaşadığınız şəhəri daxil edin:");
            var city = Console.ReadLine();

            Console.Write("Boyunuzu daxil edin:");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.Write("Çəkinizi daxil edin:");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Maaşınızı daxil edin:");
            float money = Convert.ToSingle(Console.ReadLine());

        }
    }
}
