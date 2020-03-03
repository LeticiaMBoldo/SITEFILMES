using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteFilmes.Models
{
    [Table("TipoAtuacao")]
    public class TipoAtuacao
    {
        [Key]
        public int idTipoAtuacao { get; set; }

        [Display(Name = "Nome do Tipo de Atuação")]
        [StringLength(50, ErrorMessage = "O NOME DO TIPO DE ATUAÇÃO DEVE TER NO MÁXIMO DE 50 CARACTERES")]
        [Required(ErrorMessage = "O NOME DO TIPO DE ATUAÇÃO É OBRIGATÓRIO")]
        public string nomeTipoAtuacao { get; set; }
    }
}
