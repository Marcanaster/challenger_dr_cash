using DrCash.Domain.Dtos.Livro;
using DrCash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrCash.Domain.Interfaces.Services.Livro
{
    public interface ILivroService
    {
        Task<LivroEntity> Get(Guid id);
        Task<IEnumerable<LivroEntity>> GetAll();
        Task<LivroEntity> Post(LivroCreateDto livro);
        Task<LivroEntity> Put(LivroEntity livro);
        Task<bool> Delete(Guid id);
    }
}
