using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FichaCadastroAPI.Model
{
    public class FichaModel
    {
        [Table("Ficha")]
        public class FichaModel
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Column(TypeName = "VARCHAR"), StringLength(250), Required]
            public string Nome { get; set; }
            [Column(TypeName = "VARCHAR"), StringLength(100), Required]
            public string Email { get; set; }
            public DateTime DataNascimento { get; set; }
        }
    }
}
