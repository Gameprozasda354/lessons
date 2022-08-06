using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string username = "Omer";
            const string password = "oi_zasda-AZE.24";

            Console.WriteLine("Username-i daxil edin:");
            var username1 = Console.ReadLine();

            Console.WriteLine("Passwordu daxil edin:");
            var password1 = Console.ReadLine();

            if(username1 == username && password1 == password)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }

            else
            {
                Console.WriteLine("Username-i daxil edin:");
                var username2 = Console.ReadLine();

                Console.WriteLine("Passwordu daxil edin:");
                var password2 = Console.ReadLine();

                if (username2 == username && password2 == password)
                {
                    Console.WriteLine("Sisteme daxil olundu.");
                }

                else
                {
                    Console.WriteLine("Username-i daxil edin:");
                    var username3 = Console.ReadLine();

                    Console.WriteLine("Passwordu daxil edin:");
                    var password3 = Console.ReadLine();

                    if (username3 == username && password3 == password)
                    {
                        Console.WriteLine("Sisteme daxil olundu.");
                    }

                    else
                    {
                        Console.WriteLine("Username-i daxil edin:");
                        var username4 = Console.ReadLine();

                        Console.WriteLine("Passwordu daxil edin:");
                        var password4 = Console.ReadLine();

                        if (username4 == username && password4 == password)
                        {
                            Console.WriteLine("Sisteme daxil olundu.");
                        }

                        else
                        {
                            Console.WriteLine("Hesab bloklandi.");
                        }
                    }
                }
            }


        }
    }
}
