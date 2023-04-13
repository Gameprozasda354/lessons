using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is CSV format
            //Comma separated Variables

            //Id, Name, Surname, Email
            //1, Orkhan, Farajov, orkhankhf@gmail.com

            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 200; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.Name = FakeData.NameData.GetFirstName();
                customer.Surname = FakeData.NameData.GetSurname();
                customer.Email = FakeData.NetworkData.GetEmail(customer.Name, customer.Surname);
                customer.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();

                customers.Add(customer);
            }

            if (!Directory.Exists(@"C:\\CSV"))
                Directory.CreateDirectory(@"C:\\CSV");

            if (!File.Exists(@"C:\\CSV\\Customers.csv"))
                File.Create(@"C:\\CSV\\Customers.csv");

            StreamWriter sw = new StreamWriter(@"C:\\CSV\\Customers.csv");

            CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(sw);

            write.WriteHeader(typeof(Customer));

            foreach (var item in customers)
            {
                write.WriteRecord(item);
            }

            sw.Close();




            StreamReader sr = new StreamReader(@"C:\\CSV\\Customers.csv");

            CsvHelper.CsvReader reader = new CsvHelper.CsvReader(sr);

            List<Customer> readCustomers = reader.GetRecords<Customer>().ToList();
            #endregion
        }
    }
}
