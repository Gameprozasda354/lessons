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

			RuleFor(x => x.SurName)
				.MinimumLength(2)
				.WithMessage("{PropertyName} is min length is 2 charachter!")
				.MaximumLength(50)
				.WithMessage("{PropertyName} is max length is 50 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");

			RuleFor(x => x.DateOfBirth)
				.ExclusiveBetween(new DateTime(1950, 01, 01), DateTime.Now)
				.WithMessage("{PropertyName} range must be 1950-Now");

			RuleFor(x => x.EmailAddress)
				.MinimumLength(5)
				.WithMessage("{PropertyName} is min length is 5 charachter!")
				.MaximumLength(250)
				.WithMessage("{PropertyName} is max length is 250 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");


			RuleFor(x => x.EmailAddress)
				.MinimumLength(5)
				.WithMessage("{PropertyName} is min length is 5 charachter!")
				.MaximumLength(250)
				.WithMessage("{PropertyName} is max length is 250 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");

			RuleFor(x => x.Password)
				.MinimumLength(6)
				.WithMessage("{PropertyName} is min length is 6 charachter!")
				.MaximumLength(15)
				.WithMessage("{PropertyName} is max length is 15 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");

			RuleFor(x => x.CountryId)
				.ExclusiveBetween(0, int.MaxValue)
				.WithMessage("{PropertyName} must be greater than 0");
		}
	}
}
