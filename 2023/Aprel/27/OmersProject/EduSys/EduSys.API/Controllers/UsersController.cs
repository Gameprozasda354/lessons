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
		private readonly IUserServiceWithDto _userService;

		public UsersController(IUserServiceWithDto userService)
		{
			_userService = userService;
		}

		[ServiceFilter(typeof(NotFoundFilter<User>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return CreateActionResult(await _userService.GetByIdAsync(id));
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

		[HttpGet("Any/{id}")]
		public async Task<IActionResult> Any(int id)
		{
			return CreateActionResult(await _userService.AnyAsync(x => x.Id == id));
		}
	}
}
