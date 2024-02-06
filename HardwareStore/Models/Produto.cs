using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HardwareStore.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [Display(Name ="Nome da fabricante")]
    [StringLength(200, MinimumLength = 2, ErrorMessage ="O {0} deve ter no mínimo {1} e no máximo {2}")]
    public string Fabricante { get; set; }

	[Required]
	[Display(Name = "Nome do produto")]
	[StringLength(300, MinimumLength = 2, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
	public string Nome { get; set; }

	[Required]
	[Display(Name = "Descrição do produto")]
	[StringLength(500, MinimumLength = 2, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
	public string Descricao { get; set; }

	[Required]
	[Display(Name = "Preço do produto")]
	[Column(TypeName ="decimal(10,2)")]
	public decimal Preco { get; set; }

	[Required]
	[Display(Name = "Quantidade do produto")]
	public int Quantidade { get; set; }

	[Required]
	[Display(Name = "Url da imagem")]
	public string UrlImage { get; set; }

	[Required]
	[Display(Name = "Url da imagem miniatura")]
	public string UrlImageMiniatura { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }


}
