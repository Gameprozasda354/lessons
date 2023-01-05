using Homework.DataLayer;
using Homework.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.BusinessLayer
{
    public class BookBusiness : GenericRepository<Book>
    {
        public override Book Get(int id)
        {
            return Database.BookTable.FirstOrDefault(m => m.Id == id);
        }

        public override List<Book> GetAll()
        {
            return Database.BookTable.ToList();
        }

        public override void Add(Book entity)
        {
            Database.BookTable.Add(entity);
        }

        public override void Update(Book entity)
        {
            var indexOf = Database.BookTable.IndexOf(Database.BookTable.Find(m=>m.Id == entity.Id));
            Database.BookTable[indexOf] = entity;
        }

        public override void Delete(Book entity)
        {
            Database.BookTable.Remove(entity);
        }

        public Book GetByBookName(string name)
        {
            return Database.BookTable.FirstOrDefault(m => m.Name == name);
        }
    }
}
