using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static classes
            //Helper helper = new Helper(); //error verecek
            Helper.SayHi();
            #endregion

            #region Constructor of static class
            Employee emp = new Employee();
            emp.Name = "Orkhan";
            emp.Surname = "Farajov";
            emp.Email = "orkhan";

            Employee emp2 = new Employee();
            emp2.Name = "Orkhan";
            emp2.Surname = "Farajov";
            emp2.Email = "orkhan";
            #endregion

            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
        }
    }
}
