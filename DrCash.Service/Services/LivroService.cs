using AutoMapper;
using DrCash.Domain.Dtos.Livro;
using DrCash.Domain.Entities;
using DrCash.Domain.Interfaces.Repositories;
using DrCash.Domain.Interfaces.Services.Livro;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrCash.Service
{
    public class LivroService : ILivroService
    {
        private IRepository<LivroEntity> _repository;
        private readonly IMapper _mapper;
        public LivroService(IRepository<LivroEntity> repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<LivroEntity> Get(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<LivroEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<LivroEntity> Post(LivroCreateDto livro)
        {
            try
            {
                var entity = _mapper.Map<LivroEntity>(livro);
                return await _repository.InsertAsync(entity);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<LivroEntity> Put(LivroEntity livro)
        {
            return await _repository.UpdateAsync(livro);
        }
    }
}
