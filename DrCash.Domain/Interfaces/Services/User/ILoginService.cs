using DrCash.Domain.Dtos;
using System.Threading.Tasks;

namespace DrCash.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto login);
    }
}
