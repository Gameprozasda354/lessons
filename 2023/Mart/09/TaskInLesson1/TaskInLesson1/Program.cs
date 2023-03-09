using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase data = new DataBase();
            Random random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                Customer customer = new Customer()
                {
                    Id = i + 1,
                    Name = FakeData.NameData.GetFirstName(),
                    SurName = FakeData.NameData.GetSurname(),
                    Age = random.Next(1, 100)
                };
                data.customerList.Add(customer);
            }

            List<Customer> list = new List<Customer>();
            list = data.TheLetter('A');
            List<Customer> list2 = new List<Customer>();
            list2 = data.TheAge(18, 25);

        }
    }
}
