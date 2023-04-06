using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlLab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write XML
            Stopwatch sw = new Stopwatch();

            sw.Start();
            XmlTextWriter xmlText = new XmlTextWriter(@"C:\\XML\\CustomersNonLinq.xml", UTF8Encoding.UTF8);

            xmlText.WriteComment("Müştəri məlumatları");

            xmlText.WriteStartElement("Customers");

            for (int i = 0; i < 20000; i++)
            {
                xmlText.WriteStartElement("Customer");
                xmlText.WriteAttributeString("Id", "1");
                xmlText.WriteElementString("Name", "Orkhan");
                xmlText.WriteElementString("Surname", "Farajov");
                xmlText.WriteElementString("Job", "Programmer");
                xmlText.WriteElementString("Country", "Azerbaijan");
                xmlText.WriteEndElement();
            }

            xmlText.WriteEndElement();

            xmlText.Close();
            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            #endregion


            #region Create Document with XDocument
            Stopwatch sw2 = new Stopwatch();

            sw2.Start();
            XDocument Xdocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XComment("Müştəri məlumatları"),
                new XElement("Customers")
            );
            for (int i = 0; i < 20000; i++)
            {
                var elem = new XElement("Customer",
                        new XAttribute("Id", "1"),
                        new XElement("Name", "Orkhan"),
                        new XElement("Surname", "Farajov"),
                        new XElement("Job", "Programmer"),
                        new XElement("Country", "Azerbaijan")
                    );
                Xdocument.Elements("Customers").First().Add(elem);
            }

            Xdocument.Save(@"C:\\XML\\CustomersLinq.xml");
            sw2.Stop();

            Console.WriteLine("Elapsed={0}", sw2.Elapsed);
            Console.ReadLine();
            #endregion
        }
    }
}
