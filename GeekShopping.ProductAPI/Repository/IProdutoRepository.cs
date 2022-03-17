using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoVO>> Listarprodutos();
        Task<ProdutoVO> BuscarPorId(long idProduto);
        Task<ProdutoVO> Criar(ProdutoVO produtoVO);
        Task<ProdutoVO> Atualizar(ProdutoVO produtoVO);
        Task<bool> Deletar(long idProduto);
    }
}
