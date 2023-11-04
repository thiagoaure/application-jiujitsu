using AutoMapper;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

namespace KbrTec.JiuJitsuSystem.Service.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
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

    public async Task<Usuario> InsertUsuarioAsync(UsuarioRequest usuario)
    {
        usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha, workFactor: 10);
        var result = await _usuarioRepository.InsertUsuarioAsync(_mapper.Map<Usuario>(usuario));
        return result;
    }

    public async Task<Usuario> UpdateUsuarioAsync(UsuarioRequest usuario, Guid id)
    {
        var oldUsuario = await _usuarioRepository.GetUsuarioAsync(id);
        if (oldUsuario == null)
        {
            return null;
        }
        return await _usuarioRepository.UpdateUsuarioAsync(_mapper.Map<Usuario>(usuario), oldUsuario);
    }
}
