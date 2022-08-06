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

            Console.WriteLine("Birinci deyeri daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci deyeri daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Cixma");
            Console.WriteLine("3.Vurma");
            Console.WriteLine("4.Bolme");

            int c = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Console.WriteLine("Netice" + (a + b));
                    Console.WriteLine("Sonlandirmaq ucun x yazin.");
                    Console.WriteLine("Birinci deyeri daxil edin:");
                    int a1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ikinci deyeri daxil edin:");
                    int b1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1.Toplama");
                    Console.WriteLine("2.Cixma");
                    Console.WriteLine("3.Vurma");
                    Console.WriteLine("4.Bolme");

                    int c1 = Convert.ToInt32(Console.ReadLine());

                    switch (c1)
                    {
                        case 1:
                            Console.WriteLine("Netice" + (a1 + b1));

                            break;
                        case 2:
                            Console.WriteLine("Netice" + (a1 - b1));
                            break;
                        case 3:
                            Console.WriteLine("Netice" + (a1 * b1));
                            break;
                        case 4:
                            Console.WriteLine("Netice" + (a1 / b1));
                            break;
                    }
                    goto case 1;
                    break;
                case 2:
                    Console.WriteLine("Netice" + (a - b));
                    Console.WriteLine("Birinci deyeri daxil edin:");
                    int a2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ikinci deyeri daxil edin:");
                    int b2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1.Toplama");
                    Console.WriteLine("2.Cixma");
                    Console.WriteLine("3.Vurma");
                    Console.WriteLine("4.Bolme");

                    int c2 = Convert.ToInt32(Console.ReadLine());

                    switch (c2)
                    {
                        case 1:
                            Console.WriteLine("Netice" + (a2 + b2));

                            break;
                        case 2:
                            Console.WriteLine("Netice" + (a2 - b2));
                            break;
                        case 3:
                            Console.WriteLine("Netice" + (a2 * b2));
                            break;
                        case 4:
                            Console.WriteLine("Netice" + (a2 / b2));
                            break;
                    }
                    goto case 2;
                    break;
                case 3:
                    Console.WriteLine("Netice" + (a * b));
                    Console.WriteLine("Birinci deyeri daxil edin:");
                    int a3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ikinci deyeri daxil edin:");
                    int b3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1.Toplama");
                    Console.WriteLine("2.Cixma");
                    Console.WriteLine("3.Vurma");
                    Console.WriteLine("4.Bolme");

                    int c3 = Convert.ToInt32(Console.ReadLine());

                    switch (c3)
                    {
                        case 1:
                            Console.WriteLine("Netice" + (a3 + b3));

                            break;
                        case 2:
                            Console.WriteLine("Netice" + (a3 - b3));
                            break;
                        case 3:
                            Console.WriteLine("Netice" + (a3 * b3));
                            break;
                        case 4:
                            Console.WriteLine("Netice" + (a3 / b3));
                            break;
                    }
                    goto case 3;
                    break;
                case 4:
                    Console.WriteLine("Netice" + (a / b));
                    Console.WriteLine("Birinci deyeri daxil edin:");
                    int a4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ikinci deyeri daxil edin:");
                    int b4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1.Toplama");
                    Console.WriteLine("2.Cixma");
                    Console.WriteLine("3.Vurma");
                    Console.WriteLine("4.Bolme");

                    int c4 = Convert.ToInt32(Console.ReadLine());
                    switch (c4)
                    {
                        case 1:
                            Console.WriteLine("Netice" + (a4 + b4));

                            break;
                        case 2:
                            Console.WriteLine("Netice" + (a4 - b4));
                            break;
                        case 3:
                            Console.WriteLine("Netice" + (a4 * b4));
                            break;
                        case 4:
                            Console.WriteLine("Netice" + (a4 / b4));
                            break;
                    }
                    goto case 4;
                    break;
            }

           

        }

    }
}
