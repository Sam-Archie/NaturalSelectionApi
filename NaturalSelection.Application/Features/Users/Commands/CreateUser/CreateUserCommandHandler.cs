using AutoMapper;
using MediatR;
using NaturalSelection.Application.Contracts.Persistance;
using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NaturalSelection.Application.Responses;
using Microsoft.Extensions.Logging;

namespace NaturalSelection.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var createUserCommandResponse = new CreateUserCommandResponse();

            var validator = new CreateUserCommandValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                createUserCommandResponse.Success = false;
                createUserCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                createUserCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
            if (createUserCommandResponse.Success)
            {
                var user = new User()
                {
                    UserName = request.UserName,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    DateOfBirth = request.DateOfBirth,
                    Active = true,
                    Email = request.Email,
                    IsSubscribed = false,
                    ProfileImage = request.ProfileImage
                };

                user = await _userRepository.AddAsync(user);

                createUserCommandResponse.User = _mapper.Map<UserDto>(user);
            }
            return createUserCommandResponse;
        }
    }
}
 