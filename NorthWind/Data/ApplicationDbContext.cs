using Microsoft.EntityFrameworkCore;
using NorthWind.Modelos;

namespace NorthWind.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Agregar todas los modelos
        //Aqui se hace la relacion de los modelos con la base de datos
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<WebTracker> WebTracker { get; set; }

    }
}
