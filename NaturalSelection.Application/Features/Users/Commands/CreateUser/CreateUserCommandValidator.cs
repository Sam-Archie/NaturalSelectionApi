using FluentValidation;
using NaturalSelection.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Features.Users.Commands.CreateUser
{
    class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 charecters.");

            RuleFor(user => user.LastName).NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 charecters.");

            RuleFor(user => user.UserName).NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 charecters.");

            RuleFor(user => user.Email).NotEmpty().WithMessage("Email address is required")
                     .EmailAddress().WithMessage("A valid email is required");

            RuleFor(user => user.Password).NotEmpty().WithMessage("Please enter the password");

            RuleFor(user => user.UserName).MustAsync(UserNameUnique).WithMessage("UserName is already taken");

        }

        private async Task<bool> UserNameUnique(string userName, CancellationToken token)
        {
            return !(await _userRepository.IsUserNameUnique(userName));
        }
    }
}
