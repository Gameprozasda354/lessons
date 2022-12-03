using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        void Write()
        {

        }
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            Address adress = new Address()
            {
                Id = 1,
                No = 1,
                Building = "Some",
                Street = "Some",
                City = "Some",
                Country = "Country",
            };
            customers.Add(new Customer()
            {
                Id = 1,
                Name = "Omer",
                SurName = "Isgenderli",
                AddressInfo = adress,
            });
            customers.ForEach(i => Write);

        }
        
        /*
         2. 
             Customer class'ının Id, Name, Surname, Age property'ləri olsun. Birdə əlavə olaraq Address Class'ı yaradıb onu da
             inner type olaraq Customer'ə property kimi əlavə edin. Address'in bu property'ləri olacaq: Id, No, Building, Street,
             City, Country. City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
             2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. Sizdən istədiyim odur
             ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
                ID: 1
                Name: Cavid
                Surname: Cavidov
                Age: 20
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country

                ID: 2
                Name: Hasan
                Surname: Hasanov
                Age: 32
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country
         */
    }
}
