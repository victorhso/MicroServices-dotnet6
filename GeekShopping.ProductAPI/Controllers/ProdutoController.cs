using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoVO>>> ListarProdutos()
        {
            var produto = await _repository.Listarprodutos();

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }
    }
}
