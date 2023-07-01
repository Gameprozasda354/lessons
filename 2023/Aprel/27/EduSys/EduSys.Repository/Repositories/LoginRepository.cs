using EduSys.Core.Models;
using EduSys.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Repositories
{
    public class LoginRepository : GenericRepository<User>, IRegistrationRepository
    {
        public LoginRepository(AppDbContext context) : base(context)
        {

        }
    }
}
