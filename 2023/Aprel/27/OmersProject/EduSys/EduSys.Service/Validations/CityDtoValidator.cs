using EduSys.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Validations
{
	public class CityDtoValidator : AbstractValidator<CityDto>
	{
		public CityDtoValidator()
		{
			RuleFor(x => x.Name)
				.MinimumLength(2)
				.WithMessage("{PropertyName} is min length is 2 charachter!")
				.MaximumLength(200)
				.WithMessage("{PropertyName} is max length is 200 charachter!")
				.NotNull()
				.WithMessage("{PropertyName} is required")
				.NotEmpty()
				.WithMessage("{PropertyName} is required");
		}
	}
}
