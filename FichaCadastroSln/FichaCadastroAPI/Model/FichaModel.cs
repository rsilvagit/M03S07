﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FichaCadastroAPI.Model
{
    [Table("Ficha")]
    public class FichaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
