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
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Texmin oyunu ucun en boyuk reqemi daxil edin!");
            int game = Convert.ToInt32(Console.ReadLine());

            if(game <= 0)
            {
                Console.WriteLine("Zəhmət olmasa 0-dan böyük ədəd daxil edin!");
            }
            int gamecount = 1;
            Random random = new Random();
            int countinthegame = random.Next(1, game);
            bool gametime = true;
            while (gametime)
            {
                Console.WriteLine($"{gamecount}. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin:");
                int count = Convert.ToInt32(Console.ReadLine());

                if (count == countinthegame)
                {
                    Console.WriteLine($"{gamecount}. Cəhdinizdə düzgün rəqəmi tapdınız!");
                    gametime = false;
                }
                else
                    gamecount = gamecount + 1;
            }
            Console.ReadLine();
        }
    }
}
