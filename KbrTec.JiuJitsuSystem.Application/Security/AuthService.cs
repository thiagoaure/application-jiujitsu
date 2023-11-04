using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KbrTec.JiuJitsuSystem.Application.Security;

public class AuthService : IAuthService
{
    private readonly IUsuarioService _usuarioService;

    public AuthService(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    public async Task<UsuarioLogin?> Autenticar(UsuarioLogin usuario)
    {
        if (usuario == null || string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Senha))
            return null;

        var BuscaUsuario = await _usuarioService.GetUsuarioAsync(usuario.Id);

        if (BuscaUsuario == null)
            return null;

        if (!BCrypt.Net.BCrypt.Verify(usuario.Senha, BuscaUsuario.Senha))
            return null;

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(Settings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                    new Claim(ClaimTypes.Name, usuario.Email)
            }),

            Expires = DateTime.UtcNow.AddHours(8),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey)
            , SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        usuario.Id = BuscaUsuario.Id;
        usuario.Token = "Bearer " + tokenHandler.WriteToken(token).ToString();
        usuario.Senha = "";

        return usuario;

    }
}
