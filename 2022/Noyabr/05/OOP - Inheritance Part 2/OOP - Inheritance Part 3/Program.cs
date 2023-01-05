using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sealed class
            /*
             object => Person =>
                                 Employee
                                 Student X
                                 Teacher X
             */

            Test test = new Test();
            //test.
            #endregion

            #region Protected access modifier
            /*
             public : istər proyektin içindən və ya kənarından obyekti əl çatan edir.
             private : bir property'ni və ya bir methodu private təyin etdiyimiz zaman ancaq olduğu class daxilində onu istifadə edə bilirik.
             protected : protected normalda private kimi davranır. Yəni bir method və ya property'ni protected etsəm, onu ancaq
                         class daxilində istifadə edə bilərəm. Ancaq həmin class'dan bir başqa class miras alarsa, o zaman miras alan class
                         üçün public kimi davranır. Bu arada bir class nə private nə də protected təyin edilə bilməz. Ancaq class'ın
                         daxilindəki method və property'lərə aiddir.
             */

            Person p1 = new Person();
            p1.Test();

            Student student = new Student();
            //student.
            #endregion
        }
    }
}
