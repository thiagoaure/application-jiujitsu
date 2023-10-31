using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KbrTec.JiuJitsuSystem.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonatoController : ControllerBase
    {
        private readonly ICampeonatoService _campeonatoService;

        public CampeonatoController(ICampeonatoService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        // GET: api/<CampeonatoController>
        [HttpGet]
        public async Task<IActionResult> GetAllCampeonatos()
        {
            var result = await _campeonatoService.GetAllCampeonatosAsync();
            return Ok(result);
        }

        // GET api/<CampeonatoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCampeonato(Guid id)
        {
            var result = await _campeonatoService.GetCampeonatoAsync(id);
            return Ok(result);
        }

        // POST api/<CampeonatoController>
        [HttpPost]
        public async Task<IActionResult> PostCampeonato([FromBody] Campeonato campeonato)
        {
            var result = await _campeonatoService.InsertCampeonatoAsync(campeonato);
            return Ok(result);
        }

        // PUT api/<CampeonatoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampeonato([FromBody] Campeonato campeonato)
        {
            var result = await _campeonatoService.UpdateCampeonatoAsync(campeonato);
            return Ok(result);
        }

        // DELETE api/<CampeonatoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampeonato(Guid id)
        {
            var result = await _campeonatoService.DeleteCampeonatoAsync(id);
            return Ok(result);
        }
    }
}
