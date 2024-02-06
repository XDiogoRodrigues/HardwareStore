using HardwareStore.Context;
using HardwareStore.Models;
using HardwareStore.Repository.Interfaces;

namespace HardwareStore.Repository;

public class RepositorioCategoria: IRepositorioCategoria
{
	private readonly AppDbContext _context;

	public RepositorioCategoria(AppDbContext context)
	{
		_context = context;
	}

	public IEnumerable<Categoria> Categorias => _context.Categorias;
}
