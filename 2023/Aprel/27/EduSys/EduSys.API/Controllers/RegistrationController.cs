using EduSys.Core.DTOs;
using EduSys.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
    public class RegistrationController : CustomBaseController
    {
        private readonly IRegistrationServiceWithDto _registrationService;

        public RegistrationController(IRegistrationServiceWithDto registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserDto user)
        {
            return CreateActionResult(await _registrationService.Register(user));
        }
    }
}
