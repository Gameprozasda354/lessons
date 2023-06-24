using EduSys.API.Filters;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
	public class UsersController : CustomBaseController
	{
		private readonly IServiceWithDto<User, UserDto> _userService;

		public UsersController(IServiceWithDto<User, UserDto> userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			return CreateActionResult(await _userService.GetAllAsync());
		}

		[ServiceFilter(typeof(NotFoundFilter<User>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return CreateActionResult(await _userService.GetByIdAsync(id));
		}

		[HttpPost]
		public async Task<IActionResult> Save(UserDto user)
		{
			return CreateActionResult(await _userService.AddAsync(user));
		}

		[HttpPut]
		public async Task<IActionResult> Update(UserDto user)
		{
			return CreateActionResult(await _userService.UpdateAsync(user));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		{
			return CreateActionResult(await _userService.RemoveAsync(id));
		}

		[HttpPost("SaveAll")]
		public async Task<IActionResult> Save(List<UserDto> usersDtos)
		{
			return CreateActionResult(await _userService.AddRangeAsync(usersDtos));
		}

		[HttpDelete("RemoveAll")]
		public async Task<IActionResult> RemoveAll(List<int> id)
		{
			return CreateActionResult(await _userService.RemoveRangeAsync(id));
		}

		[HttpGet("Any/{id}")]
		public async Task<IActionResult> Any(int id)
		{
			return CreateActionResult(await _userService.AnyAsync(x => x.Id == id));
		}
	}
}
