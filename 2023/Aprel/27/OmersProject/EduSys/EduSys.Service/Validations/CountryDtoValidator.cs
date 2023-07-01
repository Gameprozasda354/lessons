using EduSys.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Validations
{
	public class CountryDtoValidator : AbstractValidator<CountryDto>
	{
		public CountryDtoValidator()
		{
			RuleFor(x => x.Name)
				.MinimumLength(2)
				.WithMessage("{PropertyName} is min length is 2 charachter!")
				.MaximumLength(50)
				.WithMessage("{PropertyName} is max length is 50 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");

			RuleFor(x => x.ShortName)
				.MinimumLength(2)
				.WithMessage("{PropertyName} is min length is 2 charachter!")
				.MaximumLength(3)
				.WithMessage("{PropertyName} is max length is 3 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required")
				.MaximumLength(3)
				.WithMessage("{PropertyName} max. length is 3");
		}
	}
}
