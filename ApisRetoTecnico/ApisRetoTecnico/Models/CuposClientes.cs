using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class CuposClientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCupo { get; set; }

        [Required(ErrorMessage = "El Cliente es obligatorio ")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El Cupo es obligatorio ")]
        public decimal Cupo { get; set; }
    }
}
