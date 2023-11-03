using KbrTec.JiuJitsuSystem.Data.Context;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KbrTec.JiuJitsuSystem.Data.Repositories;

public class InscricaoCampeonatoReposiotory : IInscricaoCampeonatoRepository
{
    private readonly AppDbContext _appDbContext;

    public InscricaoCampeonatoReposiotory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<InscricaoCampeonato> DeleteInscricaoCampeonatoAsync(InscricaoCampeonato inscricaoCampeonato)
    {
        var result = _appDbContext.InscricoesCampeonatos.Remove(inscricaoCampeonato);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<IEnumerable<InscricaoCampeonato>> GetAllInscricaoCampeonatoAsync()
    {
        return await _appDbContext.InscricoesCampeonatos.ToListAsync();
    }

    public async Task<InscricaoCampeonato?> GetInscricaoCampeonatoAsync(Guid id)
    {
        var result = await _appDbContext.InscricoesCampeonatos.FirstAsync(x => x.Id == id);
        return result;
    }

    public async Task<InscricaoCampeonato> InsertIsncricaoCampeonatoAsync(InscricaoCampeonato inscricaoCampeonato)
    {
        var result = _appDbContext.InscricoesCampeonatos.Add(inscricaoCampeonato);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<InscricaoCampeonato> UpdateInscricaoCampeonatoAsync(InscricaoCampeonato newCampeonato, InscricaoCampeonato oldCampeonato)
    {
        newCampeonato.Id = oldCampeonato.Id;
        _appDbContext.InscricoesCampeonatos.Entry(oldCampeonato).State = EntityState.Detached;
        _appDbContext.InscricoesCampeonatos.Entry(newCampeonato).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
        return newCampeonato;
    }
}
