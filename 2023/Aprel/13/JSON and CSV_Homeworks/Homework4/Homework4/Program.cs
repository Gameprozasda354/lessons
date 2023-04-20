using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person()
                {
                    Id = i + 1,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Age = random.Next(1, 100)
                };
                persons.Add(person);
            }

            var writer = new StreamWriter(@"C:\\CSV\\Persons.csv");

            CsvHelper.CsvWriter csvWriter = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture);

            csvWriter.WriteHeader(typeof(Person));

            foreach (var item in persons)
            {
                csvWriter.WriteRecord(item);
            }

            writer.Close();

            var reader = new StreamReader(@"C:\\CSV\\Persons.csv");

            CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);

            List<Person> readCustomers = csvReader.GetRecords<Person>().ToList();

        }
    }
}
