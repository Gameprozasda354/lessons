using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class BooksRepository
    {
        public virtual List<Book<string, int>> Get()
        {
            return null;
        }
        List<Book<string, int>> list = new List<Book<string, int>>();
        public virtual void Add(Book<string, int> data)
        {

            list.Add(data);
            Console.WriteLine("Data elave olundu.");
        }
        public virtual void Show()
        {
            list.ForEach(a => Console.WriteLine(a));
        }
        public virtual void Uptade(Book<string, int> data)
        {
            if (list.Contains(data))
            {
                Console.WriteLine("Datanin Adini ne ile evezlemek isteyirsiniz?");
                var name = Console.ReadLine();
                list[list.IndexOf(data)].Name = name;
            }
        }
    }
}
