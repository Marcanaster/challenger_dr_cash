using AutoMapper;
using DrCash.Domain.Dtos;
using DrCash.Domain.Dtos.Autor;
using DrCash.Domain.Dtos.Genero;
using DrCash.Domain.Dtos.Livro;
using DrCash.Domain.Entities;

namespace DrCash.Service.mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();
            CreateMap<AutorCreateDto, AutorEntity>().ReverseMap();
            CreateMap<LivroCreateDto, LivroEntity>().ReverseMap();
            CreateMap<GeneroCreateDto, GeneroEntity>().ReverseMap();
        }
    }
}
