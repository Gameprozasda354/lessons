using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Value Data Types
            /*
            sbyte integer tipinde deyer alir byte ilə aralarindakı fərq ondadır ki sbyte mənfi dəyər ala bilir 
            RAMda 8bit yer tutur deyer araligi minimum: -128,maxsimum:127 deyerini ala bilir.

            short integer tipinde deyer alir hemcinin int16 kimi de yazila bilir default dəyəri 0-dır
            RAMda 16bit yer tutur deyer araligi minimum: -32768, maxsimum:32767 deyerini ala bilir.


            int integer tipində dəyər alır həmçinin int32 kimi də yazıla bilir default dəyəri 0-dır
            RAMda 32bit yer tutur dəyər aralığı minimum: -2147483648,maximum:2147483647 deyerini ala bilir.

            long integer tipində dəyər alır həmçinin int64 kimi də yazıla bilir default dəyəri 0l-dır
            RAMda 64bit yer tutur dəyər aralığı minimum: -9223372036854775808,maximum:9223372036854775807 deyerini ala bilir.

            byte integer tipinde deyer alir byte mənfi dəyər ala bilmir default dəyəri 0-dır
            RAMda 8bit yer tutur deyer araligi minimum: 0,maxsimum:255 deyerini ala bilir.

            ushort integer tipinde deyer alir hemcinin uint16 kimi de yazila bilir default dəyəri 0-dır menfi deyer ala bilmir
            RAMda 16bit yer tutur deyer araligi minimum: 0, maxsimum:65535 deyerini ala bilir.

            uint integer tipinde deyer alir hemcinin uint32 kimi de yazila bilir default dəyəri 0-dır menfi deyer ala bilmir
            RAMda 32bit yer tutur deyer araligi minimum: 0, maxsimum:4294967295 deyerini ala bilir.

            ulong integer tipinde deyer alir hemcinin uint64 kimi de yazila bilir default dəyəri 0-dır menfi deyer ala bilmir
            RAMda 64bit yer tutur deyer araligi minimum: 0, maxsimum:18446744073709551615 deyerini ala bilir.

            float  hemcinin single kimi de yazila bilir default dəyəri 0.0F-dir
            RAMda 32bit yer tutur deyer araligi minimum: -3.402823E+38, maximum: 3.402823E+38 deyerini ala bilir.

            double default dəyəri 0.0D-dir
            RAMda 64bit yer tutur deyer araligi minimum: -1.79769313486232E+308, maximum: 1.79769313486232E+308 deyerini ala bilir.

            decimal default dəyəri 0.0M-dir
            RAMda 128bit yer tutur deyer araligi minimum: ±1.0 × 10-28, maximum: ±7.9228 × 1028 deyerini ala bilir.

            char default dəyəri ‘\0’-dir
            RAMda 16bit yer tutur deyer araligi minimum: U +0000, maximum:  U +ffff	 deyerini ala bilir.


             */


            #endregion

            //bool hemde boolean adlanir true veya false olur default deyeri false-dur.

            #region Reference Data Types
            #region string
            /*

            string iki dırnaq içərisində yazılır(məsələn:"Hello world") default deyeri NaN-dir
            string istenilen bir soz veya herf ola biler stringlerde iki stringi toplama onları birləşdirməklə eyni mənaya bərabərdir.
            Meselen:

            */
            string a = "Hello ";
            string b = "World";
            string c = a + b;
            Console.WriteLine(c);

            #endregion

            #region OBJ
            /*

            object default deyeri NaN-dir
            butun data tipleri object data tipine teyin edile bilir.
            Meselen:
            */
            object ob;
            ob = 250;
            int q = 12;
            object o;
            o = q;
            string s = "World";
            char v = 'q';
            bool dogru = true;
            object w = s;
            object x;
            object y;
            x = v;
            y = dogru;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(w);
            Console.WriteLine(o);
            Console.WriteLine(ob);
            #endregion

            #region dynamic

            /*
            dynamic object data tipine oxsardir istenilen data tipini ozunde saxlayir 

            */

            dynamic d = 100;
            Console.WriteLine(d);

            #endregion



            #endregion

            Console.ReadLine();
        }
    }
}
