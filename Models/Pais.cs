using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteFilmes.Models
{
    [Table("Pais")]
    public class Pais
    { 
        [Key]
        public int idPais { get; set; }

        [Display(Name = "Nome do Gênero")]
        [StringLength(50, ErrorMessage = "O NOME DO PAÍS DEVE TER NO MAXIMO 50 CARACTERES")]
        [Required(ErrorMessage = "O NOME DO PAÍS É OBRIGATÓRIO")]
        public string nomePais { get; set; }
    }
}
