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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoIdentificacion { get; set; }
        

        [StringLength(10)]
        [Required(ErrorMessage = "El Tipo es obligatorio ")]
        [MinLength(1, ErrorMessage = "El tipo debe ser minimo de 1 caracter")]
        [MaxLength(10, ErrorMessage = "El código debe ser máximo de 10 caracteres")]
        public string TipoIdentificacion { get; set; }
      


        [StringLength(50)]
        [Required(ErrorMessage = "El nombre es obligatorio ")]
        [MinLength(1, ErrorMessage = "El nombre debe ser minimo de 1 caracter")]
        [MaxLength(50, ErrorMessage = "El nombre debe ser máximo de 50 caracteres")]
        public string NombreIdentificacion { get; set; }
     

    }
}
