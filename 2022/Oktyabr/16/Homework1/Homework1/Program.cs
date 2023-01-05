using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now
            };

            City city = new City()
            {
                Id = 1,
                Name = "Sumqayıt",
                CreateDate = DateTime.Now,
                Country = country
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "omerisgzoom@gmail.com",
                PhoneNumber = "+994 050 766 62 61",
                CreateDate = DateTime.Now
            };

            customer.Contacts[0].Email = "omerisgaternos354@gmail.com";
            customer.Contacts[0].PhoneNumber = "+994 070 889 70 00";
            customer.Contacts[0].EditDate = DateTime.Now;

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "MyBuilding",
                Street = "Nesimi",
                Distinct = "Kotec",
                CreateDate = DateTime.Now,
                city = city
            };

            customer.Orders[0] = new Order()
            {
                Id = 1,
                OrderDetails = "Macbook Pro M2, 2000 USD",
                ShippingAddress = customer.Addresses[0],
                CreateDate = DateTime.Now
            };

            customer.ShowAllInfo();

        }
    }
}
