using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace sistema.Models
{
    public class cita
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora")]
        public DateTime Hora { get; set; }
    }

    public class CitaDbContext : DbContext
    {
        // constructor
        public CitaDbContext ()
        {}
        public DbSet<cita> citas { get; set; }  
    }

}
