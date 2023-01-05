using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAppPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            //typeOfVariable nameOfVariable = valueOfVariable
            string person = "Orkhan Farajov";
            Console.WriteLine(person);


            string anotherPerson;
            anotherPerson = "Orkhan";
            Console.WriteLine(anotherPerson);

            string name = "Orkhan";
            Console.WriteLine(name);

            name = "Omer";
            Console.WriteLine(name);

            name = "Ferhad";
            Console.WriteLine(name);

            Console.ReadLine();
            #endregion


            #region Naming Convention
            /*
             Nümunə dəyişən adları:
             _nameSurname (private üçün. gələcəkdə izah edəcəm private'ın nə olduğunu)
             nameSurname
             anotherPerson
             nameSurname1
             anotherFatherName
             redCarName
             streetNumber
             city
             countryCode
             */
            #endregion

            #region What is RAM and how does it work?
            //1. S RAM (Static Random Access Memory)
            //2. D RAM (Dynamic Random Access Memory)
            //3. SD RAM və ya SDR SD RAM (Synchronous Dynamic Random Access Memory)
            //4. DDR SD RAM (Double Data Rate Synchronous Dynamic Random Access Memory)
            //5. GDDR SD RAM (Graphics Double Data Rate Synchronous Dynamic Random Access Memory)



            //C#'da deyisen novleri:
            //1. Value Type
            //2. Reference Type
            //3. Pointer Type
            #endregion

            #region Value Type Variables
            //Numune 1
            int a;
            a = 5;

            //Numune 2
            int b;
            b = 5;
            b = 17;

            //Numune 3

            //Numune 4
            int i = 2147483647; //(ram'da 4 byte yer tutur)
            double x = 500; //(double RAM'da 8 byte yer tutur)
            x = i;

            x = 150;
            #endregion


            #region Referance Type Variables
            Student student;

            //student.Name (error verecek cunku student'e deyer verilmeyib)

            student = new Student();
            student.Name = "Ceyhun";
            student.Age = 27;
            student.Point = 78.5d;
            #endregion

            #region Reason of NullReferanceException
            //var studentClassNumber = student.ClassRoom.Number;
            #endregion

            #region Assign one Referance Type to another

            Student otherStudent = new Student();
            otherStudent.Name = "Babek";
            otherStudent.Age = 29;
            otherStudent.Point = 71.6d;

            student = otherStudent;
            #endregion


            #region String helper methods
            string employee = "Orkhan Farajov";
            string upperCase = employee.ToUpper(); //(string'in dəyərini böyük hərfə çevirmək üçün istifadə olunur.)
            string lowerCase = employee.ToLower(); //(string'in dəyərini kiçik hərfə çevirmək üçün istifadə olunur.)
            string partOfString = employee.Substring(2, 4); 
            #endregion
        }
    }
}
