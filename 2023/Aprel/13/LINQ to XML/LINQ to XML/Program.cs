using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write XML data
            List<Student> Students = new List<Student>();

            for (int i = 0; i < 100; i++)
            {
                Student student = new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Number = FakeData.PhoneNumberData.GetPhoneNumber()
                };

                Students.Add(student);
            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Students", //<Students>
                    Students.Select(m =>
                        new XElement("Student", //<Student>
                            new XElement("Id", m.Id),
                            new XElement("Name", m.Name),
                            new XElement("Surname", m.Surname),
                            new XElement("Number", m.Number)
                        )
                    )
                )
            );

            doc.Save(@"C:\\XML\Students.xml");
            #endregion


            #region Read XML data
            XDocument readXML = XDocument.Load(@"C:\\XML\Students.xml");

            List<XElement> elements = readXML.Descendants("Student").ToList();

            List<Student> readStudents = new List<Student>();

            foreach (var item in elements)
            {
                Student student = new Student()
                {
                    Id = Guid.Parse(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    Number = item.Element("Number").Value
                };

                readStudents.Add(student);
            }
            #endregion
        }
    }
}
