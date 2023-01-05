using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP - Object Oriented Programming

            //-Müştəri
            //-Satış təmsilcisi
            //-Satılacaq məhsul (Avtomobil, motosiklet və s.)

            /*
             -Müştəri
             -Satış təmsilcisi
             -Satılacaq məhsul
             -Təklif
             -Sirafiş
             -Qəbz
             */

            /*
             -Müştəri
                Ad
                Soyad
                Cinsiyyət
                Pasportun seriyası və nömrəsi
                Ünvanı
             
             -Məhsul
                -Marka
                -Model
                -İl
                -Km
                -Yanacaq növü
                -Ban növü
             
             -Təklif
                -Təklif nömrəsi
                -Müştəri
                -Satıcı
                -Məhsul
                -Qiymət

             -Sifariş
                -Sifariş nömrəsi
                -Təklif
                -Qiymət
             
             -Qəbz
                -Vergi nömrəsi
                -Qəbz nömrəsi
                -Seriya
                -Təklif
                -Müştəri
             */

            Console.WriteLine("I am software developer!");

            string name = "Orkhan";

            #region How to use Classes
            Customer orkhan = new Customer();

            orkhan.Name = "Orkhan";
            //orkhan.Surname //(private oldugu ucun burda elcatan deyil)
            //orkhan.Gender //(private oldugu ucun burda elcatan deyil)

            orkhan.Surname = "Farajov";
            orkhan.Gender = 1;
            orkhan.DocumentSerial = "AZ";
            orkhan.DocumentNumber = "123456";
            orkhan.Address = "Baki seheri, Nerimanov r-nu......";


            Customer otherCustomer = new Customer();

            otherCustomer = orkhan;

            otherCustomer.Name = "Name changed for otherCustomer";
            orkhan.Surname = "Surname changed for orkhan";

            otherCustomer = null;
            orkhan = null;

            string customerName = orkhan.Name; //(NullReferenceException xetasi verecek)
            string otherCustomerName = otherCustomer.Name; //(burani gormeyecek)
            #endregion



            #region Constructor methods
            Customer customer2 = new Customer();

            Customer defaultCtor = new Customer();
            Customer overload1 = new Customer("123456");
            Customer overload2 = new Customer("123456", "AA");
            Customer overload3 = new Customer("123456", "AA", "Orkhan", "Farajov");
            Customer overload4 = new Customer(1, "Orkhan", "Farajov");
            Customer overload5 = new Customer("123456", "AA", 1, "Orkhan", "Farajov", "Adres melumati");
            #endregion


            #region Methods in Classes
            Customer customer10 = new Customer();
            //customer10.CheckCustomerFromDb(); //(Private method oldugu ucun accessable (elcatan) deyil)

            var controlResult = customer10.CheckCustomer();
            #endregion

        }
    }
}
