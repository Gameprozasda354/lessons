using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";

            //(private field oldugu ucun set etmek olmur)
            //customer.email = "orkhankhf@gmail.com";

            customer.Email = "orkhankhf@gmail.com";

            Student student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhan.f@gmail.com";



            /*
             Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.
              Hər biri üçün, getter və setteri olan bir property'si və private bir field'ı olacaq.
              Validation və xəta mesajları:
              Vəsiqənin seriyasını set edən zaman yoxlamalıdır ki, uzunluğu 2 hərfdir mi?
                Deyilsə: "Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!" xətası çıxmalıdır.
              Eyni zamanda yoxlamalıdır ki, sadəcə hərflərdən mi ibarətdir?
                Deyilsə: "Vesiqenin seriyasi sadece herflerden ibaret olmalidir!" xətası çıxmalıdır.
              Eyni zamanda da, vəsiqənin nömrəsi set olunan zaman baxmalıdır ki, uzunluğu 8 ə bərabərdir mi?
                Deyilsə: "Vesiqenin nomresinin uzunlugu 8 olmalidir!" xətası çıxmalıdır.
              Birdə nömrənin rəqəmlərdən ibarət olub-olmaması yoxlanmalıdır.
                Deyilsə: "Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!" xətası çıxacaq.
              Bu validation'lara əlavə olaraq vəsiqənin nömrəsi get olan zaman ancaq ilk 3 rəqəm user'ə göstəriləcək. Digər rəqəmlər ulduz
              simvolu olaraq çıxacaq. Orda elə etmək lazımdır ki, 3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik
              4 simvol görsənsin və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və 2 simvol ulduz
              olaraq çıxsın.
              Vaxt: 15 dəqiqə
             */

            Student st1 = new Student();
            st1.DocumentSerial = "AZ";
            st1.DocumentNumber = "12345678";

            var x = st1.DocumentNumber;
        }
    }
}
