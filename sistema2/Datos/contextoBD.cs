using Microsoft.EntityFrameworkCore;
using sistema.Models;


namespace sistema.Datos
{
    public class contextoBD  : DbContext
    {
        public contextoBD(DbContextOptions<contextoBD> options):base(options)
        {

        }
                                                                                        
        public DbSet<cita> citas { get; set; }
    }
}
