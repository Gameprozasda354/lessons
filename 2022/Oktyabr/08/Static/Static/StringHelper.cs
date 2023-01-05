﻿namespace Static
{
    public class StringHelper
    {
        public static string CheckFullName(string name, string surname)
        {
            string fullname;

            if((name+surname).Length > 20)
            {
                fullname = name[0] + ". " + surname;
                return fullname;
            }

            return name + " " + surname;
        }
    }
}
