using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Staff
    {
        private static string domain;
        private string name;
        private string surName;
        private string gender;

        public string Name
        {
            set
            {
                name = value;
            }

            get
            {

                return name;
            }
        }

        public string SurName
        {
            set
            {
                surName = value;
            }

            get
            {

                return surName;
            }
        }

        public string Gender
        {
            set
            {
                gender = value;
            }

            get
            {
                return gender;
            }

        }
        public static string Domain
        {
            get 
            {
                domain = "@gmail.com";
                return domain; 
            }
        }
        

        public string Email
        {
            set
            {
                this.Email = value;
                
            }
            get
            {
                Console.WriteLine("Bu methodda sifre deyisilir mesaji gonderilir.");
                return this.Email;
            }
        }

    }
}
