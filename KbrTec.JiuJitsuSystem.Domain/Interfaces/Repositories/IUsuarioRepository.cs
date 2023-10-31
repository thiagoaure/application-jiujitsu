using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;

public interface IUsuarioRepository
{
    Task<Usuario> InsertUsuarioAsync(Usuario usuario);
    Task<Usuario> UpdateUsuarioAsync(Usuario newUsuario, Usuario oldUsuario);
    Task<Usuario> DeleteUsuarioAsync(Usuario usuario);
    Task<Usuario?> GetUsuarioAsync(Guid id);
    Task<IEnumerable<Usuario>> GetAllUsuariosAsync();
}
