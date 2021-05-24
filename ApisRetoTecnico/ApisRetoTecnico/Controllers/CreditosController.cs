using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApisRetoTecnico.Models;
using Microsoft.Data.SqlClient;

namespace ApisRetoTecnico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditosController : ControllerBase
    {
        private readonly ApisRetoTecnicoContext _context;

        public CreditosController(ApisRetoTecnicoContext context)
        {
            _context = context;
        }

        // GET: api/Creditos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Creditos>>> GetCreditos()
        {
            return await _context.Creditos.ToListAsync();
        }

        // GET: api/Creditos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Creditos>> GetCreditos(int id)
        {
            var creditos = await _context.Creditos.FindAsync(id);

            if (creditos == null)
            {
                return NotFound();
            }

            return creditos;
        }

        // PUT: api/Creditos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreditos(int id, Creditos creditos)
        {
            if (id != creditos.IdCredito)
            {
                return BadRequest();
            }

            _context.Entry(creditos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Creditos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Creditos>> PostCreditos(Creditos creditos)
        {
         //   _context.Creditos.Add(creditos);
           // await _context.SaveChangesAsync();

            if (ModelState.IsValid)
            {
                SqlConnection conn = (SqlConnection)_context.Database.GetDbConnection();
                SqlCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Sp_CargarCredito";
                cmd.Parameters.Add("@ValorCapital", System.Data.SqlDbType.Int).Value = creditos.ValorCapital;
                cmd.Parameters.Add("@Frecuencia", System.Data.SqlDbType.NVarChar, 20).Value = creditos.Frecuencia;
                cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = creditos.IdCliente;
                cmd.ExecuteNonQuery();
                conn.Close();


            }


            return CreatedAtAction("GetCreditos", new { id = creditos.IdCredito }, creditos);
        }

        // DELETE: api/Creditos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Creditos>> DeleteCreditos(int id)
        {
            var creditos = await _context.Creditos.FindAsync(id);
            if (creditos == null)
            {
                return NotFound();
            }

            _context.Creditos.Remove(creditos);
            await _context.SaveChangesAsync();

            return creditos;
        }

        private bool CreditosExists(int id)
        {
            return _context.Creditos.Any(e => e.IdCredito == id);
        }
    }
}
