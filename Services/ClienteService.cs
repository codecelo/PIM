using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Repositories;

namespace PIM_API.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }

        public List<Cliente> ObterTodosClientes()
        {
            return _clienteRepository.ObterTodosClientes();
        }

        public Cliente ObterClientePorId(int clienteID)
        {
            return _clienteRepository.ObterClientePorId(clienteID);
        }

        public void AtualizarCliente(Cliente clienteAtualizado)
        {
            _clienteRepository.AtualizarCliente(clienteAtualizado);
        }

        public void ExcluirCliente(int clienteID)
        {
            _clienteRepository.ExcluirCliente(clienteID);
        }
    }
}
