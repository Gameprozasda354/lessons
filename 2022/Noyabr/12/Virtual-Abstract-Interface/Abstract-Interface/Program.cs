namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Abstract and Interface?
            Customer customer = new Customer();

            customer.Test();
            //customer.ShowText();


            Customer customer1 = new Customer();
            customer1.ShowTime();

            VipCustomer vip = new VipCustomer();
            vip.ShowTime();
            #endregion
        }
    }
}
