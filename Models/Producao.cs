using System;

namespace PIM_API.Models
{
    public class Producao
    {
        public int ProducaoID { get; set; }
        public DateTime DataProducao { get; set; }
        public decimal QuantidadeProduzida { get; set; }
        public string? MetodoProducao { get; set; }
        public int InsumoID { get; set; }
        public string? Observacoes { get; set; }
    }
}
