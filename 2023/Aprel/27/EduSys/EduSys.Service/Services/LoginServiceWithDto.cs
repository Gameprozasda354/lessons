using AutoMapper;
using EduSys.Common.Helpers;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using EduSys.Repository.Repositories;
using EduSys.Service.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Services
{
    //orkhan@google.com
    //orxan123
    public class LoginServiceWithDto : ServiceWithDto<User, LoginDto>, ILoginServiceWithDto
    {
        private readonly ILoginRepository _loginRepository;

        public LoginServiceWithDto(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper, ILoginRepository loginRepository)
            : base(repository, unitOfWork, mapper)
        {
            _loginRepository = loginRepository;
        }

        public async Task<CustomResponseDto<bool>> Login(LoginDto loginInfo)
        {
            loginInfo.Password = UserHelper.HashPassword(loginInfo.Password);

            var checkUserLogin = _loginRepository.Where(m => m.EmailAddress.ToLower() == loginInfo.Email.ToLower() && m.Password == loginInfo.Password)
                .FirstOrDefault();

            if (checkUserLogin == null)
                throw new ClientSideException("Email address is duplicate!");

            return CustomResponseDto<bool>.Success(StatusCodes.Status200OK, true);
        }
    }
}
