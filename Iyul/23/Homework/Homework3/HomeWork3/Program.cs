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
