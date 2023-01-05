using System;

namespace Static_Classes
{
    public class Employee
    {
        public static string domain;
        public string Name { get; set; }
        public string Surname { get; set; }

        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value.ToLower() + "@" + Employee.domain;
            }
        }

        public Employee()
        {
            Console.WriteLine("Bu constructor method her instance yaradilan zaman ise dusecek");
        }

        static Employee()
        {
            domain = "google.com";
        }
    }
}
