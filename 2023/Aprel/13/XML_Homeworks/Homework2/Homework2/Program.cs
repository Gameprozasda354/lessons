using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ReadStudents
            XDocument studentsXDoc = XDocument.Load(@"C:\\XML\Students.xml");

            List<XElement> elements = studentsXDoc.Descendants("Student").ToList();
                
            List<Student> students = new List<Student>();

            foreach (var item in elements)
            {
                Student student = new Student()
                {
                    Id = Convert.ToInt32(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    Email = item.Element("Email").Value,
                    Class = Convert.ToInt32(item.Element("Class").Value)
                };
                students.Add(student);
            }
            #endregion

            #region ReadTeachers
            XDocument teachersXDoc = XDocument.Load(@"C:\\XML\Teachers.xml");

            List<XElement> elements2 = teachersXDoc.Descendants("Teacher").ToList();

            List<Teacher> teachers = new List<Teacher>();

            foreach (var item in elements2)
            {
                Teacher teacher = new Teacher()
                {
                    Id = Convert.ToInt32(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    Email = item.Element("Email").Value,
                    Age = Convert.ToInt32(item.Element("Age").Value),
                    BornCountry = item.Element("BornCountry").Value
                };
                teachers.Add(teacher);
            }
            #endregion

            #region ReadStuffs
            XDocument stuffsXDoc = XDocument.Load(@"C:\\XML\Stuffs.xml");

            List<XElement> elements3 = stuffsXDoc.Descendants("Stuff").ToList();

            List<Stuff> stuffs = new List<Stuff>();

            foreach (var item in elements3)
            {
                Stuff stuff = new Stuff()
                {
                    Id = Convert.ToInt32(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    City = item.Element("City").Value,
                    Address = item.Element("Address").Value
                };
                stuffs.Add(stuff);
            }
            #endregion
        }
    }
}
