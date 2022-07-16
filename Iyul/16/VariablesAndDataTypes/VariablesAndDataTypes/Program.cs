using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string Country { get; set; } = "Azerbaijan";

        static void Main(string[] args)
        {
            #region Local vs Global Variables
            Console.WriteLine(Country);

            int myLocalVariable = 5;
            Console.WriteLine(myLocalVariable);

            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }
            #endregion

            Console.ReadLine();
        }

        public static void ShowCountry()
        {
            Console.WriteLine(Country);
        }
    }
}
