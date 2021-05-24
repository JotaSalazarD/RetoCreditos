using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class Creditos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCredito { get; set; }

        [Required(ErrorMessage = "El Valor es obligatorio ")]
        public decimal ValorCapital { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public  int Plazo { get; set; }

        [Required(ErrorMessage = "El Periodo es obligatorio ")]
        public string Frecuencia { get; set; }

        [Required(ErrorMessage = "El cliente es obligatorio ")]
        public int IdCliente { get; set; }


    }
}
