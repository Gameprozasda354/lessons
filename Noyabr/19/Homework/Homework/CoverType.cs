using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class CoverType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CoverType()
        {
            DataBase.Id += 1;
        }
    }
}
