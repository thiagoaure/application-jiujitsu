using AutoMapper;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Response;
using KbrTec.JiuJitsuSystem.Domain.Entities;

namespace KbrTec.JiuJitsuSystem.Application.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Campeonato, CampeonatoResponse>();
        CreateMap<Campeonato, CampeonatoResponse>().ReverseMap();
        CreateMap<Atleta, AtletaResponse>();
        CreateMap<Atleta, AtletaResponse>().ReverseMap();
        CreateMap<Usuario, UsuarioResponse>();
        CreateMap<Usuario, UsuarioResponse>().ReverseMap();
        CreateMap<Usuario, UsuarioRequest>();
        CreateMap<Usuario, UsuarioRequest>().ReverseMap();
        CreateMap<InscricaoCampeonato, InscricaoCampeonatoResponse>();
        CreateMap<InscricaoCampeonato, InscricaoCampeonatoResponse>().ReverseMap();
        CreateMap<InscricaoCampeonato, InscricaoCampeonatoRequest>();
        CreateMap<InscricaoCampeonato, InscricaoCampeonatoRequest>().ReverseMap();
    }
}
