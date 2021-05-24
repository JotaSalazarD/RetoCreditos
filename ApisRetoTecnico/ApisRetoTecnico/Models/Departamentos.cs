using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class Departamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepartamento { get; set; }

        [StringLength(2)]
        [Required(ErrorMessage = "El código es obligatorio ")]
        [MaxLength(2, ErrorMessage = "El código debe ser máximo de 2 caracteres")]
        public string CodDepartamento { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre es obligatorio ")]
        [MaxLength(100, ErrorMessage = "El nombre debe ser máximo de 100 caracteres")]
        public string NombreDepartamento { get; set; }

    }
}
