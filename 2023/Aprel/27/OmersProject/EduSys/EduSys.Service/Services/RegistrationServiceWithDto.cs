using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Helpers;
using EduSys.Core.Models;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using EduSys.Repository.UnitOfWork;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Services
{
	public class RegistrationServiceWithDto : ServiceWithDto<User, UserDto>, IRegistrationServiceWithDto
	{

		private readonly IUnitOfWork _unitOfWork;

		private readonly IMapper _mapper;

		private readonly IRegistrationRepository _registrationRepository;

		public RegistrationServiceWithDto(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper, IRegistrationRepository registrationRepository)
			: base(repository, unitOfWork, mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_registrationRepository = registrationRepository;
		}

		public async Task<CustomResponseDto<UserDto>> Register(UserDto user)
		{
			user.Password = UserHelper.HashPassword(user.Password);

			var newEntity = _mapper.Map<User>(user);

			await _registrationRepository.AddAsync(newEntity);

			await _unitOfWork.CommitAsync();

			var newDto = _mapper.Map<UserDto>(newEntity);

			return CustomResponseDto<UserDto>.Success(StatusCodes.Status200OK, newDto);
		}

	}
}
