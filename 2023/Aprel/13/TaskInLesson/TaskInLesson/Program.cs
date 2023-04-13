using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskInLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task description:
            Persons listinin içində 100 dənə Person olacaq. Person class'ının da 5 property'si olsa kifayətdir. Siz bu list'in içində
            olan 100 dənə məlumatı JSON formatı olaraq bir json faylına yazdıracaqsınız.
            */
            List<Person> personsList = new List<Person>();
            Random rand = new Random();
            for(int i = 0; i < 100; i++)
            {
                int id = i + 1;
                string name = FakeData.NameData.GetFirstName();
                string surName = FakeData.NameData.GetSurname();
                string email = FakeData.NetworkData.GetEmail(name, surName);
                int age = rand.Next(1, 100);

                Person person = new Person()
                {
                    Id = id,
                    Name = name,
                    SurName = surName,
                    Email = email,
                    Age =  age
                };
                personsList.Add(person);
            }

            string filestring = JsonConvert.SerializeObject(personsList);

            File.WriteAllText("C:\\Json\\Json.json", filestring);

        }
    }
}
