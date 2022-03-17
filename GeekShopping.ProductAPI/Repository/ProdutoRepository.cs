using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlContext _context;
        private IMapper _mapper;

        public ProdutoRepository(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoVO>> Listarprodutos()
        {
            List<Produto> produtos = await _context.Produtos.ToListAsync();
            return _mapper.Map<List<ProdutoVO>>(produtos);
        }

        public async Task<ProdutoVO> BuscarPorId(long idProduto)
        {
            Produto produto = await _context.Produtos.Where(p => p.ID == idProduto).FirstOrDefaultAsync();
            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<ProdutoVO> Criar(ProdutoVO produtoVO)
        {
            Produto produto = _mapper.Map<Produto>(produtoVO);
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<ProdutoVO> Atualizar(ProdutoVO produtoVO)
        {
            Produto produto = _mapper.Map<Produto>(produtoVO);
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<bool> Deletar(long idProduto)
        {
            try
            {
                Produto produto = await _context.Produtos.Where(p => p.ID == idProduto).FirstOrDefaultAsync();

                if (produto == null)
                    return false;

                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
