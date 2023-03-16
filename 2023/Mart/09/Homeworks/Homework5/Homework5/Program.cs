using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 1000; i++)
            {
                persons.Add(new Person()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    SurName = FakeData.NameData.GetSurname()
                });
            }

            persons.ForEach(x => x.FullName = x.Name + x.SurName);
        }
        /*
             Homework 5:
             Name, Surname, Fullname property'ləri olan Person adlı bir class'ınız olsun. FakeData ilə Person tipində bir listə 1000 nəfər əlavə edin.
             Əlavə edəndə Name və Surname property'lərini set edin amma fullname boş qalsın. Artıq əlinizdə 1000 nəfərin Ad və Soyadı olan bir list hazır olduqdan
             sonra Linq istifadə edərək Ad və Soyad'dan Fullname'i set edin.
         */
    }
}
