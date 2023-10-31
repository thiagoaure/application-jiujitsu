using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KbrTec.JiuJitsuSystem.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        private readonly IAtletaService _atletaService;

        public AtletaController(IAtletaService atletaService)
        {
            _atletaService = atletaService;
        }

        // GET: api/<AtletaController>
        [HttpGet]
        public async Task<IActionResult> GetAllAtletas()
        {
            var result = await _atletaService.GetAllAtletasAsync();
            return Ok(result);
        }

        // GET api/<AtletaController>/5
        [HttpGet("{id}")]
        public  async Task<IActionResult> GetAtleta(Guid id)
        {
            var result = await _atletaService.GetAtletaAsync(id);
            return Ok(result);
        }

        // POST api/<AtletaController>
        [HttpPost]
        public async Task<IActionResult> PostAtleta([FromBody] Atleta atleta)
        {
            var result = await _atletaService.InsertAtletaAsync(atleta);
            return Ok(result);
        }

        // PUT api/<AtletaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtleta([FromBody] Atleta atleta)
        {
            var result = await  _atletaService.UpdateAtletaAsync(atleta);
            return Ok(result);
        }

        // DELETE api/<AtletaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtleta(Guid id)
        {
            var result = await _atletaService.DeleteAtletasync(id);
            return Ok(result);
        }
    }
}
