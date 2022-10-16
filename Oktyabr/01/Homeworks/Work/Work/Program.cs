using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            string name = Console.ReadLine();
            string surName = Console.ReadLine();

            student.Name(name, surName);

            /*
            string[] name =
            {
                "omer",
                "orkhan",
                "eli",
                "muhammed",
                "ferid"
            };


            Program.Printer(0, name);
            */

        }

        static void Printer(int a,string[] name)
        {
            string b;
            if(a < name.Length)
            {
                b = name[a];
                Console.WriteLine(b);
                a = a + 1;
                Program.Printer(a, name);
                
            }
        }

    }
}
