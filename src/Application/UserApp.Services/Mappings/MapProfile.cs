using AutoMapper;

using UserApp.DTO.Requests;
using UserApp.DTO.Responses;
using UserApp.Entities;

namespace UserApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<User, UserResponse>();
            CreateMap<CreateNewUserRequest, User>();
        }
    }
}
