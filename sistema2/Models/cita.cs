using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sistema.Models
{
    public class cita
    {
        // Elements

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
}
