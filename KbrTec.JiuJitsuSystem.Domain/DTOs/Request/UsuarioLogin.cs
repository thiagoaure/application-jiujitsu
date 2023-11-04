using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbrTec.JiuJitsuSystem.Domain.DTOs.Request;

public class UsuarioLogin
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public Guid Id { get; set; }
}
