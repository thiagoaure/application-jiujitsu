using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

namespace KbrTec.JiuJitsuSystem.Service.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<Usuario> DeleteUsuarioAsync(Guid id)
    {
        var result = await _usuarioRepository.GetUsuarioAsync(id);
        if (result == null)
        {
            return null;
        }
        return await _usuarioRepository.DeleteUsuarioAsync(result);
    }

    public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
    {
        var result = await _usuarioRepository.GetAllUsuariosAsync();
        return result;
    }

    public async Task<Usuario?> GetUsuarioAsync(Guid id)
    {
        var result = await _usuarioRepository.GetUsuarioAsync(id);
        return result;
    }

    public async Task<Usuario> InsertUsuarioAsync(Usuario usuario)
    {
        var result = await _usuarioRepository.InsertUsuarioAsync(usuario);
        return result;
    }

    public async Task<Usuario> UpdateUsuarioAsync(Usuario usuario)
    {
        var oldUsuario = await _usuarioRepository.GetUsuarioAsync(usuario.Id);
        if (oldUsuario == null)
        {
            return null;
        }
        return await _usuarioRepository.UpdateUsuarioAsync(usuario, oldUsuario);
    }
}
