using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Book //: Repository<Book>
    {
        public string Name { get; set; }
        public int CreateYear { get; set; }

        public Book(string name, int createYear)
        {
            this.Name = name;
            this.CreateYear = createYear;
        }

        public override string ToString()
        {
            return Name + " " + CreateYear;
        }

        //public override void Show()
        //{
        //    this.DataSource.ForEach(m => Console.WriteLine(m.Name + " " + m.CreateYear));
        //}
    }
}
