using LojaPlatinaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaPlatinaMVC.Data
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
