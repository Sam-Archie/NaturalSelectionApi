using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NaturalSelection.Application.Features.Users.Queries.GetUsersQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalSelection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _meidator;

        public UserController(IMediator meidator)
        {
            _meidator = meidator;
        }

        [HttpGet("Users")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<List<UserListVm>>> GetAllUsers()
        {
            var allUsersAsDtos = await _meidator.Send(new GetUserListQuery());

            return Ok(allUsersAsDtos);
        }

    }
}
