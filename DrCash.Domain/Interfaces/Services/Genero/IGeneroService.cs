using DrCash.Domain.Dtos.Genero;
using DrCash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrCash.Domain.Interfaces.Services.Genero
{
    public interface IGeneroService
    {
        Task<GeneroEntity> Get(Guid id);
        Task<IEnumerable<GeneroEntity>> GetAll();
        Task<GeneroEntity> Post(GeneroCreateDto aluno);
        Task<GeneroEntity> Put(GeneroEntity aluno);
        Task<bool> Delete(Guid id);
    }
}
