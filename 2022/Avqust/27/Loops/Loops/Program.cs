using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //47.67
            #region Condition Statements Homework 2
            //string m = "mainMenu";
            //decimal a = 0, b = 0;

            //switch (m)
            //{
            //    case "mainMenu":
            //        Console.WriteLine("A deyeri daxil edin: ");
            //        a = Convert.ToDecimal(Console.ReadLine());

            //        Console.WriteLine("B deyeri daxil edin: ");
            //        b = Convert.ToDecimal(Console.ReadLine());

            //        Console.WriteLine("Etmek istediyiniz emeliyyati secin: ");
            //        Console.WriteLine("1. Toplama");
            //        Console.WriteLine("2. Cixma");
            //        Console.WriteLine("3. Vurma");
            //        Console.WriteLine("4. Bolme");

            //        short choise = Convert.ToInt16(Console.ReadLine());

            //        if (choise == 1)
            //            goto case "toplama";
            //        else if(choise == 2)
            //            goto case "cixma";
            //        else if (choise == 3)
            //            goto case "vurma";
            //        else if (choise == 4)
            //            goto case "bolme";
            //        else
            //            Console.WriteLine("Yanlis emeliyyat secdiniz!");
            //            goto case "mainMenu";


            //    case "toplama" :
            //        Console.WriteLine("Netice: " + (a + b));
            //        goto case "mainMenu";

            //    case "cixma" :
            //        Console.WriteLine("Netice: " + (a - b));
            //        goto case "mainMenu";

            //    case "vurma":
            //        Console.WriteLine("Netice: " + (a * b));
            //        goto case "mainMenu";

            //    case "bolme":
            //        Console.WriteLine("Netice: " + (a / b));
            //        goto case "mainMenu";
            //}
            #endregion

            #region For Loop
            //Numune 1:
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Salam");
            }
            Console.Clear();

            //Numune 2: 0-9
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.Clear();

            //Numune 3: 1-10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.Clear();

            //Numune 4: 0-8
            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.Clear();

            //Numune 5:
            for (int i = 0; i < 100; i += 10)
            {
                Console.WriteLine(i);
            }
            Console.Clear();

            //Numune 6:
            //infinity loop
            //for ( ; ; )
            //{
            //    Console.WriteLine("Hi");
            //}

            //Numune 7: infinity loop 
            //int counter = 0;

            //for ( ; ; counter++)
            //{
            //    Console.WriteLine("Counter: " + counter);
            //}

            //Numune 8:
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Oneline for: " + i);
            Console.Clear();

            //Numune 9:
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine("Counter: " + i);
            }
            Console.Clear();

            //Numune 10: nested loop
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("i: " + i + " --- x: " + x);
                }
            }
            Console.Clear();

            //Numune 11: Yolka agaci
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*
             Task 1: 1-dən 100-ə qədər olan rəqəmlərin toplamını ekrana yazdırın.
             Task 2: Sadəcə cüt rəqəmlərin toplamını ekrana yazdırın.
             */

            //Solution 1:
            int result = 0;
            for (int i = 0; i <= 100; i++)
                result += i;
            Console.WriteLine(result);

            //Solution 2:
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0)
                    result += i;
            }
            Console.WriteLine(result);
            Console.Clear();
            #endregion



            #region While Loop
            //Numune 1:
            //var continueLoop = true;

            //while (continueLoop)
            //{
            //    int sec = DateTime.Now.Second;

            //    if(sec > 30 && sec < 45)
            //    {
            //        Console.WriteLine("End");
            //        break;
            //    }
            //    else //Yazilmaya da biler
            //        Console.WriteLine(sec);
            //}

            //Numune 2:
            int countWhile = 1;
            while (countWhile <= 100)
            {
                Console.WriteLine("Counter: " + countWhile);
                countWhile++;
            }

            //Task 1: Belə bir kiçik app yazın ki, dayanmadan istifadəçidən bir text alın və istifadəçi text yerinə exit sözünü yazana qədər bu davam etsin.
            //Solution 1:
            while (true)
            {
                string text = Console.ReadLine();
                if (text != "exit")
                    Console.WriteLine(text);
                else
                    break;
            }

            //Solution 2:
            var stopLoop = false;
            while (!stopLoop)
            {
                string text = Console.ReadLine();
                if (text != "exit")
                    Console.WriteLine(text);
                else
                    stopLoop = true;
            }
            Console.Clear();
            #endregion

            #region Do While Loop
            bool startChat = false;

            while (startChat)
            {
                if(startChat == false)
                {
                    Console.WriteLine("Sohbet basladilsin? He/Yox");
                    string answer = Console.ReadLine();

                    if (answer == "He")
                        startChat = true;
                    else if (answer == "Yox")
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sehv cavab daxil etdiniz!");
                        Console.WriteLine("Sohbet basladilsin? He/Yox");
                    }
                }
                else
                {
                    Console.WriteLine("Mesajinizi daxil edin: ");
                    string text = Console.ReadLine();

                    if (text == "exit")
                        break;

                    Console.WriteLine(text);
                }
            }

            do
            {
                if (startChat == false)
                {
                    Console.WriteLine("Sohbet basladilsin? He/Yox");
                    string answer = Console.ReadLine();

                    if (answer == "He")
                        startChat = true;
                    else if (answer == "Yox")
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sehv cavab daxil etdiniz!");
                        Console.WriteLine("Sohbet basladilsin? He/Yox");
                    }
                }
                else
                {
                    Console.WriteLine("Mesajinizi daxil edin: ");
                    string text = Console.ReadLine();

                    if (text == "exit")
                        break;

                    Console.WriteLine(text);
                }
            } while (startChat);
            #endregion

            #region Foreach Loop
            string[] citiesArray = new string[10];
            citiesArray[0] = "Baki";
            citiesArray[1] = "Gence";
            citiesArray[2] = "Sumqayit";
            citiesArray[3] = "Seki";
            citiesArray[4] = "Kurdemir";
            citiesArray[5] = "Naxcivan";
            citiesArray[6] = "Quba";
            citiesArray[7] = "Qusar";
            citiesArray[8] = "Lenkeran";
            citiesArray[9] = "Masalli";

            foreach (var item in citiesArray)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Variable declarations inside/outside loop bodies
            string globalVariableName = "Orkhan";

            for (int i = 0; i < 5; i++)
            {
                globalVariableName = "Name can change here";
            }

            for (int i = 0; i < 5; i++)
            {
                string localVariableSurname = "Farajov";
                localVariableSurname = "OtherValue";
            }

            //localVariableSurname = "Surname can't change here";
            Random rand = new Random();
            int a = rand.Next(1, 100);
            #endregion

            Console.ReadLine();
        }
    }
}
