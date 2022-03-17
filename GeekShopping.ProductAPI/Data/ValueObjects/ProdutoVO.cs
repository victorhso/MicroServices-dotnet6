namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProdutoVO
    {
        public long ID { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

        public string ImagemURL { get; set; }
    }
}
