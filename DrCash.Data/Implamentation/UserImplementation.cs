using DrCash.Data.Context;
using DrCash.Data.Repository;
using DrCash.Domain.Entities;
using DrCash.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DrCash.Data.Implamentation
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataSet;
        public UserImplementation(DrCashContext context) : base(context)
        {
            _dataSet = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string login, string password)
        {
            return await _dataSet.FirstOrDefaultAsync(u => u.Login.Equals(login) && u.Senha.Equals(password));
        }
    }
}
