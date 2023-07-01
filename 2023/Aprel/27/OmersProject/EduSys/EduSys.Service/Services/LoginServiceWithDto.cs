using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Services
{
	public class LoginServiceWithDto : ServiceWithDto<User, UserDto>, ILoginServiceWithDto
	{

		private readonly ILoginServiceWithDto _loginRepository;

		public LoginServiceWithDto(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper, ILoginServiceWithDto loginRepository)
			: base(repository, unitOfWork, mapper)
		{
			_loginRepository = loginRepository;
		}

	}
}
