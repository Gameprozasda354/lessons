using Homework.EntityLayer;
using Homework.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.BusinessLayer
{
    public class CustomerBusiness : GenericRepository<Customer>
    {
        public override Customer Get(int id)
        {
            return Database.CustomerTable.FirstOrDefault(m => m.Id == id);
        }

        public override List<Customer> GetAll()
        {
            return Database.CustomerTable.ToList();
        }

        public override void Add(Customer entity)
        {
            Database.CustomerTable.Add(entity);
        }

        public override void Update(Customer entity)
        {
            var indexOf = Database.CustomerTable.IndexOf(Database.CustomerTable.Find(m => m.Id == entity.Id));
            Database.CustomerTable[indexOf] = entity;
        }

        public override void Delete(Customer entity)
        {
            Database.CustomerTable.Remove(entity);
        }
    }
}
