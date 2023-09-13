using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FichaCadastroAPI.Base;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace FichaCadastroAPI.Model
{
    [Table("Ficha")]
    public class FichaModel : RelacionalBase
    {
       

        [Column(TypeName = "VARCHAR"), StringLength(250), Required]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR"), StringLength(100), Required]
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
        public Collection<DetalheModel> DetalheModels { get; set; }

    }
}
