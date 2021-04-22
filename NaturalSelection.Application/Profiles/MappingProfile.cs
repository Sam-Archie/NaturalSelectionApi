using AutoMapper;
using NaturalSelection.Application.Features.Users.Queries.GetUsersQuery;
using NaturalSelection.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Profiles
{
    //In the ctor we write our mappings
    //Specification allows us to map from User to User List vm and vice versa this is what the reverse map method allows us to do
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserListVm>().ReverseMap();
        }
    }
}
