namespace StaticHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Email = "orkhankhf@gmail.com",
                Username = "orkhankhf",
                Password = "1"
            };

            Customer.AddCustomer(customer1);

            Customer customer2 = new Customer()
            {
                Id = 1,
                Name = "Elvin",
                Surname = "Jafarov",
                Email = "elvin@gmail.com",
                Username = "elvinj",
                Password = "15s6ffesS"
            };

            Customer.AddCustomer(customer2);

            Customer customer3 = new Customer()
            {
                Id = 1,
                Name = "Elvin",
                Surname = "Qafarov",
                Email = "elvin@gmail.com",
                Username = "elvinj",
                Password = "15s6ffesS"
            };

            Customer.AddCustomer(customer2);
        }
    }
}
