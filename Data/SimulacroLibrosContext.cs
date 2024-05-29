using Microsoft.EntityFrameworkCore;
using SimulacroLibros.Models;

namespace SimulacroLibros.Data
{
    public class SimulacroLibrosContext : DbContext
    {
        public SimulacroLibrosContext(DbContextOptions<SimulacroLibrosContext> options) : base(options) {}

        public DbSet<Author> Authors { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
    }
}