using System;

namespace Abstract_Interface
{
    public class Customer : BaseClass
    {
        #region Abstract class
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer()
        {
            Console.WriteLine("Customer constructor");
        }
        #endregion

        #region Abstract methods
        public override void ShowTime()
        {
            Console.WriteLine("Customer -> ShowTime {0}", DateTime.Now);
        }
        #endregion
    }
}
