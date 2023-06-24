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
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");

			RuleFor(x => x.ShortName)
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required")
				.MaximumLength(3)
				.WithMessage("{PropertyName} max. length is 3");
		}
	}
}
