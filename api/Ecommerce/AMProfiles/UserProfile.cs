using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;

namespace Ecommerce.AMProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}