using Microsoft.EntityFrameworkCore;
using ParcialPrograXModelo.Entidades;

namespace ParcialPrograXRepository
{
    public class ParcialDbContext : DbContext
    {

        public ParcialDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<TipoEquipo> TipoEquipos { get; set; }

    }
}
