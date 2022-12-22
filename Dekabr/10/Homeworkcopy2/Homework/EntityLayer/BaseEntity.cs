using Homework.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.EntityLayer
{
    public class BaseEntity
    {
        public int Id { get; private set; } = 0;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int EditUser { get; set; }
        public DateTime EditDate { get; set; }
        public int DeleteUser { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            this.Id += 1;
        }
    }
}
