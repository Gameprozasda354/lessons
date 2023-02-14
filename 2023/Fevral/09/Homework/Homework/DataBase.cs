using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class DataBase
    {
        List<Customer> customerList = new List<Customer>();

        public List<Customer> GetCustomer(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Customer customer = new Customer();

                customer.Id = i + 1;
                customer.Name = FakeData.NameData.GetFirstName();
                customer.Surname = FakeData.NameData.GetSurname();
                customer.Fullname = $"{customer.Name} {customer.Surname}";
                customer.Email = FakeData.NetworkData.GetEmail(customer.Name, customer.Surname);
                customer.Phone = FakeData.PhoneNumberData.GetPhoneNumber();
                customer.Country = FakeData.PlaceData.GetCountry();
                customer.City = FakeData.PlaceData.GetCity();
                customer.Address = FakeData.PlaceData.GetAddress();

                customerList.Add(customer);
            }
            return customerList;
        }
    }
}
