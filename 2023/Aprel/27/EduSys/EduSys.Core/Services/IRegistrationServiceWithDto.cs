using EduSys.Core.DTOs;
using EduSys.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.Services
{
    public interface IRegistrationServiceWithDto : IServiceWithDto<User, UserDto>
    {
        Task<CustomResponseDto<UserDto>> Register(UserDto dto);
    }
}
