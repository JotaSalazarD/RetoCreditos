using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApisRetoTecnicoTest.Config;

namespace ApisRetoCreditosTest
{
    [TestClass]
    public class PruebasCreditos
    {
        [TestMethod]
        public void PostTiposIdentificacion()
        {
            var context = ApplicationDbContextInMemory.Get();

            string TipoIdentificacion = "CC";
            string NombreIdentificacion = "Cédula";

            context.TiposIdentificacion.Add(new ApisRetoTecnico.Models.TiposIdentificacion
            {
                TipoIdentificacion = TipoIdentificacion,
                NombreIdentificacion = NombreIdentificacion

            });

            context.SaveChanges();

        }

        [TestMethod]
        public void PostMunicipios()
        {
            var context = ApplicationDbContextInMemory.Get();

            int iddepartamento = 1;
            string codmunicipio = "05001";
            string nombremunicipio = "Medellin";

            context.Municipios.Add(new ApisRetoTecnico.Models.Municipios
            {
                IdDepartamento = iddepartamento,
                CodMunicipio = codmunicipio,
                NombreMunicipio = nombremunicipio
            });

            context.SaveChanges();
        }

        [TestMethod]
        public void PostPlazos()
        {
            var context = ApplicationDbContextInMemory.Get();

            decimal desde = 100000;
            decimal hasta = 200000;
            int plazo = 1;

            context.Plazos.Add(new ApisRetoTecnico.Models.Plazos
            {
                Desde = desde,
                Hasta = hasta,
                Plazo = plazo
            });


            context.SaveChanges();
        }

        [TestMethod]
        public void PostDepartamentos()
        {
            var context = ApplicationDbContextInMemory.Get();

            
            string coddepartamento = "05";
            string nombredepartamento = "Antioquia";

            context.Departamentos.Add(new ApisRetoTecnico.Models.Departamentos
            {
                
                CodDepartamento = coddepartamento,
                NombreDepartamento = nombredepartamento
            });

            context.SaveChanges();
        }

        [TestMethod]
        public void PostCuposClientes()
        {
            var context = ApplicationDbContextInMemory.Get();

            int idcliente = 1;
            decimal cupo = 200000;


            context.CuposClientes.Add(new ApisRetoTecnico.Models.CuposClientes
            {

                IdCliente = idcliente,
                Cupo = cupo
            });

            context.SaveChanges();


        }

        public void  PostCreditos()
        {
            var context = ApplicationDbContextInMemory.Get();

            decimal valorcapital = 200000;
            int plazo = 1;
            string frecuencia = "Semestral";
            int idcliente = 1;

            context.Creditos.Add(new ApisRetoTecnico.Models.Creditos
            {

                ValorCapital = valorcapital,
                Plazo = plazo,
                Frecuencia = frecuencia,
                IdCliente = idcliente
            });

            context.SaveChanges();



        }

        public void PostClientes()
        {
            var context = ApplicationDbContextInMemory.Get();

            int idtipoidentificacion = 1;
            int nroidentificacion = 1;
            string nombres = "Nombre prueba";
            string apellidos = "Apellido prueba";
            string celuar = "3109767";
            string email = "prueba@hotmail.com";
            int iddepartamento = 1;
            int idmunicipio = 1;
           
            context.Clientes.Add(new ApisRetoTecnico.Models.Clientes
            {

                IdTipoIdentificacion = idtipoidentificacion,
                NroIdentificacion = nroidentificacion,
                Nombres = nombres,
                Apellidos = apellidos,
                Celular =celuar,
                Email=email,
                IdDepartamento = iddepartamento,
                IdMunicipio =idmunicipio
            });

            context.SaveChanges();

        }



    }
}
