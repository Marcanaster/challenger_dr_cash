using AutoMapper;
using DrCash.Domain.Dtos;
using DrCash.Domain.Models;

namespace DrCash.Service.mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
            
        }
    }
}
