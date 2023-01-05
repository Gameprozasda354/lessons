using Homework.DataLayer;
using Homework.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.BusinessLayer
{
    public class TeacherBusiness : GenericRepository<Teacher>
    {
        public override Teacher Get(int id)
        {
            return Database.TeacherTable.FirstOrDefault(m => m.Id == id);
        }

        public override List<Teacher> GetAll()
        {
            return Database.TeacherTable.ToList();
        }

        public override void Add(Teacher entity)
        {
            Database.TeacherTable.Add(entity);
        }

        public override void Update(Teacher entity)
        {
            var indexOf = Database.TeacherTable.IndexOf(Database.TeacherTable.Find(m => m.Id == entity.Id));
            Database.TeacherTable[indexOf] = entity;
        }

        public override void Delete(Teacher entity)
        {
            Database.TeacherTable.Remove(entity);
        }
    }
}
