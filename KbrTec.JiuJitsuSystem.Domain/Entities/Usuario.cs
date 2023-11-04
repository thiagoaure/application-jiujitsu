using KbrTec.JiuJitsuSystem.Domain.Helpers;
using Microsoft.AspNetCore.Identity;

namespace KbrTec.JiuJitsuSystem.Domain.Entities;

public class Usuario
{
    public  Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public  string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public ETipoUsuario TipoUsuario { get; set; }
}
