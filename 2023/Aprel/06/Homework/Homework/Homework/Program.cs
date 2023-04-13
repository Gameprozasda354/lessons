using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XComment("Tələbə məlumatları"),
                new XElement("Students",
                    new XComment("Tələbə 1"),
                    new XElement("Student", 
                        new XAttribute("Id", "1"),
                        new XElement("Name", "Ismayıl"),
                        new XElement("Surname", "Məmmədli"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "4.7.2000"),
                        new XElement("Degree", "Bachelor's"),
                        new XElement("Contact", 
                            new XElement("Adress", "Azerbaijan, Baku, Yasamal"),
                            new XElement("Phone", "050-222-55-33")
                        )
                    
                    ),
                    new XComment("Tələbə 2"),
                    new XElement("Student",
                        new XAttribute("Id", "2"),
                        new XElement("Name", "Əli"),
                        new XElement("Surname", "İsmayılzadə"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "5.20.2004"),
                        new XElement("Degree", "Associate"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Sumqayıt, 17-ci mkr"),
                            new XElement("Phone", "070-879-57-46")
                        )

                    ),
                    new XComment("Tələbə 3"),
                    new XElement("Student",
                        new XAttribute("Id", "3"),
                        new XElement("Name", "Rövşən"),
                        new XElement("Surname", "Məmmədli"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "8.23.2010"),
                        new XElement("Degree", "Doctoral"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Sumqayıt, Saray"),
                            new XElement("Phone", "055-247-90-07")
                        )

                    ),
                    new XComment("Tələbə 4"),
                    new XElement("Student",
                        new XAttribute("Id", "4"),
                        new XElement("Name", "Nurlan"),
                        new XElement("Surname", "Əhmədli"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "2.3.2005"),
                        new XElement("Degree", "Master's"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Baku, Nizami"),
                            new XElement("Phone", "077-292-50-24")
                        )

                    ),
                    new XComment("Tələbə 5"),
                    new XElement("Student",
                        new XAttribute("Id", "5"),
                        new XElement("Name", "Aqşin"),
                        new XElement("Surname", "Vəlizadə"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "1.17.1997"),
                        new XElement("Degree", "Associate"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Baku, Gənclik"),
                            new XElement("Phone", "050-977-70-73")
                        )

                    ),
                    new XComment("Tələbə 6"),
                    new XElement("Student",
                        new XAttribute("Id", "6"),
                        new XElement("Name", "Emil"),
                        new XElement("Surname", "Məlikov"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "7.22.2014"),
                        new XElement("Degree", "Master's"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Baku, Koroğlu"),
                            new XElement("Phone", "050-211-08-96")
                        )

                    ),
                    new XComment("Tələbə 7"),
                    new XElement("Student",
                        new XAttribute("Id", "7"),
                        new XElement("Name", "Əhməd"),
                        new XElement("Surname", "Hüseynzadə"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "11.10.2011"),
                        new XElement("Degree", "Doctoral"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Baku, Heydər Əliyev prospekti"),
                            new XElement("Phone", "055-798-00-05")
                        )

                    ),
                    new XComment("Tələbə 8"),
                    new XElement("Student",
                        new XAttribute("Id", "8"),
                        new XElement("Name", "Ələsgər"),
                        new XElement("Surname", "Əliyev"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "8.30.1980"),
                        new XElement("Degree", "Bachelor's"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Sumqayıt, 9-cu mkr"),
                            new XElement("Phone", "070-229-00-00")
                        )

                    ),
                    new XComment("Tələbə 9"),
                    new XElement("Student",
                        new XAttribute("Id", "9"),
                        new XElement("Name", "Elşən"),
                        new XElement("Surname", "Həmidov"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "9.1.2000"),
                        new XElement("Degree", "Doctoral"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Baku, Yasamal"),
                            new XElement("Phone", "055-220-50-30")
                        )

                    ),
                    new XComment("Tələbə 10"),
                    new XElement("Student",
                        new XAttribute("Id", "10"),
                        new XElement("Name", "Əsgər"),
                        new XElement("Surname", "Abdullayev"),
                        new XElement("Gender", "Male"),
                        new XElement("Birthdate", "2.26.2015"),
                        new XElement("Degree", "Associate"),
                        new XElement("Contact",
                            new XElement("Adress", "Azerbaijan, Sumqayıt, 11-ci mkr"),
                            new XElement("Phone", "070-297-00-00")
                        )

                    )

                )
            );

            xDocument.Save(@"C:\\XML\\Students.xml");
        }
    }
}
