using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApisRetoTecnico.Models
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El Tipo es obligatorio ")]
        public int IdTipoIdentificacion { get; set; }

        [Required(ErrorMessage = "El Numero de Identificacion es obligatorio ")]
        public int NroIdentificacion { get; set; }

        [Required(ErrorMessage = "Los nombres son obligatorios ")]
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "El nombre debe ser máximo de 200 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Apellidos es obligatorio ")]
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "Los Apellidos deben ser máximo de 200 caracteres")]
        public string Apellidos { get; set; }

        
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "El nùmero de celular debe ser máximo de 50 caracteres")]
        public string Celular { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "El correo electrónico es máximo de 200 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio ")]
        public int IdDepartamento { get; set; }

        [Required(ErrorMessage = "El Municipio es obligatorio ")]
        public int IdMunicipio { get; set; }


    }
}
