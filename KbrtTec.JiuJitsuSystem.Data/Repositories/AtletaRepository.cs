using KbrTec.JiuJitsuSystem.Data.Context;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KbrTec.JiuJitsuSystem.Data.Repositories;

public class AtletaRepository : IAtletaRepository
{
    protected readonly AppDbContext _appDbContext;

    public AtletaRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Atleta> DeleteAtletasync(Atleta atleta)
    {
        var result = _appDbContext.Atletas.Remove(atleta);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<IEnumerable<Atleta>> GetAllAtletasAsync()
    {
        return await _appDbContext.Atletas.ToListAsync();
    }

    public async Task<Atleta?> GetAtletaAsync(Guid id)
    {
        return await _appDbContext.Atletas.FirstAsync(x => x.Id == id);
    }

    public async Task<Atleta> InsertAtletaAsync(Atleta atleta)
    {
        var result = await  _appDbContext.Atletas.AddAsync(atleta);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Atleta> UpdateAtletaAsync(Atleta newAtleta, Atleta oldAleta)
    {
        _appDbContext.Atletas.Entry(oldAleta).State = EntityState.Detached;
        _appDbContext.Atletas.Entry(newAtleta).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
        return newAtleta;
    }
}
