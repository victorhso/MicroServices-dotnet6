using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProdutoServico : IProdutoService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/produto";

        public ProdutoServico(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<ProdutoModel> AtualizarProduto(ProdutoModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProdutoModel>();
            }
            else
            {
                throw new Exception("Algo de errado aconteceu ao chamar a API");
            }
        }

        public async Task<ProdutoModel> buscarPorID(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProdutoModel>();
        }

        public async Task<ProdutoModel> CadastrarProduto(ProdutoModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProdutoModel>();
            }
            else
            {
                throw new Exception("Algo de errado aconteceu ao chamar a API");
            }
        }

        public async Task<bool> DeletarProdutoPorID(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<bool>();
            }
            else
            {
                throw new Exception("Algo de errado aconteceu ao chamar a API");
            }
        }

        public async Task<IEnumerable<ProdutoModel>> ListarProdutos()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProdutoModel>>();
        }
    }
}
