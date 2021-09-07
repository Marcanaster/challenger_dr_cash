using AutoMapper;
using DrCash.Domain.Dtos.Autor;
using DrCash.Domain.Entities;
using DrCash.Domain.Interfaces.Repositories;
using DrCash.Domain.Interfaces.Services.Autor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrCash.Service.Services
{
    public class AutorService : IAutorService
    {
        private IRepository<AutorEntity> _repository;
        private readonly IMapper _mapper;
        public AutorService(IRepository<AutorEntity> repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<AutorEntity> Get(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<AutorEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<AutorEntity> Post(AutorCreateDto autor)
        {
            var entity = _mapper.Map<AutorEntity>(autor);

            return await _repository.InsertAsync(entity);
        }

        public async Task<AutorEntity> Put(AutorEntity autor)
        {
            return await _repository.UpdateAsync(autor);
        }
    }
}
