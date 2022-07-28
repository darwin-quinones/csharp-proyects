using Microsoft.EntityFrameworkCore;
using sistema.Models;

namespace sistema.Datos
{
    public class ContextoBd :DbContext // contexto
    {
                                           // clase
        public ContextoBd(DbContextOptions<ContextoBd> options): base(options)
        {

        }
        // nuevo objeto citas
        public DbSet<cita> citas { get; set; }
    }
}
