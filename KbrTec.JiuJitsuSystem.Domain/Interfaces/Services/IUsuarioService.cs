using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

public interface IUsuarioService
{
    Task<Usuario> InsertUsuarioAsync(Usuario usuario);
    Task<Usuario> UpdateUsuarioAsync(Usuario usuario);
    Task<Usuario> DeleteUsuarioAsync(Guid id);
    Task<Usuario?> GetUsuarioAsync(Guid id);
    Task<IEnumerable<Usuario>> GetAllUsuariosAsync();
}
