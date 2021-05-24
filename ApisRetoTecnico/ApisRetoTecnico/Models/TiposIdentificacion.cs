using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class TiposIdentificacion
    {
        [Key]
        public int IdTipoIdentificacion { get; set; }


        public string TipoIdentificacion { get; set; }


        public string NombreIdentificacion { get; set; }
 

    }
}
