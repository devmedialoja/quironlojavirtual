namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}
