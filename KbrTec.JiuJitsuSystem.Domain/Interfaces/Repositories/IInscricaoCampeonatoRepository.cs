using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;

public interface IInscricaoCampeonatoRepository
{
    Task<InscricaoCampeonato> InsertIsncricaoCampeonatoAsync(InscricaoCampeonato inscricaoCampeonato);
    Task<InscricaoCampeonato> UpdateInscricaoCampeonatoAsync(InscricaoCampeonato newCampeonato, InscricaoCampeonato oldCampeonato);
    Task<InscricaoCampeonato> DeleteInscricaoCampeonatoAsync(InscricaoCampeonato inscricaoCampeonato);
    Task<InscricaoCampeonato?> GetInscricaoCampeonatoAsync(Guid id);
    Task<IEnumerable<InscricaoCampeonato>> GetAllInscricaoCampeonatoAsync();
}
