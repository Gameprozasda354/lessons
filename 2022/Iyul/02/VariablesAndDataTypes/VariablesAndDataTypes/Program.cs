using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Data Type
            string OneString = "1";
            int oneInteger = 1;

            string aString = "a";
            //int aInteger = "a";

            /*
             Byte hesablama düsturu:
             1 byte = 8 bit
             Int16 tipi 16 bit'dir. - 16 bit / 8 bit = 2 byte
             Int32 tipi 32 bit'dir. - 32 bit / 8 bit = 4 byte
             Int64 tipi 64 bit'dir. - 64 bit / 8 bit = 8 byte
             */

            /*
             Value-Type data tipleri:
             bool
             byte
             char
             decimal
             double
             enum
             float
             int
             long
             sbyte
             short
             struct
             uint
             ulong
             ushort

             Referance-Type data tipleri:
             string
             Arrays
             Class
             Delegate

            //NOT: Referance tiplerinin default deyeri her zaman null olur. Ancaq value type data tiplerinin her zaman bir default deyeri olur.
             */
            #endregion



            #region Practice with data types
            #region Boolean Type
            //həcmi: 1 bit
            //dəyər aralığı: true --- false
            //tipi Value-Type

            bool booleanVar = true;
            booleanVar = false;

            bool otherBooleanVar;
            otherBooleanVar = true;

            string falseString = bool.FalseString;
            string trueString = bool.TrueString;
            #endregion



            #region String Type
            //həcmi: hər bir xarakter üçün 1 byte
            //tipi: Referance-Type

            string name_ = "Orkhan";
            Console.WriteLine(name_);

            string surname = "Farajov";
            Console.WriteLine(surname);

            string nameSurname = "Teymur Farajov";

            //Butun herfleri boyuk herfe cevirir
            string upperNameSurname = nameSurname.ToUpper();
            
            //Butun herfleri kicik herfe cevirir
            string lowerNameSurname = nameSurname.ToLower();
            
            //0 indeksi daxil olmaqla Teymur Farajov stringinin 1-ci indexsinden etibaren 5 herf goturur
            string subString = nameSurname.Substring(1, 5);

            //t herfi ile baslayib baslamamasini yoxlayir ve true false deyer qaytarir
            bool startsWith = nameSurname.StartsWith("T");

            //v herfi ile bitib bitmemesini yoxlayir ve true false deyer qaytarir
            bool endsWith = nameSurname.EndsWith("v");

            //stringin uzunlugunu qaytarir
            int length = nameSurname.Length;

            //0 daxil olmaqla indeksini qaytarir (meselen y herfi)
            int indexOf = nameSurname.IndexOf("a");

            //deyisenin deyerinin Equals method'una gonderilen parametrdeki deyerle eyni olub olmamasini yoxlayir.
            bool equals = nameSurname.Equals("Teymur Farajov");
            #endregion




            #region Short, Int, Long Type
            //həcmi:
                //int16: 2 byte
                //int32: 4 byte
                //int64: 8 byte
            //ala bildiyi dəyər aralığı:
                //int16 bit üçün: −32,768 --- 32,767
                //int32 bit üçün: −2147483648 --- 2147483647
                //int64 bit üçün: −9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807
            //tipi:
                //Value-Type

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortValue = 18262;
            short shortValueNegative = -1562;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            int integer = 2458745; 
            int integerValueNegative = -222666;
            
            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 8251156626515854958;
            long longValueNegative = -825115615854958;

            string intToString = integer.ToString();
            #endregion




            #region Task in Lesson 1
            /*
             Task description: Task belədir ki, iki dənə rəqəminiz olacaq. Biri 10 digəri 20 olsun. Siz bu 10 və 20 rəqəmini a və b dəyişənlərində
                               saxlayın. Sonra üçüncü bir c dəyişənində a və b'nin toplamını saxlayın.
             */

            int a1 = 10;
            int b1 = 20;
            int c1 = a1 + b1;
            #endregion




            #region Task in Lesson 2
            /*
             Task description: İki ölkə adını iki ayrı dəyişəndə saxlayın. Məsələn aze adında bir dəyişəndə Azərbaycan dəyərini, tur adında bir dəyişəndə
                               də Türkiyə dəyərini saxlayın. Sonra azeTur adlı üçüncü bir dəyişəndə isə, aze və tur dəyişənlərinin birləşməsini əldə edin.
             */
            string aze = "Azerbaijan";
            string tur = "Turkey";
            string azeTur = aze + " " + tur;
            #endregion




            #region Char Type
            //həcmi: 2 byte
            //tipi: Value-Type

            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string e = "E";
            string f = "F";
            string g = "G";
            string h = "H";

            char charA = 'A';
            char charB = 'B';
            char charC = 'C';
            char charD = 'D';
            char charE = 'E';
            char charF = 'F';
            char charG = 'G';
            char charH = 'H';

            char symbol = '*';
            char whiteSpace = ' ';
            char question = '?';

            char toLower = char.ToLower(charA);
            char toUpper = char.ToUpper(charA);
            bool isLower = char.IsUpper(toLower);
            bool isUpper = char.IsUpper(toUpper);

            bool isNumber = char.IsNumber(charA);
            bool isLetter = char.IsLetter(charA);
            bool isDigit = char.IsDigit(charA);
            bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            #endregion




            #region Byte Type
            //həcmi: 1 byte
            //dəyər aralığı: 0-255
            //tipi: Value-Type

            byte byteVariable = 45;
            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            #endregion



            #region Double Type
            //həcmi: 8 byte
            //precision: 15-16 rəqəm
            //dəyər aralığı: -1.7976931348623157E+308 --- 1.7976931348623157E+308
            //tipi: Value-Type

            double doubleVar = 10.2;
            double doubleVar2 = 25;
            double doubleVar3 = 45.8D; //(Double tipinde reqemin sonuna D herfini qoymaq mecbur deyil)

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            double nan = 0.0 / 0.0;
            double notNan = 5 / 2.5;
            bool resultOfNan = double.IsNaN(nan);
            bool resultOfNotNan = double.IsNaN(notNan);

            double infinity = 0.1 / 0.0;
            double notInfinity = 0.0 / 0.0;
            bool resultOfInfinity = double.IsInfinity(infinity);
            bool resultOfNotInfinity = double.IsInfinity(notInfinity);

            double epl = double.Epsilon;
            double epsilonValue = 4.94065645841247E-324;
            double one = 0.1;

            bool whichIsGreather = one > epsilonValue;
            #endregion


            #region Task in Lesson 3
            /*
             1. Birinci dəyişənə true dəyərini,
             2. İkinci dəyişənə tək dırnaq arasında 'A' hərfini,
             3. Üçüncü dəyişənə RAM'ı nəzərə almaqla 5 rəqəmini,
             4. Dördüncü dəyişənə cüt dırnaq içində Salam sözünü,
             5. Beşinciyə isə 18 dənə 9 rəqəmini verməlisiniz. Trilyondan çox edir.
             */
            bool _1 = true;
            char _2 = 'A';
            byte _3 = 5;
            string _4 = "Salam";
            double _5 = 999999999999999999;
            #endregion



            #region Decimal Type
            //həcmi: 16 byte
            //precision: 28-29 rəqəm
            //dəyər aralığı: -79228162514264337593543950335 --- 79228162514264337593543950335
            //tipi: Value-Type

            decimal decimalVar = 10.2M;
            
            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            decimal minusOneValue = decimal.MinusOne; //-1

            //byte decimalToByte = decimal.ToByte(10000000);
            //sbyte decimalToSByte = decimal.ToSByte(10000000);

            short decimalToShort = decimal.ToInt16(500);
            int decimalToInt = decimal.ToInt32(222156);
            long decimalToLong = decimal.ToInt64(5156156156156156156);
            #endregion



            #region Float Type
            //həcmi: 4 byte / 32 bit
            //precision: 7 rəqəm
            //dəyər aralığı: -3.40282347E+38 --- 3.40282347E+38
            //tipi: Value-Type

            float floatVar = 10.2F;
            
            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            #endregion




            #region DateTime Type
            //həcmi: 8 byte
            //dəyər aralığı: 1/1/0001 12:00:00 AM --- 12/31/9999 11:59:59 PM
            //tipi: Value-Type

            DateTime now = DateTime.Now; //(Local saati goturur)
            DateTime utcNow = DateTime.UtcNow; //(UTC = Coordinated Universal Time)

            long ticks = now.Ticks;
            int milliseconds = now.Millisecond;
            int seconds = now.Second;
            int minute = now.Minute;
            int hour = now.Hour;
            int day = now.Day;
            DayOfWeek dayOfWeek = now.DayOfWeek;
            int month = now.Month;
            int year = now.Year;
            TimeSpan timeSpan = now.TimeOfDay;
            string shortDateString = now.ToShortDateString();
            string longDateString = now.ToLongDateString();
            string shortTimeString = now.ToShortTimeString();
            string longTimeString = now.ToLongTimeString();
            string timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
            string timeFormat2 = now.ToString("MMMM dd");
            string timeFormat3 = now.ToString("dddd, dd MMMM yyyy");
            string timeFormat4 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string timeFormat5 = now.ToString("HH:mm");
            string timeFormat6 = now.ToString("hh:mm");
            string timeFormat7 = now.ToString("ddd, dd MMM yyy HH:mm:ss");

            DateTime monthChanged = now.AddMonths(2);
            DateTime dayChanged = now.AddDays(2);
            DateTime hourChanged = now.AddHours(2);
            DateTime minuteChanged = now.AddMinutes(2);
            DateTime secondChanged = now.AddSeconds(2);
            string changedTime = hourChanged.ToString("HH:mm");

            DateTime specificDate = new DateTime(1990, 12, 25);
            DateTime specificDateAndTime = new DateTime(1995, 12, 24, 10, 05, 59, 100);
            #endregion



            #region Object Type
            //həcmi: 4 byte
            //dəyər aralığı: bütün C# obyektleri
            //tipi: Referance-Type

            object stringVar = "My string";
            object integerVar = 55;
            object boolVar = true;
            object charVar = 'u';
            object dateTimeVar = new DateTime();

            Console.WriteLine(stringVar);
            Console.WriteLine(integerVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(charVar);
            Console.WriteLine(dateTimeVar);
            #endregion



            #region Task in Lesson 4
            /*
             Task description: 3 dənə dəyişən təyin edəcəksiniz. Bunlar double, decimal və float tiplərində olacaq. Dəyərləri də 10.5, 20.5, 30.5 olsun.
             */
            double _dou = 10.5;
            decimal _dec = 20.5M;
            float _flo = 30.5F;
            #endregion

            //Etrafli: https://condor.depaul.edu/sjost/nwdp/notes/cs1/CSDatatypes.htm
            #endregion



            #region Assign one to another
            string orkhan = "Orkhan Farajov";
            string john = "John Farajov";

            orkhan = john;
            john = orkhan;

            orkhan = "hello";
            john = "hi";

            int fiveHundred = 500;
            int fiveHundredCopied = fiveHundred;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            isWinterCold = false; //Eger isti iqlimli olke ucundurse deyeri sonradan deyisdirile biler;

            int five = 5;
            int fiveCopied = five;

            char p = 'p';
            char pCopied = p;
            #endregion




            #region Task in Lesson 5
            /*
             Task description: İki dənə dəyişəniniz olacaq. Biri indiki tarixi saxlayacaq, digəri isə 20 dekabr 2020-ci ilin tarixini.
             */
            DateTime _d1 = DateTime.Now;
            DateTime _d2 = new DateTime(2020, 12, 20);
            #endregion




            #region Default values of data types
            //referance-types
            string defaultString;
            object defaultObject;
            Student defaultStudentClass;

            //value-types
            char defaultChar;
            byte defaultByte;
            short defaultShort;
            int defaultInt;
            long defaultLong;
            double defaultDouble;
            decimal defaultDecimal;
            float defaultFloat;
            bool defaultBoolean;
            DateTime defaultDateTime;
            #endregion
        }
    }
}
