namespace KbrTec.JiuJitsuSystem.Domain.Entities;

public class InscricaoCampeonato
{
    public Guid Id { get; set; }
    public Atleta Atleta { get; set; }
    public Guid AtletaId { get; set; }
    public Campeonato Campeonato { get; set; }
    public Guid CampeonatoId { get; set; }
}
