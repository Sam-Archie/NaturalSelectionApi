﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Features.Users.Commands.CreateUser
{
    class CreateUserCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
        private bool IsAdmin { get; set; }
        public string Password { get; set; }
    }
}
