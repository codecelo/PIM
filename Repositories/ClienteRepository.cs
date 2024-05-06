using System.Collections.Generic;
using System.Linq;
using PIM_API.Models;

namespace PIM_API.Repositories
{
    public class ClienteRepository
    {
        private List<Cliente> clientes;
        private static int proximoID = 1;

        public ClienteRepository()
        {
            clientes = new List<Cliente>();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            cliente.ClienteID = proximoID++;
            clientes.Add(cliente);
        }

        public List<Cliente> ObterTodosClientes()
        {
            return clientes;
        }

        public void AtualizarCliente(Cliente clienteAtualizado)
        {
            Cliente clienteExistente = clientes.FirstOrDefault(c => c.ClienteID == clienteAtualizado.ClienteID);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = clienteAtualizado.Nome;
                clienteExistente.Contato = clienteAtualizado.Contato;
                clienteExistente.PreferenciasCompra = clienteAtualizado.PreferenciasCompra;
            }
        }

        public void ExcluirCliente(int clienteID)
        {
            Cliente clienteExistente = clientes.FirstOrDefault(c => c.ClienteID == clienteID);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
            }
        }
        public Cliente ObterClientePorId(int clienteId)
        {
            return clientes.FirstOrDefault(c => c.ClienteID == clienteId);
        }

    }
}

