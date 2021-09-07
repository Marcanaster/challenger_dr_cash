using DrCash.Domain.Interfaces.Services.Autor;
using DrCash.Domain.Interfaces.Services.Genero;
using DrCash.Domain.Interfaces.Services.Livro;
using DrCash.Domain.Interfaces.Services.User;
using DrCash.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DrCash.Service.DependecyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAutorService, AutorService>();
            serviceCollection.AddTransient<ILivroService, LivroService>();
            serviceCollection.AddTransient<IGeneroService, GeneroService>();
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
