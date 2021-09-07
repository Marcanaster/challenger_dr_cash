using DrCash.Domain.Entities;
using DrCash.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace DrCash.Domain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string login, string password);
    }
}
