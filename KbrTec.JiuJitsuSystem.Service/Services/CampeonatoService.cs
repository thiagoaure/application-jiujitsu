using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

namespace KbrTec.JiuJitsuSystem.Service.Services;

public class CampeonatoService : ICampeonatoService
{
    private readonly ICampeonatoRepository _campeonatoRepository;

    public CampeonatoService(ICampeonatoRepository campeonatoRepository)
    {
        _campeonatoRepository = campeonatoRepository;
    }

    public async Task<Campeonato> DeleteCampeonatoAsync(Guid id)
    {
        var result = await _campeonatoRepository.GetCampeonatoAsync(id);
        if (result == null)
        {
            return null;
        }
        return await _campeonatoRepository.DeleteCampeonatoAsync(result);
    }

    public async Task<IEnumerable<Campeonato>> GetAllCampeonatosAsync()
    {
        var result = await  _campeonatoRepository.GetAllCampeonatosAsync();
        return result;
    }

    public async Task<Campeonato?> GetCampeonatoAsync(Guid id)
    {
        var result = await _campeonatoRepository.GetCampeonatoAsync(id);
        return result;
    }

    public async Task<Campeonato> InsertCampeonatoAsync(Campeonato campeonato)
    {
        return await _campeonatoRepository.InsertCampeonatoAsync(campeonato);
    }

    public async Task<Campeonato> UpdateCampeonatoAsync(Campeonato campeonato)
    {
        var oldCampeonato = await _campeonatoRepository.GetCampeonatoAsync(campeonato.Id);
        if (oldCampeonato == null)
        {
            return null;
        }
        return await _campeonatoRepository.UpdateCampeonatoAsync(campeonato, oldCampeonato);
    }
}
