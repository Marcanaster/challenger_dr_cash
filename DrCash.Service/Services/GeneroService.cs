using AutoMapper;
using DrCash.Domain.Dtos.Genero;
using DrCash.Domain.Entities;
using DrCash.Domain.Interfaces.Repositories;
using DrCash.Domain.Interfaces.Services.Genero;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrCash.Service
{
    public class GeneroService : IGeneroService
    {
        private IRepository<GeneroEntity> _repository;
        private IMapper _mapper;
        public GeneroService(IRepository<GeneroEntity> repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<GeneroEntity> Get(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<GeneroEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<GeneroEntity> Post(GeneroCreateDto genero)
        {
            var entity = _mapper.Map<GeneroEntity>(genero);
            return await _repository.InsertAsync(entity);
        }

        public async Task<GeneroEntity> Put(GeneroEntity genero)
        {
            return await _repository.UpdateAsync(genero);
        }
    }
}
