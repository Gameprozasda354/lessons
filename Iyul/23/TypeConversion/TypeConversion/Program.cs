using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Type Conversion
            /*
              C#'da 4 nov Type Conversion tipi var.
                -Implicit Type Conversion
                -Explicit Type Conversion
                -User-Defined Type Conversion
                -Helper Class
             */

            #region Implicit Type Conversion
            //Numune 1:
            byte byteVal = byte.MaxValue; //255
            short shortVal = short.MaxValue; //32767
            short takeByteVal = byteVal; //Implicit Conversion
            //byte takeShortVal = shortVal; //Xeta

            //Numune 2:
            int takeShortVal = shortVal; //Implicit Conversion

            //Numune 3:
            int takeBtVal = byteVal; //Implicit Conversion

            //Numune 4:
            int i = 5000;
            long l = i;

            long l2 = 5000000;
            float f = l2;

            float f2 = 25.6F;
            double d = f2;

            //Cannot implicitly convert type A to B
            //Ardicilliq: byte -> short -> int -> long -> float -> double
            #endregion





            #region Signed - Unsigned variables
            //Hem musbet, hem de menfi deyer saxlaya bilen data tipleri, signed data tipleridir
            //Sadece musbet deyer saxlayan data tipleri ise, unsigned data tipleridir

            //Unsigned data types
            byte us1 = byte.MinValue;       //8-bit    |   0-255
            ushort us2 = ushort.MinValue;   //16-bit   |   0-65.535
            uint us3 = uint.MinValue;       //32-bit   |   0-4.294.967.295
            ulong us4 = ulong.MinValue;     //64-bit   |   0-18.446.744.073.709.551.615

            //Signed data types
            sbyte s1 = sbyte.MinValue;      //8-bit     |   -128 - 127
            short s2 = short.MinValue;      //16-bit    |   -32.768 - 32.767
            int s3 = int.MinValue;          //32-bit    |   -2.147.483.648 -2.147.483.647
            long s4 = long.MinValue;        //64-bit    |   -9.223.372.036.854.775.808 - 9.223.372.036.854.775.807

            /*
             unsigned ushort deyer araligi: 0 - 65.535
             signed short deyer araligi: -32.768 - 32.767
             32767 - 65535 = 32768
             |-32.768| + 32.767 = 65535
             */

            //Unsigned ve signed tipleri arasinda Implicit Conversion mumkun deyil.
            //uint test = 5000;
            //int test2 = test;
            #endregion



            #region Explicit Type Conversion
            //Explicit Type Conversion ne ucun lazimdir?
            //Numuneler:
            int a = 20000;
            //short b = a;

            double c = 785.22;
            //float k = c;

            short e = 10;
            //ushort p = e;

            float g = 15.5f;
            //long h = g;

            long i3 = 10000000;
            //int j = i3;


            //Numuneler:
            int a1 = 20000;
            short b1 = (short)a1;

            double c1 = 785.22;
            float k = (float)c1;

            short e1 = 10;
            ushort p = (ushort)e1;

            float g1 = 15.5f;
            long h = (long)g1;

            long i1 = 100000000;
            int j = (int)i3;
            //Yazilisi: hedefTip a = (hedefTip)qaynaqDeyisen;
            //Ardicilliq: double -> float -> long -> int - char
            #endregion



            #region Checked & Unchecked keywords
            //Casting without Checked keyword
            //long longVar = Convert.ToInt64(Console.ReadLine()); //9999999999
            //int takeLongVar = (int)longVar;

            //short shortVar = Convert.ToInt16(Console.ReadLine()); //30000
            //byte takeShortVar = (byte)shortVar;

            //Casting with Checked keyword
            checked
            {
                long longVariable1 = Convert.ToInt64(Console.ReadLine()); //9999999999
                int takeLongVariable = (int)longVariable1;
            }

            checked
            {
                int money = Convert.ToInt32(Console.ReadLine()); //100000=error 10=success
                short takeInt = (short)money;


                unchecked
                {
                    byte age = Convert.ToByte(Console.ReadLine()); //200
                    sbyte takeByte = (sbyte)age;
                }
            }
            #endregion


            #region Helper Class Conversion
            string numberString = "50";
            int number;

            //Implicit Conversion numunesi;
            //number = numberString; //(xeta mesaji: Cannot implicitly convert type string to int)

            //Explicit Conversion numunesi;
            //number = (int)numberString; //(xeta: Cannot convert type string to int)

            //Helper Class Conversion numunsei:
            number = Convert.ToInt32(numberString);

            //Not possible:
            //bool booleanVariable = 1;
            //bool booleanVariable = (bool)1;
            //int integerVariable = (int)"1"
            //int integerVariable = (int)true

            //Possible:
            bool booleanVariable;
            booleanVariable = Convert.ToBoolean(1);      //true
            booleanVariable = Convert.ToBoolean("true"); //true //(0/1 yazsaq error verəcək)
            booleanVariable = Convert.ToBoolean(null);   //false

            int integerVariable;
            integerVariable = Convert.ToInt32("10"); //10
            integerVariable = Convert.ToInt32(null); //0
            integerVariable = Convert.ToInt32(true); //1
            integerVariable = Convert.ToInt32(false);//0

            string numString = "45";
            //short stringToShort = numString; //(xəta)
            //short stringToShortCast = (short)numString; //(xəta)
            short stringToShortConvert = Convert.ToInt16(numString); //45

            //int stringToInt = numString; //(xəta)
            //int stringToIntCast = (int)numString; //(xəta)
            int stringToIntConvert = Convert.ToInt32(numString); //45

            //long stringToLong = numString; //(xəta)
            //long stringToLongCast = (long)numString; //(xəta)
            long stringToLongConvert = Convert.ToInt64(numString); //45

            //Source variable types
            int intVariable = 10;
            long longVariable = 99999999;
            short shortVariable = 1000;
            byte byteVariable = 150;
            bool boolVariable = true;

            //Destination string variable
            string getAnyValue;

            getAnyValue = intVariable.ToString();
            getAnyValue = longVariable.ToString();
            getAnyValue = shortVariable.ToString();
            getAnyValue = byteVariable.ToString();
            getAnyValue = boolVariable.ToString(); //True

            bool _boolVariable = Convert.ToBoolean("false");       //false //(0/1 yazsaq error verəcək)
            byte _byteVariable = Convert.ToByte("10");             //unsigned
            char _charVariable = Convert.ToChar("A");
            DateTime _dateTimeVariable = Convert.ToDateTime("2020-12-12");
            decimal _decimalVariable = Convert.ToDecimal("15.2");
            double _doubleVariable = Convert.ToDouble("15.2");
            short _shortVariable = Convert.ToInt16("-25000");      //signed
            int _intVariable = Convert.ToInt32("1500000");
            long _longVariable = Convert.ToInt64("200000000000");
            sbyte _sByteVariable = Convert.ToSByte("12");
            ushort _ushortVariable = Convert.ToUInt16("20");       //unsigned
            uint _uintVariable = Convert.ToUInt32("9500");         //unsigned     
            ulong _ulongVariable = Convert.ToUInt64("8888000000"); //unsigned
            //uint errorInt = Convert.ToUInt32("-100"); //xeta
            //int errorInt2 = Convert.ToInt32("a"); //xeta
            #endregion



            #region User-Defined Conversion
            Student student = new Student("Orkhan", "Farajov", 27);
            string strStudent = student;
            string strStudentCast = (Student)student;
            string strStudentToString = student.ToString();
            #endregion
            #endregion

        }
    }
}
