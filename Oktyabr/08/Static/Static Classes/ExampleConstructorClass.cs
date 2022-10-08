using System;

namespace Static_Classes
{
    public static class ExampleConstructorClass
    {
        //public ExampleConstructorClass() //error verecek
        //{

        //}

        static ExampleConstructorClass()
        {
            Console.WriteLine("ctor...");
        }

        #region Static ShowPersonInfo method
        public static void ShowPersonInfo()
        {
            Console.WriteLine("Name: Orkhan");
            Console.WriteLine("Surname: Farajov");
            Console.WriteLine("Age: 27");
        }
        #endregion
    }
}
