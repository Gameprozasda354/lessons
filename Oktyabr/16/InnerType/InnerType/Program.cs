using System;

namespace InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inner Type
            //Nested Type
            //Nested Class

            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 555555,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now,
                EditDate = null
            };

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                CreateDate = DateTime.Now,
                Country = country
            };

            Order laptopOrder = new Order()
            {
                Id = 1,
                OrderDetails = "Asus TUF FX705GM, 3000 AZN",
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "MyBuilding",
                Street = "HomeStreet",
                Distinct = "Nerimanov",
                CreateDate = DateTime.Now,
                City = city
            };

            customer.Addresses[1] = new Address()
            {
                Id = 2,
                No = 40,
                Building = "Residance",
                Street = "WorkStreet",
                Distinct = "Yasamal",
                CreateDate = DateTime.Now,
                City = city
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 1,
                OrderDetails = "Samsung Galaxy S9+, 1000 AZN",
                ShippingAddress = customer.Addresses[1],
                CreateDate = DateTime.Now
            };

            customer.Orders[1] = laptopOrder;
        }
    }
}
