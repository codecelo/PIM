using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Repositories;

namespace PIM_API.Services
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoService(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtoRepository.AdicionarProduto(produto);
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _produtoRepository.ObterTodosProdutos();
        }

        public Produto ObterProdutoPorId(int produtoID)
        {
            return _produtoRepository.ObterProdutoPorId(produtoID);
        }

        public void AtualizarProduto(Produto produtoAtualizado)
        {
            _produtoRepository.AtualizarProduto(produtoAtualizado);
        }

        public void ExcluirProduto(int produtoID)
        {
            _produtoRepository.ExcluirProduto(produtoID);
        }
    }
}
