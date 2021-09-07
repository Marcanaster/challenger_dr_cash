using AutoMapper;
using DrCash.Domain.Entities;
using DrCash.Domain.Models;

namespace DrCash.Service.mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}
