using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Services;

namespace PIM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducaoController : ControllerBase
    {
        private readonly ProducaoService _producaoService;

        public ProducaoController(ProducaoService producaoService)
        {
            _producaoService = producaoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producao>> Get()
        {
            var producoes = _producaoService.ObterTodasProducoes();
            return Ok(producoes);
        }

        [HttpGet("{id}")]
        public ActionResult<Producao> GetById(int id)
        {
            var producao = _producaoService.ObterProducaoPorId(id);
            if (producao == null)
                return NotFound();
            return Ok(producao);
        }

        [HttpPost]
        public ActionResult<Producao> Post(Producao producao)
        {
            _producaoService.AdicionarProducao(producao);
            return CreatedAtAction(nameof(GetById), new { id = producao.ProducaoID }, producao);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Producao producao)
        {
            if (id != producao.ProducaoID)
                return BadRequest();

            var producaoExistente = _producaoService.ObterProducaoPorId(id);
            if (producaoExistente == null)
                return NotFound();

            _producaoService.AtualizarProducao(producao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producaoExistente = _producaoService.ObterProducaoPorId(id);
            if (producaoExistente == null)
                return NotFound();

            _producaoService.ExcluirProducao(id);
            return NoContent();
        }
    }
}
