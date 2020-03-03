using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteFilmes.Models
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int idFilme { get; set; }

        public string tituloOriginal { get; set; }

        public string tituloBrasil { get; set; }

        public string sinopse { get; set; }

        public int  duracao { get; set; }

        public DateTime dataEstreia { get; set; }

        //idFilme int not null identity,
        //tituloOriginal varchar(200),
        //tituloBrasil varchar(200),
        //sinopse varchar(8000),
        //duracao int,
        //dataEstreia date,


    }
}
