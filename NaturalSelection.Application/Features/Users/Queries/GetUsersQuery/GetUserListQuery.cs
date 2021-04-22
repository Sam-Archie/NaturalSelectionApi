using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Features.Users.Queries.GetUsersQuery
{
    //IRequest is the message that says what we need to do. Here we are making this class a message by letting it
    //implement the IRequest interface.
    //The params for IRequest is going to be the type of data that we are getting back,
    //simply a List of the class that we have passed it
    public class GetUserListQuery : IRequest<List<UserListVm>>
    {

    }
}
