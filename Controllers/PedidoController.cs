using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Services;

namespace PIM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoService _pedidoService;

        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pedido>> Get()
        {
            var pedidos = _pedidoService.ObterTodosPedidos();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public ActionResult<Pedido> GetById(int id)
        {
            var pedido = _pedidoService.ObterPedidoPorId(id);
            if (pedido == null)
                return NotFound();
            return Ok(pedido);
        }

        [HttpPost]
        public ActionResult<Pedido> Post(Pedido pedido)
        {
            _pedidoService.AdicionarPedido(pedido);
            return CreatedAtAction(nameof(GetById), new { id = pedido.PedidoID }, pedido);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Pedido pedido)
        {
            if (id != pedido.PedidoID)
                return BadRequest();

            var pedidoExistente = _pedidoService.ObterPedidoPorId(id);
            if (pedidoExistente == null)
                return NotFound();

            _pedidoService.AtualizarPedido(pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pedidoExistente = _pedidoService.ObterPedidoPorId(id);
            if (pedidoExistente == null)
                return NotFound();

            _pedidoService.ExcluirPedido(id);
            return NoContent();
        }
    }
}
