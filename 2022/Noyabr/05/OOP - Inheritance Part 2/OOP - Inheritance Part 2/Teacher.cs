using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_2
{
    public class Teacher : Person
    {
        #region Constructor methods while inheritance
        public string Branch { get; set; }
        public string Level { get; set; }
        public decimal IsProfessor { get; set; }

        public Teacher()
        {
            Console.WriteLine("Constructor of Teacher class");
        }
        #endregion
    }
}
