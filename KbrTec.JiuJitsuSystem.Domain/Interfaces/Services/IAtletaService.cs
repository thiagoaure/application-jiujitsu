using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

public interface IAtletaService
{
    Task<Atleta> InsertAtletaAsync(Atleta atleta);
    Task<Atleta> UpdateAtletaAsync(Atleta atleta);
    Task<Atleta> DeleteAtletasync(Guid id);
    Task<Atleta?> GetAtletaAsync(Guid id);
    Task<IEnumerable<Atleta>> GetAllAtletasAsync();
}

