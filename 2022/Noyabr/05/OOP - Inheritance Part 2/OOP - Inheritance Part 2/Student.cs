using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_2
{
    public class Student : Person
    {
        #region Constructor methods while inheritance
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attandance { get; set; } //(davamiyyet 100/0)

        public Student()
        {
            Console.WriteLine("Constructor of Student class");
        }
        #endregion
    }
}
