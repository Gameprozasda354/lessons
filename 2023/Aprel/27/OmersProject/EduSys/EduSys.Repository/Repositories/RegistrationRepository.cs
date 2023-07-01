using EduSys.Core.Models;
using EduSys.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Repositories
{
	public class RegistrationRepository : GenericRepository<User>, IRegistrationRepository
	{
		public RegistrationRepository(AppDbContext context) : base(context)
		{
		}
	}
}
