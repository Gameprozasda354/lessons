using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        void ShowStudentInfo();

        void Add(string name, string surname);
        void Update(int id, string name, string surname);
        void Delete(int id);
    }
}
