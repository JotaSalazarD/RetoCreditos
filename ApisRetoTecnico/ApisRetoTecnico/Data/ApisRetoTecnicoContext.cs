using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApisRetoTecnico.Models
{
    public class ApisRetoTecnicoContext : DbContext
    {
        public ApisRetoTecnicoContext (DbContextOptions<ApisRetoTecnicoContext> options)
            : base(options)
        {
        }

        public DbSet<ApisRetoTecnico.Models.TiposIdentificacion> TiposIdentificacion { get; set; }
    }
}
