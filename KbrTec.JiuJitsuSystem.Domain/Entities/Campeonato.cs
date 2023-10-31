namespace KbrTec.JiuJitsuSystem.Domain.Entities;

public class Campeonato
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Imagem { get; set; } = string.Empty;
    public Endereco Endereco { get; set; }
    public DateTime DataRealizacao { get; set; }
    public string Ginasio { get; set; } = string.Empty;
    public string InformacoesGerais { get; set; } = string.Empty;
    public bool? EntradaPublico { get; set; }
    public ETipoCampeonato TipoCamepeonato { get; set; }
    public EFaseCampeonato FaseCampeonato { get; set; }
    public EStatusCampeonato StatusCampeonato { get; set; }
}
