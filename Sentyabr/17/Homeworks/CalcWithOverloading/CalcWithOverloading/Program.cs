using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Calc calc = new Calc();

            decimal one;
            decimal two;
            decimal three = 0;

        BeginAgain:

            calc.ShowMenu();
            int operationType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Neçə rəqəmli əməliyyatı istəyirsiniz?(2/3)");
            int numberOfOperation = Convert.ToInt32(Console.ReadLine());

            if (numberOfOperation == 2)
            {
                Console.WriteLine("1.ci rəqəmi daxil edin:");
                one = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("2.ci rəqəmi daxil edin:");
                two = Convert.ToDecimal(Console.ReadLine());
            }

            else
            {
                Console.WriteLine("1.ci rəqəmi daxil edin:");
                one = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("2.ci rəqəmi daxil edin:");
                two = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("3.cü rəqəmi daxil edin:");
                three = Convert.ToDecimal(Console.ReadLine());

            }

            string calcType = "";
            decimal result = 0;

            switch (operationType)
            {
                case 1:
                    if (numberOfOperation == 2)
                    {
                        result = calc.Add(one, two);
                    }
                    else
                        result = calc.Add(one, two, three);
                    calcType = "+";
                    break;
                case 2:
                    if (numberOfOperation == 2)
                    {
                        result = calc.Subtracting(one, two);
                    }
                    else
                        result = calc.Subtracting(one, two, three);
                    calcType = "-";
                    break;
                case 3:
                    if (numberOfOperation == 2)
                    {
                        result = calc.Multiple(one, two);
                    }
                    else
                        result = calc.Multiple(one, two, three);
                    calcType = "*";
                    break;
                case 4:
                    if (numberOfOperation == 2)
                    {
                        result = calc.Divide(one, two);
                    }
                    else
                        result = calc.Divide(one, two, three);
                    calcType = "/";
                    break;

            }

            if (numberOfOperation == 2)
                calc.ShowResult(one, two, result, calcType);
            else
                calc.ShowResult(one, two, three, result, calcType);

            Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz? (H/Y)");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "H")
                Console.Clear();
            goto BeginAgain;

            Console.ReadLine();
        }
    }
}
