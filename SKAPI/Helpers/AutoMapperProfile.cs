using AutoMapper;
using SKAPI.Entities;
using SKAPI.Models.Users;

namespace SKAPI.Helpers
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}