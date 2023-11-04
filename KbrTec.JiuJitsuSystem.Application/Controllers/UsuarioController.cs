using AutoMapper;
using KbrTec.JiuJitsuSystem.Application.Security;
using KbrTec.JiuJitsuSystem.Domain;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Helpers;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KbrTec.JiuJitsuSystem.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;
    private readonly UserManager<Usuario> _userManager;
    private readonly RoleManager<IdentityRole<Guid>> _roleManager;
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;

    public UsuarioController(IUsuarioService usuarioService,
        UserManager<Usuario> userManager,
        RoleManager<IdentityRole<Guid>> roleManager,
        IAuthService authService,
        IMapper mapper)
    {
        _usuarioService = usuarioService;
         _userManager = userManager;
        _roleManager = roleManager;
        _authService = authService;
        _mapper = mapper;
    }

    // GET: api/<UsuarioController>
    [HttpGet]
    public async Task<IActionResult> GetAllUsuarios()
    {
        var result = await _usuarioService.GetAllUsuariosAsync();
        return Ok(result);

    }

    // GET api/<UsuarioController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _usuarioService.GetUsuarioAsync(id);
        return Ok(result);
    }

    // POST api/<UsuarioController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] UsuarioRequest usuario)
    {
        var result = await _usuarioService.InsertUsuarioAsync(usuario);
        //var user = new Usuario
        //{
        //    Id = result.Id,
        //    Email = usuario.Email,
        //    Nome = usuario.Nome,
        //    Senha = usuario.Senha,
        //    TipoUsuario = usuario.TipoUsuario
        //};

        //var resultado = await _userManager.CreateAsync(user, usuario.Senha);
        //await AddToRoleAsync(user, TipoUsuarioHelper.GetRole(usuario.TipoUsuario));

        return Ok(result);
    }

    // PUT api/<UsuarioController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUsuario([FromBody] UsuarioRequest usuario, Guid id)
    {
        var result = await _usuarioService.UpdateUsuarioAsync(usuario, id);
        return Ok(result);
    }

    // DELETE api/<UsuarioController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUsuario(Guid id)
    {
        var result = await _usuarioService.DeleteUsuarioAsync(id);
        return Ok(result);
    }

    [AllowAnonymous]
    [HttpPost("logar")]
    public async Task<ActionResult> Autenticar([FromBody] UsuarioLogin usuarioLogin)
    {
        var resposta = await _authService.Autenticar(usuarioLogin);

        if (resposta is null)
            return Unauthorized("Usuário e/ou Senha inválidos!");

        return Ok(resposta);
    }
    private async Task AddToRoleAsync(Usuario user, string role)
    {
        if (!await _roleManager.RoleExistsAsync(role))
            await _roleManager.CreateAsync(new(role));

        var res = await _userManager.AddToRoleAsync(user, role);
    }
}
