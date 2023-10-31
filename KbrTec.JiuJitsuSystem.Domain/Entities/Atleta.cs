using KbrTec.JiuJitsuSystem.Domain.Enums;

namespace KbrTec.JiuJitsuSystem.Domain.Entities;

public class Atleta
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public ESexo Sexo { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string Equipe { get; set; } = string.Empty;
    public ETipoFaixa TipoFaixa { get; set; }
    public ETipoPeso TipoPeso { get; set; }
    public DateTime DataIncricao { get; set; }

}
