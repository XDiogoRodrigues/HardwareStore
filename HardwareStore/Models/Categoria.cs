using System.ComponentModel.DataAnnotations;

namespace HardwareStore.Models;

public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [Display(Name = "Nome da categoria")]
    [StringLength(300, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
    public string Nome{ get; set; }

	[Required]
	[Display(Name = "Descrição da categoria")]
	[StringLength(300, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
    public string Descricao { get; set; }

}
