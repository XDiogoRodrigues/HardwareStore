using HardwareStore.Models;

namespace HardwareStore.Repository.Interfaces;

public interface IRepositorioProduto
{
	IEnumerable<Produto> Produtos { get; }
	IEnumerable<Produto> GetProdutosFabricanteNome(string fabricante);
	Produto GetProdutoPeloNome(string nomeProduto);

}
