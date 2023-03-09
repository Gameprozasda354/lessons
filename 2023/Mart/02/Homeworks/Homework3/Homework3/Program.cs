using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tuple Bize bir cox dataya sahip elementleri saxlamaga komek edir.
            //Tuple-den evvel biz bunu ferqli yollarla ede bilerik.Meselen:
            //Classlar ile ve ya Struct  tiplerle.
            //Lakin tuplelardan sonra bu isi etemek bezi yerlerde asanlasir.
            //Bir cox data structure typelari sonsuz sayda element saxlaya bilir lakin Tuple limitli sayda element saxlaya bilir.
            //Biz Tuple-i 2 esas yolla yarada bilerik.Birincisi Constructor methodlarla:

            Tuple<string, string, int> My_Tuple = new Tuple<string, string, int>("SomeBody", "C#", 29);
            //Ikincisi Create methodu ile:
            var My_Tuple2 = Tuple.Create("SomeBody", "C#", 29);
        }
    }
}
