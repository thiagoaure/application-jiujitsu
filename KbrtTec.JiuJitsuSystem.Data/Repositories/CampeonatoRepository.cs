using KbrTec.JiuJitsuSystem.Data.Context;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KbrTec.JiuJitsuSystem.Data.Repositories;

public class CampeonatoRepository : ICampeonatoRepository
{
    protected readonly AppDbContext _appDbContext;

    public CampeonatoRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Campeonato> DeleteCampeonatoAsync(Campeonato campeonato)
    {
        var result = _appDbContext.Campeonatos.Remove(campeonato);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<IEnumerable<Campeonato>> GetAllCampeonatosAsync()
    {
        return await _appDbContext.Campeonatos.ToListAsync();

    }

    public async Task<Campeonato?> GetCampeonatoAsync(Guid id)
    {
        return await _appDbContext.Campeonatos.FirstAsync(x => x.Id == id);
    }

    public async Task<Campeonato> InsertCampeonatoAsync(Campeonato campeonato)
    {
        var result = await _appDbContext.Campeonatos.AddAsync(campeonato);
        return result.Entity;
    }

    public async Task<Campeonato> UpdateCampeonatoAsync(Campeonato newCampeonato, Campeonato oldCampeonato)
    {
        _appDbContext.Campeonatos.Entry(oldCampeonato).State = EntityState.Detached;
        _appDbContext.Campeonatos.Entry(newCampeonato).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
        return newCampeonato;
    }
}
