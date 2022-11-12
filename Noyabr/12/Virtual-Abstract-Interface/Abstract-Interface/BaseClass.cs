using System;

namespace Abstract_Interface
{
    public abstract class BaseClass
    {
        #region Abstract class
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        public BaseClass()
        {
            CreateDate = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("BaseClass -> Test() method.");
        }

        private void ShowText(string text)
        {
            Console.WriteLine(text);
        }
        #endregion


        #region Abstract methods
        public abstract void ShowTime();
        #endregion
    }
}
