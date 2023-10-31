using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KbrTec.JiuJitsuSystem.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
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
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            var result = await _usuarioService.InsertUsuarioAsync(usuario);
            return Ok(result);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario([FromBody] Usuario usuario)
        {
            var result = await _usuarioService.UpdateUsuarioAsync(usuario);
            return Ok(result);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(Guid id)
        {
            var result = await _usuarioService.DeleteUsuarioAsync(id);
            return Ok(result);
        }
    }
}
