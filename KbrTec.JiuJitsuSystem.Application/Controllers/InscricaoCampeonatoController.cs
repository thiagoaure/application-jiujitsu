using KbrTec.JiuJitsuSystem.Domain.DTOs.Request;
using KbrTec.JiuJitsuSystem.Domain.DTOs.Response;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KbrTec.JiuJitsuSystem.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscricaoCampeonatoController : ControllerBase
    {
        private readonly IInscricaoCampeonatoService _inscricaoCampeonatoService;

        public InscricaoCampeonatoController(IInscricaoCampeonatoService inscricaoCampeonatoService)
        {
            _inscricaoCampeonatoService = inscricaoCampeonatoService;
        }

        // GET: api/<InscricaoCampeonato>
        [HttpGet]
        public async Task<IActionResult> GetAllInscricaoCampeonato()
        {
            var result = await _inscricaoCampeonatoService.GetAllInscricaoCampeonatoAsync();
            return Ok(result);
        }

        // GET api/<InscricaoCampeonato>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInscricaoCampeonato(Guid id)
        {
            var result = await _inscricaoCampeonatoService.GetInscricaoCampeonatoAsync(id);
            return Ok(result);
        }

        // POST api/<InscricaoCampeonato>
        [HttpPost]
        public async Task<IActionResult> PostInscricaoCampeonato([FromBody] InscricaoCampeonatoRequest inscricao)
        {
            var result = await _inscricaoCampeonatoService.InsertIsncricaoCampeonatoAsync(inscricao);
            return Ok(result);
        }

        // PUT api/<InscricaoCampeonato>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInscricaoCampeonato([FromBody] InscricaoCampeonatoRequest inscricao, Guid id)
        {
            var result = await _inscricaoCampeonatoService.UpdateInscricaoCampeonatoAsync(id, inscricao);
            return Ok(result);
        }

        // DELETE api/<InscricaoCampeonato>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInscricaoCampeonato(Guid id)
        {
            var result = await _inscricaoCampeonatoService.DeleteInscricaoCampeonatoAsync(id);
            return Ok(result);
        }
    }
}
