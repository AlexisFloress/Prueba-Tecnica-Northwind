using Microsoft.EntityFrameworkCore;
using NorthWind.Modelos;

namespace NorthWind.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Agregar todas las entidades
        public DbSet<Cliente> Cliente { get; set; }

    }
}
