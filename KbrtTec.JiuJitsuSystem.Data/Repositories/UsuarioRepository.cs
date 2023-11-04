using KbrTec.JiuJitsuSystem.Data.Context;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KbrTec.JiuJitsuSystem.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    protected readonly AppDbContext _appDbContext;

    public UsuarioRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Usuario> DeleteUsuarioAsync(Usuario usuario)
    {
        var result = _appDbContext.Usuarios.Remove(usuario);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
    {
        return await _appDbContext.Usuarios.ToListAsync();
    }

    public async Task<Usuario?> GetUsuarioAsync(Guid id)
    {
        return await _appDbContext.Usuarios.FirstAsync(x => x.Id == id);
    }

    public async Task<Usuario> InsertUsuarioAsync(Usuario usuario)
    {
        var result =  _appDbContext.Usuarios.Add(usuario);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Usuario> UpdateUsuarioAsync(Usuario newUsuario, Usuario oldUsuario)
    {
        newUsuario.Id = oldUsuario.Id;
        _appDbContext.Usuarios.Entry(oldUsuario).State = EntityState.Detached;
        _appDbContext.Usuarios.Entry(newUsuario).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
        return newUsuario;
    }
}
