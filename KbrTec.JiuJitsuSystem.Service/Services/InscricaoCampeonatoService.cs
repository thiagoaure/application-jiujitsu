using AutoMapper;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Response;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Repositories;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;

namespace KbrTec.JiuJitsuSystem.Service.Services;

public class InscricaoCampeonatoService : IInscricaoCampeonatoService
{
    private readonly IInscricaoCampeonatoRepository _inscricaoCampeonatoRepository;
    private readonly IMapper _mapper;

    public InscricaoCampeonatoService(
        IInscricaoCampeonatoRepository inscricaoCampeonatoRepository,
        IMapper mapper)
    {
        _inscricaoCampeonatoRepository = inscricaoCampeonatoRepository;
        _mapper = mapper;
    }

    public async Task<InscricaoCampeonatoResponse> DeleteInscricaoCampeonatoAsync(Guid id)
    {
        var result = await _inscricaoCampeonatoRepository.GetInscricaoCampeonatoAsync(id);
        if (result == null)
        {
            return null;
        }
        var inscricaoDeletada = await _inscricaoCampeonatoRepository.DeleteInscricaoCampeonatoAsync(_mapper.Map<InscricaoCampeonato>(result));
       
        return _mapper.Map<InscricaoCampeonatoResponse>(inscricaoDeletada);
    }

    public async Task<IEnumerable<InscricaoCampeonatoResponse>> GetAllInscricaoCampeonatoAsync()
    {
        var result = await _inscricaoCampeonatoRepository.GetAllInscricaoCampeonatoAsync();
        if (result == null)
        {
            return null;
        }
        var lista = _mapper.Map<IEnumerable<InscricaoCampeonatoResponse>>(result);
        return lista;
    }

    public async Task<InscricaoCampeonatoResponse?> GetInscricaoCampeonatoAsync(Guid id)
    {
        var result = await _inscricaoCampeonatoRepository.GetInscricaoCampeonatoAsync(id);
        if (result == null)
        {
            return null;
        }
        var inscricao = _mapper.Map<InscricaoCampeonatoResponse>(result);
        return inscricao; 
    }

    public async Task<InscricaoCampeonatoResponse> InsertIsncricaoCampeonatoAsync(InscricaoCampeonatoRequest inscricaoCampeonato)
    {
        var result = await _inscricaoCampeonatoRepository.InsertIsncricaoCampeonatoAsync(_mapper.Map<InscricaoCampeonato>(inscricaoCampeonato));
        return _mapper.Map<InscricaoCampeonatoResponse>(result);
    }

    public async Task<InscricaoCampeonatoResponse> UpdateInscricaoCampeonatoAsync(Guid id, InscricaoCampeonatoRequest inscricaoCampeonato)
    {
        var oldInscricao = await _inscricaoCampeonatoRepository.GetInscricaoCampeonatoAsync(id);
        if (oldInscricao == null)
        {
            return null;
        }
        var result = await _inscricaoCampeonatoRepository.UpdateInscricaoCampeonatoAsync(_mapper.Map<InscricaoCampeonato>(inscricaoCampeonato), oldInscricao);
        return _mapper.Map<InscricaoCampeonatoResponse>(result);
    }
}
