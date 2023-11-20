using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Data  // Removed semicolon here
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<Humano> Humanos { get; set; }
    }
}
