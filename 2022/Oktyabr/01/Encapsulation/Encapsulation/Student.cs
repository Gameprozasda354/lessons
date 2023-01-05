using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        public string Name;
        public string Surname;
        private string email;

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Length > 15)
                    this.email = value;
                else
                    this.email = "";
            }
        }

        public Student()
        {
            this.id = GenerateId();
        }


        #region Id Generator
        int id;

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9000000);
        }
        #endregion



        private string _documentSerial;
        public string DocumentSerial
        {
            get
            {
                return _documentSerial;
            }
            set
            {
                if(value.Length == 2)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsLetter(value[i]);

                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                    else
                        this._documentSerial = value;
                }
                else
                {
                    Console.WriteLine("Veiqenin seriyasinin uzunlugu 2 olmalidir.");
                }
            }
        }

        private string _documentNumber;
        public string DocumentNumber
        {
            get
            {
                var length = _documentNumber.Length;
                var showFirstNLetter = 3;
                var hiddenString = "";

                for (int i = 0; i < (length - showFirstNLetter); i++)
                {
                    hiddenString += "*";
                }

                return _documentNumber.Substring(0, showFirstNLetter) + hiddenString;
            }
            set
            {
                if (value.Length == 8)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsNumber(value[i]);

                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir.");
                    else
                        this._documentNumber = value;
                }
                else
                {
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir!");
                }
            }
        }
    }
}
