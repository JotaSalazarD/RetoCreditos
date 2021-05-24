using System;
using System.Collections.Generic;
using System.Text;
using ApisRetoTecnico;
using ApisRetoTecnico.Models;
using Microsoft.EntityFrameworkCore;

namespace ApisRetoTecnicoTest.Config
{
   public static  class ApplicationDbContextInMemory
    {
        public static ApisRetoTecnicoContext Get()
        {
             var options = new DbContextOptionsBuilder<ApisRetoTecnicoContext>()
                .UseInMemoryDatabase(databaseName: $"RETO.Db")
                    .Options;

            return new ApisRetoTecnicoContext(options);

        }



    }
}
