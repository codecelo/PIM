using System.Collections.Generic;
using System.Linq;
using PIM_API.Models;

namespace PIM_API.Repositories
{
    public class PedidoRepository
    {
        private List<Pedido> pedidos;
        private static int proximoID = 1;

        public PedidoRepository()
        {
            pedidos = new List<Pedido>();
        }

        public void AdicionarPedido(Pedido pedido)
        {
            pedido.PedidoID = proximoID++;
            pedidos.Add(pedido);
        }

        public List<Pedido> ObterTodosPedidos()
        {
            return pedidos;
        }

        public void AtualizarPedido(Pedido pedidoAtualizado)
        {
            Pedido pedidoExistente = pedidos.FirstOrDefault(p => p.PedidoID == pedidoAtualizado.PedidoID);
            if (pedidoExistente != null)
            {
                pedidoExistente.ClienteID = pedidoAtualizado.ClienteID;
                pedidoExistente.ProdutoID = pedidoAtualizado.ProdutoID;
                pedidoExistente.DataEntrega = pedidoAtualizado.DataEntrega;
                pedidoExistente.StatusPedido = pedidoAtualizado.StatusPedido;
                pedidoExistente.Observacoes = pedidoAtualizado.Observacoes;
            }
        }

        public void ExcluirPedido(int pedidoID)
        {
            Pedido pedidoExistente = pedidos.FirstOrDefault(p => p.PedidoID == pedidoID);
            if (pedidoExistente != null)
            {
                pedidos.Remove(pedidoExistente);
            }
        }

        public Pedido ObterPedidoPorId(int pedidoId)
        {
            return pedidos.FirstOrDefault(p => p.PedidoID == pedidoId);
        }

    }
}
