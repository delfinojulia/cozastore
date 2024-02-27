using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("ProdutoFoto")]
public class ProdutoFoto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   public int Id { get; set; }   

[Display (Name ="Produto")]
[Required(ErrorMessage = "Por favor, informe o produto")]

public int ProdutoId {get; set;}

   [Required(ErrorMessage = "Por favor, faça o upload da Foto")]  
   [StringLength (300)]
   public string ArquivoFoto { get; set; }

   [Display (Name ="Foto DEstaque?")]
   public bool Destaque {get; set;} = false;
}
