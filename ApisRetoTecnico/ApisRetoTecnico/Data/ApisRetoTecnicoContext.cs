using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApisRetoTecnico.Models;

namespace ApisRetoTecnico.Models
{
    public class ApisRetoTecnicoContext : DbContext
    {
        public ApisRetoTecnicoContext (DbContextOptions<ApisRetoTecnicoContext> options)
            : base(options)
        {
        }

        public DbSet<ApisRetoTecnico.Models.TiposIdentificacion> TiposIdentificacion { get; set; }

        public DbSet<ApisRetoTecnico.Models.Clientes> Clientes { get; set; }

        public DbSet<ApisRetoTecnico.Models.Plazos> Plazos { get; set; }

        public DbSet<ApisRetoTecnico.Models.Municipios> Municipios { get; set; }
    }
}
