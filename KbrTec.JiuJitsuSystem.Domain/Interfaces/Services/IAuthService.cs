using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

public interface IAuthService
{
    Task<UsuarioLogin?> Autenticar(UsuarioLogin usuario);
}
