using DrCash.Domain.Dtos.Autor;
using DrCash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrCash.Domain.Interfaces.Services.Autor
{
    public interface IAutorService
    {
        Task<AutorEntity> Get(Guid id);
        Task<IEnumerable<AutorEntity>> GetAll();
        Task<AutorEntity> Post(AutorCreateDto  autor);
        Task<AutorEntity> Put(AutorEntity autor);
        Task<bool> Delete(Guid id);
    }
}
