using System.Collections.Generic;
using System.Linq;
using PIM_API.Models;

namespace PIM_API.Repositories
{
    public class ProdutoRepository
    {
        private List<Produto> produtos;
        private static int proximoID = 1;

        public ProdutoRepository()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produto.ProdutoID = proximoID++;
            produtos.Add(produto);
        }

        public List<Produto> ObterTodosProdutos()
        {
            return produtos;
        }

        public void AtualizarProduto(Produto produtoAtualizado)
        {
            Produto produtoExistente = produtos.FirstOrDefault(p => p.ProdutoID == produtoAtualizado.ProdutoID);
            if (produtoExistente != null)
            {
                produtoExistente.NomeProduto = produtoAtualizado.NomeProduto;
                produtoExistente.Descricao = produtoAtualizado.Descricao;
                produtoExistente.Caracteristicas = produtoAtualizado.Caracteristicas;
                produtoExistente.PrecoVenda = produtoAtualizado.PrecoVenda;
            }
        }

        public void ExcluirProduto(int produtoID)
        {
            Produto produtoExistente = produtos.FirstOrDefault(p => p.ProdutoID == produtoID);
            if (produtoExistente != null)
            {
                produtos.Remove(produtoExistente);
            }
        }
        public Produto ObterProdutoPorId(int produtoId)
        {
            return produtos.FirstOrDefault(p => p.ProdutoID == produtoId);
        }

    }
}
