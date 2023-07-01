using EduSys.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
	public class LoginController : CustomBaseController
	{
		private readonly ILoginServiceWithDto _loginService;

		public LoginController(ILoginServiceWithDto loginService)
		{
			_loginService = loginService;
		}
	}
}
