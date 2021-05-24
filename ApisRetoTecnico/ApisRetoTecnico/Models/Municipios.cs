using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class Municipios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMunicipio { get; set; }


        [Required(ErrorMessage = "El Departamento es obligatorio ")]
        public int IdDepartamento { get; set; }

        [Required(ErrorMessage = "El Código del municipio es obligatorio ")]
        [StringLength(5)]
        [MaxLength(5, ErrorMessage = "El còdigo debe ser máximo de 5 caracteres")]
        public string CodMunicipio { get; set; }

        [Required(ErrorMessage = "El Nombre del municipio es obligatorio ")]
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "El Nombre debe ser máximo de 200 caracteres")]
        public string NombreMunicipio { get; set; }

    }
}
