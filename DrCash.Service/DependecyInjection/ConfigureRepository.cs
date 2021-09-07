using DrCash.Data.Context;
using DrCash.Data.Implamentation;
using DrCash.Data.Repository;
using DrCash.Domain.Interfaces.Repositories;
using DrCash.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DrCash.Service.DependecyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            var optionsBuilder = new DbContextOptionsBuilder<DrCashContext>();
            serviceCollection.AddDbContext<DrCashContext>(
                options => options.UseSqlServer("Server= MARCANASTER\\SQLEXPRESS; Initial Catalog = DrCash; Persist Security Info = True; User ID = marcanaster; Password = f0d@s481521; MultipleActiveResultSets = True")
            );
        }
    }
}
