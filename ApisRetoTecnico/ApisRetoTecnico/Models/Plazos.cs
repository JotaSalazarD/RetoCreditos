using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class Plazos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPlazo { get; set; }

        [Required(ErrorMessage = "El campo desde es obligatorio ")]
        public decimal Desde { get; set; }

        [Required(ErrorMessage = "El campo Hasta es obligatorio ")]
        public decimal Hasta { get; set; }

        [Required(ErrorMessage = "El campo Plazo es obligatorio ")]
        public int Plazo { get; set; }

    }
}
