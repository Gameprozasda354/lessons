using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How to create a instance of Arrays
            //Numune 1:
            int[] numArray = new int[6];
            numArray[0] = 100;
            int getVal = numArray[0];

            //Numune 2:
            int[] secondNumArray;
            secondNumArray = new int[6]; //(heap'de yaranib ref adresi stack'e kocurulur)

            //Numune 3:
            int[] thirdNumArray = new int[6]
            {
                1,
                2,
                3,
                4,
                5,
                6
            };
            //thirdNumArray[7] = 12;


            //Numune 4:
            int[] fourthNumArray = new int[]
            {
                10,
                20,
                30,
                40,
                50
            };
            #endregion



            #region Use Arrays with diffrent data types
            //string
            string[] names = new string[5];
            names[0] = "Orkhan";
            names[1] = "John";
            names[2] = "Mark";
            names[3] = "Jeff";
            names[4] = "Bill";

            var orkhan = names[0];
            var john = names[1];
            var mark = names[2];
            var jeff = names[3];
            var bill = names[4];
            //var indexOutOfRangeEx = names[5];

            //char
            char[] alphabet = new[]
            {
                'A',
                'B',
                'C',
                'D'
            };

            char a = alphabet[0];
            char b = alphabet[1];
            char c = alphabet[2];
            char d = alphabet[3];

            //object
            object[] objArr = new object[7];
            objArr[0] = 5;
            objArr[1] = "string type";
            objArr[2] = true;
            objArr[3] = 2.5f;
            objArr[4] = DateTime.Now;
            objArr[5] = 99999999999999999;

            DateTime date = new DateTime(1995, 12, 24);
            objArr[6] = date;

            int intType = (int)objArr[0];
            string stringType = (string)objArr[1];
            bool boolType = (bool)objArr[2];
            float floatType = (float)objArr[3];
            DateTime dateTimeType = (DateTime)objArr[4];
            long longType = (long)objArr[5];
            DateTime dateTimeType2 = (DateTime)objArr[6];
            #endregion



            #region Loop Arrays
            //Console.WriteLine("Sinifde nece telebe var?");
            //short studentCount = Convert.ToInt16(Console.ReadLine());

            //string[] students = new string[studentCount];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(i + ". Telebenin adini daxil edin: ");
            //    string studentName = Console.ReadLine();
            //    students[i] = studentName;
            //}
            /*
            #region Work1
            Console.WriteLine("Sinifdeki usaqlarin sayini daxil edin:");
            int peoplecount = Convert.ToInt32(Console.ReadLine());

            string[] people = new string[peoplecount];

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Sagirdin adini daxil edin:");
                people[i] = Console.ReadLine();

            }
            Console.WriteLine("");
            for (int i = 0; i < peoplecount; i++)
            {
                Console.WriteLine($"{people[i]} ");
            }
            #endregion

            #region Work2
            Console.WriteLine("Sinifdeki usaqlarin sayini daxil edin:");
            int peoplecount1 = Convert.ToInt32(Console.ReadLine());

            string[] people1 = new string[peoplecount1];
            int[] age = new int[peoplecount1];

            for (int i = 0; i < people1.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Sagirdin adini daxil edin:");
                people1[i] = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Sagirdin yasini daxil edin:");
                age[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < peoplecount1; i++)
            {
                Console.Write($"{people1[i]}:");
                Console.WriteLine($"{age[i]}");
            }

            foreach (var item in people1)
            {
                Console.WriteLine(item);
            }
            #endregion
            */
            #endregion



            #region Multidimensional Array
            //5x2 (Matris Array)
            int[,] _5x2 =
            {
                { 1, 2},
                { 3, 4},
                { 5, 6},
                { 7, 8},
                { 9, 10}
            };

            //(Jagged Array)
            int[][] jaggedArray = new int[][]
            {
                new int[2] {100, 200},
                new int[6] { 101, 102, 103, 104, 105, 106},
                new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                new int[] { 1000, 2000, 3000, 4000, 5000}
            };

            jaggedArray[0][0] = 500;
            jaggedArray[0][1] = 600;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int x = 0; x < jaggedArray[i].Length; x++)
                {
                    Console.WriteLine(i + "." + x + ": " + jaggedArray[i][x]);
                }
            }
            #endregion



            #region Array methods
            /*
             Properties:
                IsFixedSize - Element saylarinin sabit olub olmamagini bildirir (bool)
                IsReadOnly - Element deyerlerinin deyisdirile bilmesi barede melumat (bool)
                Length - Array'in olcusunu (nece elementi oldugunu) barede melumat (int)
             Methods:
                Clone() - Array'i oldugu kimi klonlayir.
                Array.IndexOf() - bir array'daki elementin index'ini verir.
                CopyTo() - Array'i basqa bir Array'a kopyalayir.
                Sort() - Artan sira ile siralayir.
                Reverse() - Tersine siralayir.
                Clear() - Array'in elementlerinin deyerlerini default deyere reset edir.
             */

            string[] persons = new string[]
            {
                "Orxan Ferecov",
                "Bill Gates",
                "Steve Jobs",
                "Mark Zuckenberg"
            };

            bool isFixedSize = persons.IsFixedSize;
            bool isReadOnly = persons.IsReadOnly;
            int length = persons.Length;

            var clonedArray = persons.Clone();

            int orkhansIndex = Array.IndexOf(persons, "Orxan Ferecov");

            string[] copiedPersons = new string[10];
            persons.CopyTo(copiedPersons, 4);

            Array.Sort(persons);

            Array.Reverse(persons);

            Array.Clear(persons, 2, 1);
            #endregion
            #region work3
            


            #endregion
        }
    }
}
