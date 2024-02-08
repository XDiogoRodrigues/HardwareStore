using HardwareStore.Context;
using HardwareStore.Models;
using HardwareStore.Repository.Interfaces;

namespace HardwareStore.Repository
{
	public class RepositorioProduto: IRepositorioProduto
	{
		private readonly AppDbContext _context;

		public RepositorioProduto(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Produto> Produtos => _context.Produtos;

		public Produto GetProdutoPeloNome(string nomeProduto)
		{
			return _context.Produtos.FirstOrDefault(p => p.Nome == nomeProduto);
		}

		public IEnumerable<Produto> GetProdutosFabricanteNome(string fabricante)
		{
			return _context.Produtos.Where(p => p.Fabricante == fabricante);
		}
	}
}
