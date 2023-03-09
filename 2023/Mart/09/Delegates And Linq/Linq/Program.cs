using Linq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in Lesson 1
            /*
             Task description:
                  Bir dənə Customer class'ı yaradın və Id, Name, Surname, Age property'ləri olsun. DataSource adında da bir class yaradın və Customers tipində
                  bir list əlavə edin. DataSource class'ının constructor'unda FakeData'ynan həmin Customers listinə 100000 dənə müştəri məlumatları əlavə edin.
                  Daha sonra bu DataSource class'ında 2 method'unuz olacaq. Birinci method parametr olaraq hərf alacaq və o hərflə adı başlayan adamları list
                  olaraq qaytaracaq. İkinci method isə, bir yaş aralığı alacaq və o yaş aralığında olan adamları qaytaracaq. Məsələn 18-25 yaş.
             */

            DataSource ds = new DataSource();

            //Without Linq
            var age18_25 = ds.GetCustomerByAge(18, 25);
            var nameStartsWithB = ds.GetCustomerByFirstLetterOfName('B');


            //With Linq
            var ageFilter = ds.GetCustomerByAgeLinq(18, 25);
            var nameFilter = ds.GetCustomerByFirstLetterOfNameLinq('B');
            #endregion


            #region Linq Queries
            /*
             --- System.Linq ---
             1. ds.Customers.Where()
             2. ds.Customers.FirstOrDefault()
             3. ds.Customers.Max()

             --- System.Collection.Generic ---
             1. ds.Customers.Add()
             2. ds.Customers.AddRange()
             3. ds.Customers.GetEnumerator()
             */

            var maleCustomers = ds.Customers.Where(m => m.Gender == Gender.Male);


            //(Müştəri sayısını almaq)
            var countOfCustomers = ds.Customers.Count;

            //(Ölkəsi Almaniya olmayanları götürmək)
            var notFromGermany = ds.Customers.Where(m => m.Country != "Germany");

            //(Ölkəsi Türkiyə olanları götürmək)
            var fromTurkey = ds.Customers.Where(m => m.Country == "Turkey");

            //(Ölkəsi Almaniya olmayan və yaşı 20-dən böyük olanları götürmək)
            var notFromGermanyAndOver20 = ds.Customers.Where(m => m.Country != "Germany" && m.Age > 20);

            //(Adı t ilə başlayıb, soyadı n ilə bitənləri götürmək)
            var startsT_endsN = ds.Customers.Where(m => 
                m.Name.ToLower().StartsWith("t") &&
                m.Surname.ToLower().EndsWith("n"));

            var notFromGermanyArr = notFromGermany.ToArray();
            var fromTurkeyList = fromTurkey.ToList();

            //IEnumerable System.Collections.Generic-dən gəlir
            IEnumerable<Customer> badQuery = ds.Customers.Where(p => p.Name.StartsWith("N"));
            badQuery = badQuery.Take<Customer>(1);

            //IQueryable System.Linq-dən gəlir
            IQueryable<Customer> goodQuery = ds.Customers.AsQueryable().Where(p => p.Name.StartsWith("N"));
            goodQuery = goodQuery.Take<Customer>(1);

            /*
             bad:  select * from Customers where Name like 'N%';
             good: select top 1 * from Customers where Name like 'N%';
             */

            var methodSyntax = ds.Customers.Where(a =>
                                a.Name.StartsWith("A") &&
                                a.Age >= 45 &&
                                a.Age <= 55)
                                .Count();

            var querySyntax = (from a in ds.Customers where
                                 a.Name.StartsWith("A") &&
                                 a.Age >= 45 &&
                                 a.Age <= 55
                               select a)
                               .Count();

            var customers = ds.Customers.Where(c =>
                                c.Name.ToLower().Contains("r") &&
                                c.IsActive);
            #endregion


            #region Practise Linq
            //1. Ölkəsinin adında b hərfi olan və şəhərinin adı c ilə başlayan
            IEnumerable<Customer> query1 = ds.Customers.Where(m => m.Country.ToLower().Contains("b") && m.City.ToLower().StartsWith("c"));

            //2. Şəhərinin adı a ilə başlayıb e ilə bitən
            IEnumerable<Customer> query2 = ds.Customers.Where(m => m.City.ToLower().StartsWith("a") && m.City.ToLower().EndsWith("e"));

            //3. Adı Jack olanlar
            List<Customer> customersList = ds.Customers
                .Where(m => m.Name == "Jack")
                .ToList();

            //4. Telefon nömrəsi 0555555555 olan bir nəfər
            Customer customer = ds.Customers.FirstOrDefault(m => m.Phone == "0555555555");

            //5. Doğum tarixi 1990-cı il olanlar
            var query3 = ds.Customers.Where(m => m.DateOfBirth.Year == 1990).ToList();

            //6. Doğulduğu ay dekabr olanlardan 2 nəfəri al
            var query4 = ds.Customers.Where(m => m.DateOfBirth.Month == 12).Take(2).ToList();
            #endregion




            
            #region Func Delegate
            //1. Simple Lambda Expression to get Customers whose e-mail address starts with A
            var q1 = ds.Customers.Where(m => m.Email.ToLower().StartsWith("a"));

            //2. Standart Delegate with method
            bool StartsWithA(Customer m) {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            }
            Func<Customer, bool> startsWithA_delegate = new Func<Customer, bool>(StartsWithA);
            var q2 = ds.Customers.Where(startsWithA_delegate);

            //3. Pass method directly to Where with Func<>
            var q3 = ds.Customers.Where(new Func<Customer, bool>(StartsWithA));

            //4. Write without Func<>.
            var q4 = ds.Customers.Where(delegate (Customer m)
            {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            });

            //5. Write without delegate
            var q5 = ds.Customers.Where((Customer m) => { return m.Email[0] == 'A' ? true : false; });

            //6. Write without object type
            var q6 = ds.Customers.Where((m) => { return m.Email[0] == 'A' ? true : false; });

            //7. Again lambda expression (shortest way)
            var q7 = ds.Customers.Where(m => m.Email[0] == 'A');
            #endregion






            #region Predicate Delegate
            //1. Normal FindAll method
            var p1 = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));

            //2. Long version
            bool predicateDelegateMethod(Customer m)
            {
                if (m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12))
                    return true;
                else
                    return false;
            }

            Predicate<Customer> predicate = new Predicate<Customer>(predicateDelegateMethod);

            var delegate1 = ds.Customers.FindAll(predicate);

            //3. Short versions
            var delegate2 = ds.Customers.FindAll(new Predicate<Customer>(predicateDelegateMethod));

            var delegate3 = ds.Customers.FindAll(delegate (Customer m) { return m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12); });

            var delegate4 = ds.Customers.FindAll((Customer m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));

            var delegate5 = ds.Customers.FindAll((m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));

            //4. Shortest version
            var delegate6 = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));
            #endregion




            #region Action delegate
            //1. Normal foreach
            foreach (var item in ds.Customers)
            {
                Console.WriteLine($"{item.Name} {item.Surname} is {item.Age} years old.");
            }

            //2. With ForEach method which is in Collections Generic
            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            //3. Long Action delegate
            void ShowCustomerInfo(Customer m)
            {
                Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old.");
            }

            Action<Customer> action = new Action<Customer>(ShowCustomerInfo);
            ds.Customers.ForEach(action);

            //4. Short versions
            ds.Customers.ForEach(new Action<Customer>(ShowCustomerInfo));

            ds.Customers.ForEach(delegate (Customer m) { Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."); });

            ds.Customers.ForEach((Customer m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            //5. Shortest versions
            ds.Customers.ForEach((m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));
            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));
            #endregion
        }
    }
}
