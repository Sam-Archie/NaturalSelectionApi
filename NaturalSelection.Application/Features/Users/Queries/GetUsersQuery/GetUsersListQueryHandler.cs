using AutoMapper;
using MediatR;
using NaturalSelection.Application.Contracts.Persistance;
using NaturalSelection.Data.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Features.Users.Queries.GetUsersQuery
{
    //The handler will be triggered when the message is being sent and will contain the business logic,
    //this is triggered by meidatR when the message is sent form the query.
    //We specify that it implements the IRequest Handler for GetUserQuery and will be returning  List<UserListVm
    //This method "Handle" called handle will be fired off when a  GetUsersListQuery is called
    public class GetUsersListQueryHandler : IRequestHandler<GetUserListQuery, List<UserListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<User> _userRepository;

        public GetUsersListQueryHandler(IMapper mapper, IAsyncRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        //Here we are mapping entities to Vm's so that we are in control of what the client gets back
        //Automapper allows us to do this, automapper needs profiles for this to work 
        public async Task<List<UserListVm>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var listOfAllUsers = (await _userRepository.ListAllAsync()).OrderBy(x => x.UserName);
            return _mapper.Map<List<UserListVm>>(listOfAllUsers);
        }
    }
}
