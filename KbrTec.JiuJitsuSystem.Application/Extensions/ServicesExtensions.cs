using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using KbrTec.JiuJitsuSystem.Service.Services;

namespace KbrTec.JiuJitsuSystem.Application.Extensions;

public static class ServicesExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<ICampeonatoService, CampeonatoService>();
        services.AddTransient<IAtletaService, AtletaService>();
        services.AddTransient<IUsuarioService, UsuarioService>();
        services.AddTransient<IInscricaoCampeonatoService, InscricaoCampeonatoService>();

    }
}
