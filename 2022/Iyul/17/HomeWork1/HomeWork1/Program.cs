using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Salam, xoş gəlmisiniz!");
            Console.WriteLine("");
            Console.Write("Zəhmət olmasa adınızı daxil edin:");
            var name = Console.ReadLine() + " ";

            Console.Write("Zəhmət olmasa sizə necə müraciət olunacağını daxil edin(bəy/xanım):");
            var mrMs = Console.ReadLine() + " ";

            Console.Write(name  + mrMs + "neçə yaşınız var?");
            var age = Console.ReadLine();

            Console.Write(name + mrMs + "hansı sahədə işləyirsiniz?");
            var work = Console.ReadLine();

            Console.Write(name + mrMs + "ən son nə zaman kitab oxumusunuz?");
            var lastReadedBook = Console.ReadLine();

            Console.Write(name + mrMs + "sevdiyiniz rəng hansıdır?");
            var lovelycolor = Console.ReadLine();

            Console.Write(name + mrMs + "avtomobil idarə edə bilirsiniz?");
            var driveCar = Console.ReadLine();

            Console.Write(name + " " + mrMs + "gündə neçə saat yatırsınız?");
            var sleepHowManyHoursINADay = Console.ReadLine();

            Console.Write(name + " " + mrMs + "TV kanallarını izləyirsiniz?");
            var watcingTvShows = Console.ReadLine();

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Anketə qatıldığınız üçün təşəkkür edirik!");
            Console.WriteLine("Anketi sonlandırmaq üçün Entere basın.");

            Console.ReadLine();


            
        }
    }
}
