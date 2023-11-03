using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Response;
using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

public interface IInscricaoCampeonatoService
{
    Task<InscricaoCampeonatoResponse> InsertIsncricaoCampeonatoAsync(InscricaoCampeonatoRequest inscricaoCampeonato);
    Task<InscricaoCampeonatoResponse> UpdateInscricaoCampeonatoAsync(Guid id, InscricaoCampeonatoRequest inscricaoCampeonato);
    Task<InscricaoCampeonatoResponse> DeleteInscricaoCampeonatoAsync(Guid id);
    Task<InscricaoCampeonatoResponse?> GetInscricaoCampeonatoAsync(Guid id);
    Task<IEnumerable<InscricaoCampeonatoResponse>> GetAllInscricaoCampeonatoAsync();
}
