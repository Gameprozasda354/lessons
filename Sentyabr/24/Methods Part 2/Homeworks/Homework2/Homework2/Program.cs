using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer();

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Sinifin adını daxil edin:");
            string nameOfClass = Console.ReadLine();

            Console.WriteLine("Sinif rəhbərinin adını daxil edin:");
            string nameOfClassTeacher = Console.ReadLine();

            Console.WriteLine("1.ci şagirdin adını daxil edin:");
            var nameOfStudent1 = Console.ReadLine();

            Console.WriteLine("2.ci şagirdin adını daxil edin:");
            var nameOfStudent2 = Console.ReadLine();

            Console.WriteLine("3.cü şagirdin adını daxil edin:");
            var nameOfStudent3 = Console.ReadLine();

            Console.WriteLine("4.cü şagirdin adını daxil edin:");
            var nameOfStudent4 = Console.ReadLine();

            Console.WriteLine("5.ci şagirdin adını daxil edin:");
            var nameOfStudent5 = Console.ReadLine();

            Console.WriteLine("6.cı şagirdin adını daxil edin:");
            var nameOfStudent6 = Console.ReadLine();

            Console.WriteLine("7.ci şagirdin adını daxil edin:");
            var nameOfStudent7 = Console.ReadLine();

            Console.WriteLine("8.ci şagirdin adını daxil edin:");
            var nameOfStudent8 = Console.ReadLine();

            Console.WriteLine("9.cu şagirdin adını daxil edin:");
            var nameOfStudent9 = Console.ReadLine();

            Console.WriteLine("10.cu şagirdin adını daxil edin:");
            var nameOfStudent10 = Console.ReadLine();

            printer.Printer1(nameOfClass, nameOfClassTeacher, nameOfStudent1, nameOfStudent2,
                nameOfStudent3, nameOfStudent4, nameOfStudent5, nameOfStudent6, nameOfStudent7,
                nameOfStudent8, nameOfStudent9, nameOfStudent10);

            Console.ReadLine();

            /*
              4. Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s. daxil ediləcək. Sonra sinif rəhbərinin adı
                soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
                və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
                şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik.
            */

        }

    }
}
