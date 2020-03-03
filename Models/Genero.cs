using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteFilmes.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public int idGenero { get; set; }

        [Display(Name = "Nome do Gênero")]
        [StringLength(50, ErrorMessage = "O NOME DO GENERO DEVE TER NO MAXIMO 50 CARACTERES")]
        [Required(ErrorMessage = "O NOME DO GÊNERO É OBRIGATÓRIO")]
        public string NomeGenero { get; set; }

    }
}
