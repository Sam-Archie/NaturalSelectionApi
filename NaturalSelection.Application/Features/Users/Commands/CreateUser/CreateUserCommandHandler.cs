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

namespace NaturalSelection.Application.Features.Users.Commands.CreateUser
{
    class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _eventRepository;

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _eventRepository = userRepository;
        }
        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            user = await _eventRepository.AddAsync(user);

            return user.Id;
        }
    }
}
