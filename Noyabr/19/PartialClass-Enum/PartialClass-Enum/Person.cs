using PartialClass_Enum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    public class Person : BaseClass<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public int GenderInteger { get; set; }

        public override int Add(Person item)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Person[] Get()
        {
            throw new NotImplementedException();
        }

        public override Person Update(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
