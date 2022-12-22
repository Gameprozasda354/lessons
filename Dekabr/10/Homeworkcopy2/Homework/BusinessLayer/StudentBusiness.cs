using Homework.EntityLayer;
using Homework.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.BusinessLayer
{
    public class StudentBusiness : GenericRepository<Student>
    {
        public override Student Get(int id)
        {
            return Database.StudentTable.FirstOrDefault(m => m.Id == id);
        }

        public override List<Student> GetAll()
        {
            return Database.StudentTable.ToList();
        }

        public override void Add(Student entity)
        {
            Database.StudentTable.Add(entity);
        }

        public override void Update(Student entity)
        {
            var indexOf = Database.StudentTable.IndexOf(Database.StudentTable.Find(m => m.Id == entity.Id));
            Database.StudentTable[indexOf] = entity;
        }

        public override void Delete(Student entity)
        {
            Database.StudentTable.Remove(entity);
        }
    }
}
