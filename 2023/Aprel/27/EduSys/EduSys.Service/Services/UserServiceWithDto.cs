using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Services
{
    public class UserServiceWithDto : ServiceWithDto<User, UserDto>, IUserServiceWithDto
    {
        private readonly IUserServiceWithDto _userRepository;

        public UserServiceWithDto(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper, IUserServiceWithDto userRepository)
            : base(repository, unitOfWork, mapper)
        {
            _userRepository = userRepository;
        }
    }
}
