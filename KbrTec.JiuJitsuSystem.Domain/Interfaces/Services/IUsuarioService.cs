using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

public interface IUsuarioService
{
    Task<Usuario> InsertUsuarioAsync(UsuarioRequest usuario);
    Task<Usuario> UpdateUsuarioAsync(UsuarioRequest usuario, Guid id);
    Task<Usuario> DeleteUsuarioAsync(Guid id);
    Task<Usuario?> GetUsuarioAsync(Guid id);
    Task<IEnumerable<Usuario>> GetAllUsuariosAsync();
}
