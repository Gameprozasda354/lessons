using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is NOT Generic class
            Customer customer = new Customer();

            //GenericCustomer genericClass = new GenericCustomer(); //error

            GenericCustomer<string> gCustomer = new GenericCustomer<string>();

            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);
            gCustomer.DocumentSerial = "AA";
            gCustomer.DocumentNo = "123456";
            gCustomer.PlaceOfBirth = "Baku";


            MultipleGenericClass<string, int, DateTime> multiGeneric = new MultipleGenericClass<string, int, DateTime>();
            multiGeneric.Id = 1;
            multiGeneric.Name = "Orkhan";
            multiGeneric.Surname = "Farajov";
            multiGeneric.DateOfBirth = new DateTime(1995, 12, 24);

            string name = multiGeneric.GetName();
            #endregion



            #region What is Generic Class
            /*
             Database        |     App
             MsSQL           |     C#/.NET
             */

            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            List<Customer> customers = customerRepository.Get();

            GenericRepository<Item> itemRepository = new GenericRepository<Item>();
            List<Item> items = itemRepository.Get();

            Customer cust = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DateOfBirth = new DateTime(1995, 12, 24),
                DocumentNo = "123456",
                DocumentSerial = "AB",
                PlaceOfBirth = "Germany"
            };

            Item item = new Item()
            {
                Id = 1,
                Name = "Samsung TV",
                Description = "Nice TV of samsung",
                MadeInCountry = "Taiwan",
                Price = 1500
            };

            customerRepository.Add(cust);
            itemRepository.Add(item);

            GenericRepository<int> intRepository = new GenericRepository<int>();
            RestrictedGenericRepository<Customer> resIntRepository = new RestrictedGenericRepository<Customer>();
            #endregion
        }
    }
}
