using System;
using NaturalSelection.Core.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaturalSelection.Data.Entites;

namespace NaturalSelection.Application.Contracts.Persistance
{
    public interface IUserRepository : IAsyncRepository<User>
    {

    }
}
