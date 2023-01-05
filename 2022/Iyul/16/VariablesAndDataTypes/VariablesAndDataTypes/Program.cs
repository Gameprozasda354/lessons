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


            #region Local and Global variable levels
            //Level 5 - Bütün skoplara görə əlçatan (Main skopu içində)
            int level5 = 500;
            //level4 -= 100; //level4 does not exist
            //level3 -= 100; //level4 does not exist
            //level2 -= 100; //level4 does not exist
            //level1 -= 100; //level4 does not exist
            {
                //Level 4 - Alt skoplara görə global, üst skoplara görə local
                int level4 = 400;

                level5 -= 100;
                //level3 -= 100; //level4 does not exist
                //level2 -= 100; //level4 does not exist
                //level1 -= 100; //level4 does not exist
                {
                    //Level 3 - Alt skoplara görə global, üst skoplara görə local
                    int level3 = 300;

                    level5 -= 100;
                    level4 -= 100;
                    //level2 -= 100; //level4 does not exist
                    //level1 -= 100; //level4 does not exist
                    {
                        //Level 2 - Alt skoplara görə global, üst skoplara görə local
                        int level2 = 200;

                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        {
                            //Level 1 -tamamilə local dəyişən
                            int level1 = 100;
                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                        }
                    }
                }
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
