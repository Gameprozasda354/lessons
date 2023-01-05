using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Customer
    {


        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;

        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }

        public void ShowAllInfo()
        {
            Console.WriteLine("Contact:");
            ShowContacts();
            Console.WriteLine("Address:");
            ShowAddresses();
            Console.WriteLine("Order:");
            ShowOrders();
        }
        public void ShowContacts()
        {
            int numbersOfContacts = 0;

            for(int i = 0; i < Contacts.Length; i++)
            {
                if(Contacts[i] != null)
                {
                    numbersOfContacts = i + 1;
                }
            }

            for(int i = 0; i < numbersOfContacts; i++)
            {
                Console.WriteLine("Id:" + Contacts[i].Id);
                Console.WriteLine("Email:" + Contacts[i].Email);
                Console.WriteLine("PhoneNumber:" + Contacts[i].PhoneNumber);
                Console.WriteLine("CreateDate:" + Contacts[i].CreateDate.ToString("MMMM dd, yyyy"));
                if (Contacts[i].EditDate == null)
                    Console.WriteLine("EditDate:" + "Data is not edited");

                else
                    Console.WriteLine("EditDate:" + Contacts[i].EditDate?.ToString("MMMM dd, yyyy"));
            }
            Console.WriteLine("-----------------------");
        }

        public void ShowAddresses()
        {
            int numbersOfAddress = 0;

            for (int i = 0; i < Addresses.Length; i++)
            {
                if (Addresses[i] != null)
                {
                    numbersOfAddress = i + 1;
                }
            }

            for (int i = 0; i < numbersOfAddress; i++)
            {
                Console.WriteLine("Id:" + Addresses[i].Id);
                Console.WriteLine("No" + Addresses[i].No);
                Console.WriteLine("Building" + Addresses[i].Building);
                Console.WriteLine("Street" + Addresses[i].Street);
                Console.WriteLine("Distinct" + Addresses[i].Distinct);
                Console.WriteLine("CreateDate:" + Addresses[i].CreateDate.ToString("MMMM dd, yyyy"));
                if (Addresses[i].EditDate == null)
                    Console.WriteLine("EditDate:" + "Data is not edited");

                else
                    Console.WriteLine("EditDate:" + Addresses[i].EditDate?.ToString("MMMM dd, yyyy"));

                Console.WriteLine("-----------------------");

                Console.WriteLine("City Id:" + Addresses[i].city.Id);
                Console.WriteLine("City Name" + Addresses[i].city.Name);
                Console.WriteLine("City CreateDate:" + Addresses[i].city.CreateDate.ToString("MMMM dd, yyyy"));

                if (Addresses[i].city.EditDate == null)
                    Console.WriteLine("City EditDate:" + "Data is not edited");

                else
                    Console.WriteLine("City EditDate:" + Addresses[i].city.EditDate?.ToString("MMMM dd, yyyy"));

                Console.WriteLine("-----------------------");

                Console.WriteLine("Country Id:" + Addresses[i].city.Country.Id);
                Console.WriteLine("Country Name" + Addresses[i].city.Country.Name);
                Console.WriteLine("Country CreateDate:" + Addresses[i].city.Country.CreateDate.ToString("MMMM dd, yyyy"));

                if (Addresses[i].city.Country.EditDate == null)
                    Console.WriteLine("Country EditDate:" + "Data is not edited");

                else
                    Console.WriteLine("Country EditDate:" + Addresses[i].city.Country.EditDate?.ToString("MMMM dd, yyyy"));

                Console.WriteLine("-----------------------");
            }
        }

        public void ShowOrders()
        {
            int numbersOfOrders = 0;

            for (int i = 0; i < Orders.Length; i++)
            {
                if (Orders[i] != null)
                {
                    numbersOfOrders = i + 1;
                }
            }

            for (int i = 0; i < numbersOfOrders; i++)
            {
                Console.WriteLine("Id:" + Orders[i].Id);
                Console.WriteLine("Details:" + Orders[i].OrderDetails);
                Console.WriteLine("ShippingAddress Id:" + Orders[i].ShippingAddress.Id);
                Console.WriteLine("ShippingAddress Id:" + Orders[i].ShippingAddress.No);
                Console.WriteLine("ShippingAddress Id:" + Orders[i].ShippingAddress.Building);
                Console.WriteLine("ShippingAddress Id:" + Orders[i].ShippingAddress.Street);
                Console.WriteLine("ShippingAddress Id:" + Orders[i].ShippingAddress.Distinct);
                Console.WriteLine("CreateDate:" + Orders[i].CreateDate.ToString("MMMM dd, yyyy"));
                if (Orders[i].EditDate == null)
                    Console.WriteLine("EditDate:" + "Data is not edited");

                else
                    Console.WriteLine("EditDate:" + Orders[i].EditDate?.ToString("MMMM dd, yyyy"));
            }

            Console.WriteLine("-----------------------");

        }

    }
}
