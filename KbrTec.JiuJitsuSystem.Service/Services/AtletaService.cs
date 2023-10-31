using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

namespace KbrTec.JiuJitsuSystem.Service.Services;

public class AtletaService : IAtletaService
{
    private readonly IAtletaRepository _atletaRepository;

    public AtletaService(IAtletaRepository atletaRepository)
    {
        _atletaRepository = atletaRepository;
    }

    public async Task<Atleta> DeleteAtletasync(Guid id)
    {
        var result = await _atletaRepository.GetAtletaAsync(id);
        if (result == null)
        {
            return null;
        }
        return await _atletaRepository.DeleteAtletasync(result);
    }

    public async Task<IEnumerable<Atleta>> GetAllAtletasAsync()
    {
        return await _atletaRepository.GetAllAtletasAsync();
    }

    public async Task<Atleta?> GetAtletaAsync(Guid id)
    {
        var result = await _atletaRepository.GetAtletaAsync(id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public async Task<Atleta> InsertAtletaAsync(Atleta atleta)
    {
        return await _atletaRepository.InsertAtletaAsync(atleta);
    }

    public async Task<Atleta> UpdateAtletaAsync(Atleta atleta)
    {
        var oldAtleta = await _atletaRepository.GetAtletaAsync(atleta.Id);
        if (oldAtleta == null)
        {
            return null;
        }
        return await _atletaRepository.UpdateAtletaAsync(atleta, oldAtleta);
    }
}
