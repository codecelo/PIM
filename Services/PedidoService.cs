using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Repositories;

namespace PIM_API.Services
{
    public class PedidoService
    {
        private readonly PedidoRepository _pedidoRepository;

        public PedidoService(PedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public void AdicionarPedido(Pedido pedido)
        {
            _pedidoRepository.AdicionarPedido(pedido);
        }

        public List<Pedido> ObterTodosPedidos()
        {
            return _pedidoRepository.ObterTodosPedidos();
        }

        public Pedido ObterPedidoPorId(int pedidoID)
        {
            return _pedidoRepository.ObterPedidoPorId(pedidoID);
        }

        public void AtualizarPedido(Pedido pedidoAtualizado)
        {
            _pedidoRepository.AtualizarPedido(pedidoAtualizado);
        }

        public void ExcluirPedido(int pedidoID)
        {
            _pedidoRepository.ExcluirPedido(pedidoID);
        }
    }
}
