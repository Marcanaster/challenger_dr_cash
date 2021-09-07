using AutoMapper;
using DrCash.CrossCutting.Helper;
using DrCash.Domain.Dtos;
using DrCash.Domain.Entities;
using DrCash.Domain.Interfaces.Repositories;
using DrCash.Domain.Interfaces.Services.User;
using DrCash.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DrCash.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UserService(IRepository<UserEntity> repository, IMapper mapper, IConfiguration configuration)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._configuration = configuration;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(Guid id)
        {
            var entity = await _repository.GetAsync(id);
            return _mapper.Map<UserDto>(entity) ?? new UserDto();
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var listEntity = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(listEntity);
        }

        public async Task<UserDtoCreateResult> Post(UserDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            model.senha = Crypt.Encrypt(model.senha, _configuration["KEY_CRYPT"]);
            var entity = _mapper.Map<UserEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<UserDtoCreateResult>(result);
        }

        public async Task<UserDtoUpdateResult> Put(UserDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            model.senha = Crypt.Encrypt(model.senha, _configuration["KEY_CRYPT"]);
            var entity = _mapper.Map<UserEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UserDtoUpdateResult>(result);
        }
    }
}
