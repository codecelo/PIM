namespace PIM_API.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string? Nome { get; set; }
        public string? Contato { get; set; }
        public string? PreferenciasCompra { get; set; }
        public string? HistoricoPedidos { get; set; }
        public string? Feedbacks { get; set; }
    }
}
