using Microsoft.EntityFrameworkCore;
using Platina.Models;

namespace Platina.Dados
{
    public class AplicacaoDbContext : DbContext
    {
        public AplicacaoDbContext(DbContextOptions<AplicacaoDbContext> options)
            : base(options)
        {

        }
        public DbSet<Categoria> categorias { get; set; }
    }
}
