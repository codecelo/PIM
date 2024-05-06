using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Services;

namespace PIM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _produtoService.ObterTodosProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> GetById(int id)
        {
            var produto = _produtoService.ObterProdutoPorId(id);
            if (produto == null)
                return NotFound();
            return Ok(produto);
        }

        [HttpPost]
        public ActionResult<Produto> Post(Produto produto)
        {
            _produtoService.AdicionarProduto(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.ProdutoID }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoID)
                return BadRequest();

            var produtoExistente = _produtoService.ObterProdutoPorId(id);
            if (produtoExistente == null)
                return NotFound();

            _produtoService.AtualizarProduto(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produtoExistente = _produtoService.ObterProdutoPorId(id);
            if (produtoExistente == null)
                return NotFound();

            _produtoService.ExcluirProduto(id);
            return NoContent();
        }
    }
}
