using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Interfaces.Orcamento;
using Domain.Interfaces.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjector
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IUsuarioRepository<UsuarioEntity>),
                typeof(UsuarioRepository<UsuarioEntity>));
            
            serviceCollection.AddScoped(typeof(IOrcamentoRepository<OrcamentoEntity>),
                typeof(OrcamentoRepository<OrcamentoEntity>));

            serviceCollection.AddDbContext<DatabaseContext>(
                
                options => options.UseSqlServer(
                    "Server=tcp:studiowebdigital.database.windows.net,1433;Database=StudioWeb;User ID=StudioWeb;Password=Sup0rt3@;Trusted_Connection=False;Encrypt=True;"),
            ServiceLifetime.Transient
            );
        }
    }
}