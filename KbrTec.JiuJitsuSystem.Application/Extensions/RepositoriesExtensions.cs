using KbrTec.JiuJitsuSystem.Data.Repositories;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;

namespace KbrTec.JiuJitsuSystem.Application.Extensions;

public static class RepositoriesExtensions
{
    public static void AddCustomRepositories(this IServiceCollection services)
    {
        services.AddTransient<ICampeonatoRepository, CampeonatoRepository>();
        services.AddTransient<IAtletaRepository, AtletaRepository>();
        services.AddTransient<IUsuarioRepository, UsuarioRepository>();
    }
}
