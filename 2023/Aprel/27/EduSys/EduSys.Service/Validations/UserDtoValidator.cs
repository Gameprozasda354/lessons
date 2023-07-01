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
                .MinimumLength(2)
                .WithMessage("{PropertyName} min length is 2 character!")
                .MaximumLength(50)
                .WithMessage("{PropertyName} max length is 50 character!")
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .NotEmpty()
                .WithMessage("{PropertyName} is required");

            RuleFor(x => x.Surname)
                .MinimumLength(2)
                .WithMessage("{PropertyName} min length is 2 character!")
                .MaximumLength(50)
                .WithMessage("{PropertyName} max length is 50 character!")
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .NotEmpty()
                .WithMessage("{PropertyName} is required");

            RuleFor(x => x.DateOfBirth)
                .ExclusiveBetween(DateTime.Now.AddYears(-100), DateTime.Now.AddYears(-18))
                .WithMessage("You must be minimal 18 and maximal 100 years old!");

            RuleFor(x => x.EmailAddress)
                .MinimumLength(5)
                .WithMessage("{PropertyName} min length is 5 character!")
                .MaximumLength(255)
                .WithMessage("{PropertyName} max length is 255 character!")
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .NotEmpty()
                .WithMessage("{PropertyName} is required");

            RuleFor(x => x.Password)
                .MinimumLength(6)
                .WithMessage("{PropertyName} min length is 6 character!")
                .MaximumLength(15)
                .WithMessage("{PropertyName} max length is 15 character!")
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .NotEmpty()
                .WithMessage("{PropertyName} is required");

            RuleFor(x => x.CountryId)
                .ExclusiveBetween(0, int.MaxValue)
                .WithMessage("{PropertyName} must be grater than 0");
        }
    }
}
