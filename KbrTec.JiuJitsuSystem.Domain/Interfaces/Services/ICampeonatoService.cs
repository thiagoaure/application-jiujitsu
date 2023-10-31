using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

public interface ICampeonatoService
{
    Task<Campeonato> InsertCampeonatoAsync(Campeonato campeonato);
    Task<Campeonato> UpdateCampeonatoAsync(Campeonato campeonato);
    Task<Campeonato> DeleteCampeonatoAsync(Guid id);
    Task<Campeonato?> GetCampeonatoAsync(Guid id);
    Task<IEnumerable<Campeonato>> GetAllCampeonatosAsync();
}
