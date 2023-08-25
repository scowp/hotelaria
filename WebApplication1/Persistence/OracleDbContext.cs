using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Hospede> Hospede { get; set; }
        public DbSet<Hospede> Pagamento { get; set; }
        public DbSet<Hospede> Quarto { get; set; }
        public DbSet<Hospede> Reserva { get; set; }
        public DbSet<Hospede> TipoQuarto { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }
    }
}
