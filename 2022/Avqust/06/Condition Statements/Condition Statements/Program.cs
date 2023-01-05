using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If-Else
            /*
             if(sert){
                //if serti odense bu skoplar arasindaki kodlari icra et
             }else{
                //if serti odenmese bu skoplar arasindaki kodlari icra et
             }
             */

            ////sadece if ile
            //int age = Convert.ToInt32(Console.ReadLine());

            //if(age <= 18)
            //{
            //    Console.WriteLine("Yeniyetme");
            //}

            //if(age > 18)
            //{
            //    Console.WriteLine("Yetiskin");
            //}


            ////if-else ile
            //if(age <= 18)
            //{
            //    Console.WriteLine("Yeniyetme");
            //}
            //else
            //{
            //    Console.WriteLine("Yetiskin");
            //}

            ////skopsuz if else yazmaq
            //if(age <= 18)
            //    Console.WriteLine("Yeniyetme");
            //else
            //    Console.WriteLine("Yetiskin");


            //---------------------------------------------------------------------------------------------------------------------------------


            //Console.WriteLine("Adinizi daxil edin: ");
            //string name = Console.ReadLine();

            //if(name == "orkhan")
            //    Console.WriteLine("name deyeri orxandir.");
            //else
            //    Console.WriteLine("name deyeri orxan deyil");

            //bool result = name == "orkhan";

            //if (result)
            //{
            //    Console.WriteLine("Salam");
            //    Console.WriteLine("name deyeri orxandir");
            //    Console.WriteLine("sagol");
            //}
            //else
            //{
            //    Console.WriteLine("Salam");
            //    Console.WriteLine("name deyeri orxan deyil");
            //    Console.WriteLine("sagol");
            //}


            //---------------------------------------------------------------------------------------------------------------------------------


            //int a = 10;
            //int b = 20;

            //if(a > 5 && b < 25)
            //    Console.WriteLine("a deyeri 5-den boyuk, b deyeri 25-den kicikdir.");

            //if(a is Int32)
            //    Console.WriteLine("a deyiseni int tipindedir");
            //else
            //    Console.WriteLine("a deyiseni int tipinde deyil");


            ////Coxlu if else yazmaq
            //string country = "Azerbaycan";

            //if (country == "Turkiye" || country == "Turkey")
            //{
            //    Console.WriteLine("Turkiyenin paytaxti Ankara seheridir");
            //}
            //else if (country == "Almaniya")
            //{
            //    Console.WriteLine("Almaniyanin paytaxti Berlin seheridir");
            //}
            //else if (country == "Italiya")
            //{
            //    Console.WriteLine("Italiyanin paytaxti Roma seheridir");
            //}
            //else if (country == "Azerbaycan")
            //{
            //    Console.WriteLine("Azerbaycanin paytaxti Baki seheridir");
            //}
            //else if (country == "Fransa")
            //{
            //    Console.WriteLine("Fransanin paytaxti Paris seheridir");
            //}
            //else if (country == "Hollandiya")
            //{
            //    Console.WriteLine("Hollandiyanin paytaxti Amsterdam seheridir");
            //}
            //else
            //{
            //    Console.WriteLine("Hec bir sert odenmedi.");
            //}

            #region Task in Lesson 1
            /*
            Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. Deyer reqemdirse ancaq 0-dan
                kiçik, 100-dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın. Əgər rəqəmdirsə, aralıqlara görə ekrana bir imtahan nəticəsi yazın.
                       
                Bal 20-dən kiçik olarsa "İmtahandan kəsildiniz" yazın.
                20-dən böyük və ya bərabər, 40-dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında "Netice: qenaetbexs"
                40-dan böyük və ya bərabər, 60-dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"
                60-dan böyük və ya bərabər, 80-dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"
                80-a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
            */

            //string examPointStr = Console.ReadLine();
            //int examPoint = 0;
            //bool parsePoint = int.TryParse(examPointStr, out examPoint);


            //if(!parsePoint)
            //    Console.WriteLine("Xahis olunur duzgun reqem daxil edin!");
            //else if(examPoint < 0 || examPoint > 100)
            //    Console.WriteLine("Duzgun bal daxil edilmeyib!");
            //else if (examPoint < 20)
            //{
            //    Console.WriteLine("Imtahandan kesildiniz!");
            //}else if (examPoint >= 20 && examPoint < 40)
            //{
            //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
            //    Console.WriteLine("Netice: Qenaetbexs");
            //}
            //else if (examPoint >= 40 && examPoint < 60)
            //{
            //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
            //    Console.WriteLine("Netice: Kafi");
            //}
            //else if (examPoint >= 60 && examPoint < 80)
            //{
            //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
            //    Console.WriteLine("Netice: Yaxsi");
            //}
            //else if (examPoint >= 80)
            //{
            //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
            //    Console.WriteLine("Netice: Ela");
            //}
            #endregion



            //Nested if
            //var firstname = "Orkhan";
            //var surname = "Farajov";
            //var dateOfBirth = new DateTime(1995, 12, 24);
            //var job = "Developer";

            //if(firstname == "Orkhan" && surname == "Farajov")
            //{
            //    if (dateOfBirth.Year == 1995 && dateOfBirth.Month == 12 && dateOfBirth.Day == 24)
            //    {
            //        if(job == "Developer")
            //        {
            //            Console.WriteLine("Xos geldin " + firstname);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Job yanlisdir!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dogum tarixi yanlisdir!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ad ve ya soyad yanlisdir!");
            //}



            #region Task in Lesson 2
            /*
             Kiçik bir kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə edə biləcəyi əməliyyatları nömrələriylə göstərin.
                "Etmek istediyiniz emeliyyati secin:"
                "1. Toplama"
                "2. Çıxma"
                "3. Vurma"
                "4. Bölmə"
                İstifadəçi əməliyyatı seçəndən sonra a və b dəyərlərini rəqəm olaraq alın və əməliyyatı icra edib nəticəni göstərin. Sadəcə bir dənə bölmə
                əməliyyatında əgər b-nin dəyəri 0 olarsa ekrana "Dəyər 0-a bölünə bilməz!" yazdırın.
             */

            //Console.WriteLine("Etmek istediyiniz emeliyyati secin: ");
            //Console.WriteLine("1. Toplama");
            //Console.WriteLine("2. Cixma");
            //Console.WriteLine("3. Vurma");
            //Console.WriteLine("4. Bolme");

            //var op = Convert.ToInt16(Console.ReadLine());
            //var a1 = Convert.ToInt32(Console.ReadLine());
            //var b1 = Convert.ToInt32(Console.ReadLine());

            //if(op == 1)
            //    Console.WriteLine("Netice: " + (a1 + b1));
            //else if (op == 2)
            //    Console.WriteLine("Netice: " + (a1 - b1));
            //else if (op == 3)
            //    Console.WriteLine("Netice: " + (a1 * b1));
            //else if (op == 4)
            //{
            //    if(b1 == 0)
            //    {
            //        Console.WriteLine("Deyer 0-a bolune bilmez");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Netice: " + (a1 / b1));
            //    }
            //}
            #endregion
            #endregion




            #region Switch Case
            string langOrFramework = "C#";

            switch (langOrFramework)
            {
                case "ASP.NET":
                    Console.WriteLine("Microsoft");
                    break;
                case "F#":
                    Console.WriteLine("Microsoft");
                    break;
                case "C#":
                    Console.WriteLine("Microsoft");
                    break;
                case "Java":
                    Console.WriteLine("Oracle");
                    break;
                default: //Eger hec bir case'e match olmasa yeni uygun gelmese default ise dusur
                    Console.WriteLine("Hec bir case'e uygun gelmedi");
                    break;
            }


            //if-else varianti
            if (langOrFramework == "ASP.NET")
            {
                Console.WriteLine("Microsoft");
            }
            else if (langOrFramework == "F#")
            {
                Console.WriteLine("Microsoft");
            }
            else if (langOrFramework == "C#")
            {
                Console.WriteLine("Microsoft");
            }
            else if (langOrFramework == "Java")
            {
                Console.WriteLine("Oracle");
            }
            else
            {
                Console.WriteLine("Hec birine uygun gelmedi");
            }

            #region Task in Lesson 3
            /*
                1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
                2. İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın. 10 dənə ölkə olsa kifayətdir.
             */

            int month = 5;
            const int feb = 2;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case feb:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    break;
            }
            #endregion


            string job = "Mobile Developer";

            switch (job)
            {
                case "Developer":
                    Console.WriteLine("Proqramci proqram teminati hazirlayir.");
                    break;
                case "Design":
                    Console.WriteLine("Dizayner muxtelif dizaynlar hazirlayir.");
                    break;
                case "Web Designer":
                    Console.WriteLine("Salam web dizayner");
                    goto case "Design";
                case "Mobile Developer":
                    Console.WriteLine("Salam mobile developer");
                    goto case "Developer";
            }

            Console.WriteLine("Rutbe kodunu daxil edin: ");
            string code = Console.ReadLine();

            switch (code)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin");
                    break;
                case "DD":
                case "FF":
                    Console.WriteLine("Editor");
                    break;
                case "GG":
                case "HH":
                    Console.WriteLine("Editor");
                    break;
                case "II":
                case "JJ":
                    Console.WriteLine("Editor");
                    break;
            }
            #endregion
        }
    }
}
