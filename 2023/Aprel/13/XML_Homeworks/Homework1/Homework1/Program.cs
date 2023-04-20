using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region Student
            List<Student> students = new List<Student>();

            for (int i = 0; i < 1000; i++)
            {
                string name = FakeData.NameData.GetFirstName();
                string surname = FakeData.NameData.GetSurname();                
                Student student = new Student()
                {
                    Id = i + 1,
                    Name = name,
                    Surname = surname,
                    Email = FakeData.NetworkData.GetEmail(name, surname),
                    Class = random.Next(1, 12)
                };
                students.Add(student);
            }

            XDocument studentXDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Students", 
                    students.Select(x =>
                        new XElement("Student", 
                            new XElement("Id", x.Id),
                            new XElement("Name", x.Name),
                            new XElement("Surname", x.Surname),
                            new XElement("Email", x.Email),
                            new XElement("Class", x.Class)
                        )
                    )
                )
            );

            studentXDoc.Save(@"C:\XML\Students.xml");

            #endregion

            #region Teacher
            List<Teacher> teachers = new List<Teacher>();

            for (int i = 0; i < 1000; i++)
            {
                string name = FakeData.NameData.GetFirstName();
                string surname = FakeData.NameData.GetSurname();
                Teacher teacher = new Teacher()
                {
                    Id = i + 1,
                    Name = name,
                    Surname = surname,
                    Age = random.Next(26, 60),
                    BornCountry = FakeData.PlaceData.GetCountry(),
                    Email = FakeData.NetworkData.GetEmail(name, surname)
                };
                teachers.Add(teacher);
            }

            XDocument teacherXDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Teachers",
                    teachers.Select(x =>
                        new XElement("Teacher",
                            new XElement("Id", x.Id),
                            new XElement("Name", x.Name),
                            new XElement("Surname", x.Surname),
                            new XElement("Age", x.Age),
                            new XElement("BornCountry", x.BornCountry),
                            new XElement("Email", x.Email)
                        )
                    )
                )
            );

            teacherXDoc.Save(@"C:\XML\Teachers.xml");
            #endregion

            #region Stuff
            List<Stuff> stuffs = new List<Stuff>();

            for (int i = 0; i < 1000; i++)
            {
                Stuff stuff = new Stuff()
                {
                    Id = i + 1,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    City = FakeData.PlaceData.GetCity(),
                    Address = FakeData.PlaceData.GetAddress()
                };
                stuffs.Add(stuff);
            }

            XDocument stuffXDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Stuffs",
                    stuffs.Select(x =>
                        new XElement("Stuff",
                            new XElement("Id", x.Id),
                            new XElement("Name", x.Name),
                            new XElement("Surname", x.Surname),
                            new XElement("City", x.City),
                            new XElement("Address", x.Address)
                        )
                    )
                )
            );

            stuffXDoc.Save(@"C:\XML\Stuffs.xml");
            #endregion
        }
    }
}
