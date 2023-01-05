using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Printer
    {
        public void Printer1(string nameOfClass, string nameOfClassTeacher, params string[] students)
        {
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Sinif məlumatları:");

            Console.WriteLine("Sinifin adı:" + nameOfClass);
            Console.WriteLine("Sinif rəhbərinin adı:" + nameOfClassTeacher);
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i + "." + "Şagirdin adı:" + students[i]);
            }

        }
    }
}
