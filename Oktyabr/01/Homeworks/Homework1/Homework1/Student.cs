using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Student
    {

        private string name;
        private string surName;
        private string email;


        public string Name
        {
            set
            {
                if(surName == null)
                {
                    name = value;
                    surName = null;
                    email = null;
                }

                else
                {
                    name = value;
                    email = value.ToLower() + "." + surName.ToLower() + "@gmail.com";
                }

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
                if (name == null)
                {
                    surName = value;
                    name = null;
                    email = null;
                }

                else
                {
                    surName = value;
                    email = name.ToLower() + "." + value.ToLower() + "@gmail.com";
                }
            }

            get
            {
                return surName;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

    }
}
