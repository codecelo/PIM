using Microsoft.AspNetCore.Mvc;
using PIM_API.Models;
using PIM_API.Services;
using System.Collections.Generic;

namespace PIM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var clientes = _clienteService.ObterTodosClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetById(int id)
        {
            var cliente = _clienteService.ObterClientePorId(id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> Post(Cliente cliente)
        {
            _clienteService.AdicionarCliente(cliente);
            return CreatedAtAction(nameof(GetById), new { id = cliente.ClienteID }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Cliente cliente)
        {
            var clienteExistente = _clienteService.ObterClientePorId(id);
            if (clienteExistente == null)
                return NotFound();

            cliente.ClienteID = id; // Garante que o ID enviado na requisição seja respeitado
            _clienteService.AtualizarCliente(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var clienteExistente = _clienteService.ObterClientePorId(id);
            if (clienteExistente == null)
                return NotFound();

            _clienteService.ExcluirCliente(id);
            return NoContent();
        }
    }
}
