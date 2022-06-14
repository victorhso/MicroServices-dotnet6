using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoModel>> ListarProdutos();

        Task<ProdutoModel> buscarPorID(long id);

        Task<ProdutoModel> CadastrarProduto(ProdutoModel model);

        Task<ProdutoModel> AtualizarProduto(ProdutoModel model);

        Task<bool> DeletarProdutoPorID(long id);
    }
}
