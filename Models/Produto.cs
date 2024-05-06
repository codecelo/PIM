namespace PIM_API.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string? NomeProduto { get; set; }
        public string? Descricao { get; set; }
        public string? Caracteristicas { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}

