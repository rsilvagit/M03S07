using FichaCadastroAPI.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichaCadastroAPI.Model
{
    [Table("Detalhe")]
    public class DetalheModel : RelacionalBase
    {
       
        [Column(TypeName ="VARCHAR"), Required, StringLength(500)]
        public string Feedback { get; set; }
        [Required]
        public int Nota { get; set; }
        [Required]
        public bool Situacao { get; set; }
        [Required]
        public FichaModel FichaModel { get; set; }
    }
}
