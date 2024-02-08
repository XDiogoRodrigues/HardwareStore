using HardwareStore.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HardwareStore.Controllers
{
	public class CategoriaController : Controller
	{
		private readonly IRepositorioCategoria _repositorioCategoria;

		public CategoriaController(IRepositorioCategoria repositorioCategoria)
		{
			_repositorioCategoria = repositorioCategoria;
		}

		public IActionResult ListaDeCategoria()
		{
			var categorias = _repositorioCategoria.Categorias;
			return View(categorias);
		}
	}
}
