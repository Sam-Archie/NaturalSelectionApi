using NaturalSelection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Features.Users.Queries.GetUsersQuery
{
    public class UserListVm
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
    }
}
