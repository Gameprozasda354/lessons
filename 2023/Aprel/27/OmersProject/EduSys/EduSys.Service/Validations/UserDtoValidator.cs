using EduSys.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Validations
{
	public class UserDtoValidator : AbstractValidator<UserDto>
	{
		public UserDtoValidator()
		{
			RuleFor(x => x.Name)
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");
		}
	}
}
