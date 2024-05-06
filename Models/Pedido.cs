using System;

namespace PIM_API.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }
        public DateTime DataEntrega { get; set; }
        public string StatusPedido { get; set; }
        public string? Observacoes { get; set; }

        // Construtor
        public Pedido()
        {
            // Inicializando a propriedade StatusPedido com um valor padrão
            StatusPedido = "Pendente"; // Ou qualquer outro valor padrão que fizer sentido para sua aplicação
        }
    }
}
