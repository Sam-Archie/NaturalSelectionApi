using NaturalSelection.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandResponse : BaseResponse
    {
        public CreateUserCommandResponse() : base()
        {

        }
        public UserDto User { get; set; }
    }
}
