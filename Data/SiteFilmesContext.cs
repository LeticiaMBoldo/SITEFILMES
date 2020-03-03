using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteFilmes.Models;

namespace SiteFilmes.Data
{
    public class SiteFilmesContext : DbContext
    {
        public SiteFilmesContext (DbContextOptions<SiteFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<SiteFilmes.Models.Genero> Genero { get; set; }

        public DbSet<SiteFilmes.Models.Pais> Pais { get; set; }

        public DbSet<SiteFilmes.Models.TipoAtuacao> TipoAtuacao { get; set; }

        public DbSet<SiteFilmes.Models.Filme> Filme { get; set; }
    }
}
