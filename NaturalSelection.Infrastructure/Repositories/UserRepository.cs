using NaturalSelection.Application.Contracts.Persistance;
using NaturalSelection.Core.Data;
using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(NaturalSelectionContext dbContext) : base(dbContext)
        {

        }

        public Task<bool> IsUserNameUnique(string userName)
        {
            var matches = _dbContext.Users.Any(user => user.UserName.Equals(userName));

            return Task.FromResult(matches);
        }
    }
}
