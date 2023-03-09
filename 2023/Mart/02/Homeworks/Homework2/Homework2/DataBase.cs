using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class DataBase
    {
        public List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
    }
}
