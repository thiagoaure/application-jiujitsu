using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories; 
public interface ICampeonatoRepository 
{
    Task<Campeonato> InsertCampeonatoAsync(Campeonato campeonato);
    Task<Campeonato> UpdateCampeonatoAsync(Campeonato newCampeonato, Campeonato oldCampeonato);
    Task<Campeonato> DeleteCampeonatoAsync(Campeonato campeonato);
    Task<Campeonato?> GetCampeonatoAsync(Guid id);
    Task<IEnumerable<Campeonato>> GetAllCampeonatosAsync();
}
