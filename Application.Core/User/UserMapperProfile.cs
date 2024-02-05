using Application.Dto.User;
using AutoMapper;
using Tickets.Domain.User;

namespace Application.Core.User;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<UserEntity, UserDto>().ReverseMap();
    }
}