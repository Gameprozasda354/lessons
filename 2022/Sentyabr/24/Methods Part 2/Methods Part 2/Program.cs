using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            ShowDate(now.Day, now.Month); //(year deyerini oturmesek de isleyir)
            ShowDate(now.Day, now.Month, 2023); //(year deyerini oturen zaman deyeri alir)

            int num1 = 0; //stack'da yarandi
            SetRef(ref num1); //num1'in deyeri 10 olacaq

            //int num2 = 0; //(7.0'dan once bele yazilmali idi)
            int num2; //(7.0'dan sonra bele de yazila biler)

            SetOut(out num2);


            Addition(5, 10, 15, 20);
            Addition(5, 10, 15, 20, 25, 30);
            Addition(5, 10, 15, 20, 25, 30, 35, 40, 45, 50);
            Addition(5, 10);

            #region Method Overloading
            AdditionNums(5, 10);
            AdditionNums("10.2", "20.5");
            AdditionNums(2.4M, 5.5M);
            #endregion


            //Uzun versiya
            decimal s = Subtraction(15.5M, 2.5M);
            ShowValue(s);

            //Qisa versiya
            ShowValue(Subtraction(15.5M, 2.5M));


            #region Local functions
            Console.Clear();
            AdditionWithLocalFunc(20, 15);
            SecondAdditionWithLocalFunc(10, 20, 30, 40);
            ThirdAdditionWithLocalFunc(10, 20, 30, 40);
            #endregion
        }

        #region Default parameter values
        public static void ShowDate(int day, int month, int year = 2022) //year burda default value'dur
        {
            Console.WriteLine("Tarix: {0}.{1}.{2}", day, month, year);
        }
        #endregion

        #region Ref and Out keywords
        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }
        #endregion

        #region Flexible (deyisken) sayda parametr almaq
        #region Task in Lesson 1
        static void Addition(int a, params int[] numbers)
        {
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine("Toplam: {0}", total);

            //Qisa versiya
            Console.WriteLine(numbers.Sum());
        }

        //yalnis: (params int[] numbers, int a)
        //dogru: (int a, params int[] numbers)
        #endregion
        #endregion

        #region Method Overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(string num1, string num2)
        {
            decimal total = decimal.Parse(num1) + decimal.Parse(num2);
            Console.WriteLine(total);
        }
        #endregion

        #region Use method as parameter
        static void ShowValue(decimal obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion

        #region Local functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int result = Addition(num1, num2);

            Console.WriteLine(result);
        }

        static void SecondAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int Addition(int num1Local, int num2Local)
            {
                int SecondAddition(int num3Local, int num4Local)
                {
                    return num3Local + num4Local;
                }

                int result = SecondAddition(num3, num4);

                return result + num1Local + num2Local;
            }

            int total = Addition(num1, num2);

            Console.WriteLine(total);
        }

        //(daha seliqeli versiyasi)
        static void ThirdAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int total = 0;

            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int SecondAddition(int num3Local, int num4Local)
            {
                return num3Local + num4Local;
            }

            total += Addition(num1, num2);
            total += SecondAddition(num3, num4);

            Console.WriteLine(total);
        }

        #endregion
    }
}
