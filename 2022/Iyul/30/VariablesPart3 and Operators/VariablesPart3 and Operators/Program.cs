using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPart3_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //Implicit
            int valueType = 100; //Stack'da saxlanilir.
            object referanceType = valueType;

            //Explicit
            object otherRefType = (object)valueType;

            int a = 100;
            object o = a; //Boxing edende Explicit conversion mecburi deyil
            int unboxing = (int)o;

            //error example InvalidCastException
            int b = 100;
            object o1 = b;
            //int err = (byte)o1;
            #endregion



            #region Convert, Parse and TryParse
            string textNumber = "100";

            //with Convert
            int convertToInt = Convert.ToInt32(textNumber);

            //with Parse method
            int parseToInt = int.Parse(textNumber);

            //with TryParse
            int integerValue;

            string notNumberString = "5Salam";
            bool badResult = int.TryParse(notNumberString, out integerValue); //0: default value

            string numberString = "55";
            bool goodResult = int.TryParse(numberString, out integerValue); //55 parse result

            #region Task in Lesson 1
            /*
             Task description:
             Bir boolean tipində dəyişənin olsun və dəyəri də true olsun. Bir dənə də int tipində dəyişən yaradıb dəyərini 1 set et.
             Bu int dəyişəninə dəyəri 1 set edəndən sonra, elə etməlisən ki, boolean tipində dəyişəni necəsə konvertasiya edib 0 dəyərini əldə
             edəsən. Convert, Parse və ya TryParse'dan istifadə etmək haqqın var. Kodun heç bir yerində, false və ya 0 rəqəmindən istifadə
             etmək olmaz.
             */
            //Həlli:
            bool booleanVar = true;
            string stringVar = Convert.ToString(booleanVar);
            int resultOfTryParse = 1;
            bool parse = int.TryParse(stringVar, out resultOfTryParse);
            int result = Convert.ToInt32(parse);
            #endregion


            string nullString = null;
            int nullConvertResult = Convert.ToInt32(nullString); //(returns default value)
            //int nullParseResult = int.Parse(nullString); //(error)
            int nullOutVal = 2;
            bool tryToParseNull = int.TryParse(nullString, out nullOutVal); //(returns default value)


            string notIntString = "A";
            //int notIntConvertResult = Convert.ToInt32(notIntString); //(error)
            //int notIntParseResult = int.Parse(notIntString); //(error)
            int notIntOutVal = 2;
            bool tryToParsenotInt = int.TryParse(notIntString, out notIntOutVal); //(returns default value)
            #endregion


            #region Task in Lesson
            /*
                Task 1: İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri 1, digərinin dəyəri 0 olacaq.
                        Sonra bu iki int tipindən başqa boolean tipində 2 dəyişəniniz olacaq. Bu iki int tipində
                        olan dəyişəninizi digər iki boolean tipində dəyişənə çevirəcəksiz.
                
                Task 2: Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürün. Sonra o dəyişəni
                        bir başqa object tipindəki dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində 3-cü
                        bir dəyişən yaradın və 2-ci yaratdığınız object'in dəyərini 3-cü yaratdığınız DateTime 
                        tipində olan dəyişənə verin.

                Task 3: İki string tipində dəyişəndə True və False sözlərini saxlayın. Sonra bu string'ləri bool
                        tipində bir dəyişənə çevirin. Convert'dən istifadə etmək olmaz.
            */
            //1
            int falseValue = 0;
            int trueVal = 1;
            //bool falseBool = falseValue;
            //bool trueBool = (bool)trueVal;
            bool trueBool1 = Convert.ToBoolean(trueVal);

            //2
            DateTime now = DateTime.Now;
            object objDate = now;
            var dateFromObject = Convert.ToDateTime(objDate);

            //3
            string trueText = "True";
            bool trueFromText = bool.Parse(trueText);

            string falseText = "False";
            bool falseFromText = bool.Parse(falseText);
            #endregion


            #region Constant
            //3.14

            double pi = 3.14;
            //Bir ay keçdi...
            pi = 5.20;

            const double piConst = 3.14;
            //piConst = 5.20;

            int no; //burada teyin etdim
            no = 100; //deyerini burda verdim

            decimal dec;
            dec = 45.6m;

            string name;
            name = "Omer";

            DateTime dt;
            dt = DateTime.Now;

            //const int aa; //deyer vermeden const bir deyisen teyin etmek olmaz
            const int number = 500; //deyeri set edilmeye mecburdur
                                    //const int buildingNo = no; //constant ancaq constant bir deyer qebul edir
            #endregion

            #region Var keyword
            int number1 = 1;
            string text = "Hello baby";
            decimal dec1 = 45.3M;
            double dob = 100.20D;
            DateTime dt1 = DateTime.Now;
            char ch = '2';
            long l = 888555222111;
            short s = 10000;

            var numberVar = 1;
            var textVar = "Hello baby";
            var decVar = 45.3M;
            var dobVar = 100.20D;
            var dtVar = DateTime.Now;
            var chVar = '2';
            var lVar = 888555222111;
            var sVar = 10000;

            var p = 100;
            //p = "salam"; //(implicitly convert xətası)

            var dbl = 45.5D;
            //dbl = true; //(implicitly convert xətası)

            var dtt = DateTime.Now;
            //dtt = '5'; //(implicitly convert xətası)

            //Var'a set etdiyin deyer, compile-time zamani IL'e type inference edilerek elave olunur.
            //IL = Intermediate Language
            //var a = null;

            object objectVariable = 1;
            objectVariable = "Test";
            objectVariable = true;
            objectVariable = '$';
            objectVariable = DateTime.Now;

            /*
             ad,soyad, doguldugu yer, sevdiyi reng (bir dene noqte vergulden istifade etmek haqqin olsaydi bunu nece yazardin?)
             */

            //string firstName = "Orkhan";
            //string lastName = "Farajov";
            //string birthPlace = "Baku";
            //string color = "White";


            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);
            //Console.WriteLine(birthPlace);
            //Console.WriteLine(color);

            int number_1, number_2, otherNumber;
            string name1, surname, fatherName, birthPlace;
            DateTime startDate, endDate;
            int no1 = 20, no2 = 40, no3 = 60;
            string firstname = "Orkhan", lastname = "Farajov", color = "White";
            #endregion


            #region Operators
            /*
             Qeyd:
                1. Unary: a++, b--, !true;
                2. Binary: a + b, a > b, a = b, a < b;
                3. Ternary: a > b ? "" : "" (shorthand if else)
                Operator nədir?: +, -, *, !, !=
                Operand nədir?: a, b, c (dəyişən və s.)



                1. Arithmetic (hesablama)     ++, --, +, -, *, /, %
                2. Logical    (məntiqi)       !, ||, && 
                3. Special    (xüsusi)        sizeof, typeof, new, checked, unchecked, as, is
                4. Assignment (mənimsəmə)     =, +=, -=, /=, *=, %=
                5. Comparsion (qarşılaşdırma) >, <, ==, !=, <=, >=
             */

            decimal x = 100;
            decimal y = 5;
            decimal i = 0;

            //Arithmetic (hesablama)
            i = x + y;
            i = x - y;
            i--; //(i = i - 1) ilə eynidir
            i++; //(i = i + 1) ilə eynidir
            i = i - 1;
            i = i + 1;
            i -= 5; //(i bərabərdir i çıx 5)
            i += 5; //(i bərabərdir i üstəgəl 5)
            i = x--; //(x-dən 1 çıx, i-yə mənimsət. Burada x'in də dəyəri azalmış olur)
            i = y * 5;
            i = x / 5; //(cavab 5.1, 5.5 və ya 5.9 belə olsa belə, əgər bölən-bölünən int tipindədirsə cavab 5 olacaq yəni aşağı round olacaq.)
            i = x * y;
            i = x / y;
            i = x % y; //(modul)
            int m = 10 % 2; //(cavab 0 olacaq)
            m = 11 % 2; //(cavab 1 olacaq)
            string country = "Azerbaijan";
            string city = "Baki";
            string address = country + " " + city;


            //Logical (məntiqi)
            bool trueBool = true, falseBool = false, res;
            res = !trueBool;
            res = !falseBool;
            res = !falseBool || !trueBool;
            res = !falseBool && !trueBool;
            res = 5 == 5;


            //Assignment (mənimsəmə) - (bir dəyişənə dəyər mənimsətmək üçün istifadə olunur)
            int assign = 100;
            assign += 5; //(assign = assign + 5)
            assign -= 5; //(assign = assign - 5)
            assign /= 5; //(assign = assign / 5)
            assign *= 5; //(assign = assign * 5)
            assign %= 2; //(assign = assign % 2)
            string person = "Orkhan Farajov";
            person += " is developer";


            //Comparsion (qarşılaşdırma)
            int c = 100;
            int d = 5;
            string firstname1 = "Orkhan";
            string firstname2 = "John";

            bool compareRes = false;
            compareRes = c > d;
            compareRes = c < d;
            compareRes = c == d;
            compareRes = c != d;
            compareRes = c <= d;
            compareRes = c >= d;
            compareRes = firstname1 == firstname2;
            //compareRes = firstname1 == c; //(string və int tipində operandlar qarşılaşdırıla bilməz)
            res = (10 / 2) == 5;
            res = (10 / 2) != 5;


            //Special (xüsusi) sizeof, typeof, new, checked, unchecked, as, is
            int sizeOfSByte = sizeof(sbyte);
            int sizeOfByte = sizeof(byte);
            int sizeOfInt16 = sizeof(Int16);
            int sizeOfShort = sizeof(short);
            int sizeOfInt32 = sizeof(Int32);
            int sizeOfInt = sizeof(int);
            int sizeOfInt64 = sizeof(Int64);
            int sizeOfLong = sizeof(long);
            int sizeOfULong = sizeof(ulong);
            int sizeOfUInt = sizeof(uint);
            int sizeOfBool = sizeof(bool);
            //int sizeOfString = sizeof(string); //error

            Type type1 = typeof(int);
            Type type2 = typeof(Int32);

            Type type3 = typeof(int);
            Type type4 = typeof(bool);
            bool compareIntAndBool = type3 == type4;

            DateTime dt5 = new DateTime();

            //is
            int otherInt = 25;
            bool isOtherInt_String = otherInt is string;
            bool isOtherInt_Int = otherInt is int;
            bool isOtherInt_Int32 = otherInt is Int32;
            bool isOtherInt_Int64 = otherInt is Int64;

            //as
            object objectName = "Orkhan";
            object objectNum = 5;
            string sName = objectName as string;
            string sText = objectNum as string;
            //int aaa = sName as int; //error



            //10 * 20 / 5
            float u = 10 * 20 / 5; //40
            float u1 = (10 * 20) / 2; //100
            #endregion
        }
    }
}
