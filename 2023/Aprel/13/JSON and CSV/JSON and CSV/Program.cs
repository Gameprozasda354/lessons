using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_and_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            
            [
                {
                    "Id":"1",
                    "Name":"Orkhan",
                    "Surname":"Farajov",
                    "Age":"29",
                    "Phone":"055-581-08-72",
                }
            ]


             */

            //List<Customer> customers = new List<Customer>();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Customer customer = new Customer();
            //    customer.Id = Guid.NewGuid();
            //    customer.Name = FakeData.NameData.GetFirstName();
            //    customer.Surname = FakeData.NameData.GetSurname();
            //    customer.Email = FakeData.NetworkData.GetEmail(customer.Name, customer.Surname);
            //    customer.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
            //    customer.Country = FakeData.PlaceData.GetCountry();

            //    customers.Add(customer);
            //}

            //Console.WriteLine(@"Məlumatlarınız C:\Json\Customers.json faylına yazılacaq.");

            //if (!Directory.Exists("C:\\Json"))
            //    Directory.CreateDirectory("C:\\Json");

            //string jsonCustomers = JsonConvert.SerializeObject(customers);

            //File.WriteAllText("C:\\Json\\Customers.json", jsonCustomers);

            //Console.ReadLine();

            string readJsonData = File.ReadAllText("C:\\Json\\Customers.json");

            List<XObject> data = JsonConvert.DeserializeObject<List<XObject>>(readJsonData);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Surname);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.PhoneNumber);
            //    Console.WriteLine(item.Country);
            //    Console.WriteLine("-----------------------------------");
            //}



            string readPersonData = File.ReadAllText("C:\\Json\\Persons.json");

            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(readPersonData);

            //foreach (var item in persons)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Surname);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.PhoneNumber);
            //    Console.WriteLine(item.Country);
            //    Console.WriteLine("-----------------------------------");
            //}

            string diffPropData = File.ReadAllText("C:\\Json\\PersonDifferentName.json");

            List<Person> diffPersonData = JsonConvert.DeserializeObject<List<Person>>(diffPropData);

            foreach (var item in persons)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.PhoneNumber);
                Console.WriteLine(item.Country);
                Console.WriteLine("-----------------------------------");
            }

            List<PersonWithAttribute> diffPersonDataWithAttr = JsonConvert.DeserializeObject<List<PersonWithAttribute>>(diffPropData);

            foreach (var item in diffPersonDataWithAttr)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.PhoneNumber);
                Console.WriteLine(item.Country);
                Console.WriteLine("-----------------------------------");
            }

            /*
             Task description:
              Persons listinin içində 100 dənə Person olacaq. Person class'ının da 5 property'si olsa kifayətdir. Siz bu list'in içində
              olan 100 dənə məlumatı JSON formatı olaraq bir json faylına yazdıracaqsınız.
             */
        }
    }
}
