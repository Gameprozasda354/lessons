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

            Student student = new Student();

            student.Name = "Orkhan"; 
            student.SurName = "Farajov";

            Console.WriteLine(student.Email);

            Console.ReadLine();

        }
    }
}
