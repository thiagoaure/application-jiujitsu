using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;

public interface IAtletaRepository
{
    Task<Atleta> InsertAtletaAsync(Atleta atleta);
    Task<Atleta> UpdateAtletaAsync(Atleta newAtleta, Atleta oldAleta);
    Task<Atleta> DeleteAtletasync(Atleta atleta);
    Task<Atleta?> GetAtletaAsync(Guid id);
    Task<IEnumerable<Atleta>> GetAllAtletasAsync();
}
