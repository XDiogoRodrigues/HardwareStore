using HardwareStore.Models;

namespace HardwareStore.Repository.Interfaces;

public interface IRepositorioCategoria
{
	IEnumerable<Categoria> Categorias { get; }
    
}
