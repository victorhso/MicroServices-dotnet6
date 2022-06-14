using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoVO>> BuscarPorId(long id)
        {
            var produto = await _repository.BuscarPorId(id);

            if(produto == null)
                return NotFound();

            return Ok(produto);
        }

        /// <summary>
        /// Lista todos os Produtos
        /// </summary>
        /// <returns>Os Produtos</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoVO>>> ListarProdutos()
        {
            var produto = await _repository.Listarprodutos();

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoVO>> CadastrarProduto(ProdutoVO produtoVO)
        {
            if (produtoVO == null)
                return BadRequest();

            var produto = await _repository.Criar(produtoVO);

            return Ok(produto);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutoVO>> AtualizarProduto(ProdutoVO produtoVO)
        {
            if (produtoVO == null)
                return BadRequest();

            var produto = await _repository.Atualizar(produtoVO);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdutoVO>> DeletarProduto(long id)
        {
            var status = await _repository.Deletar(id);

            if (!status)
                return BadRequest();

            return Ok(status);
        }
    }
}
