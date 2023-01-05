using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.EntityLayer
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int CreateYear { get; set; }

        public Book(string name, int createYear)
        {
            this.Name = name;
            this.CreateYear = createYear;
        }
    }
}
