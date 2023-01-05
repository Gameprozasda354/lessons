
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Return Type Methods
            //Void Type Methods
            Console.WriteLine();
            System.Console.WriteLine();


            #region Practise with methods
            Student studentInstance = new Student();
            //studentInstance.ShowStudentInfo("Orkhan", "Farajov"); //private method olduğuna görə burada çağıra bilmirik

            studentInstance.ShowHasanInfo();
            #endregion
        }

        static void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
}
