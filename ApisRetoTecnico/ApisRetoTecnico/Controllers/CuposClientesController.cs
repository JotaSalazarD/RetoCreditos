using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApisRetoTecnico.Models;

namespace ApisRetoTecnico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuposClientesController : ControllerBase
    {
        private readonly ApisRetoTecnicoContext _context;

        public CuposClientesController(ApisRetoTecnicoContext context)
        {
            _context = context;
        }

        // GET: api/CuposClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuposClientes>>> GetCuposClientes()
        {
            return await _context.CuposClientes.ToListAsync();
        }

        // GET: api/CuposClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CuposClientes>> GetCuposClientes(int id)
        {
            var cuposClientes = await _context.CuposClientes.FindAsync(id);

            if (cuposClientes == null)
            {
                return NotFound();
            }

            return cuposClientes;
        }

        // PUT: api/CuposClientes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuposClientes(int id, CuposClientes cuposClientes)
        {
            if (id != cuposClientes.IdCupo)
            {
                return BadRequest();
            }

            _context.Entry(cuposClientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuposClientesExists(id))
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

        // POST: api/CuposClientes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CuposClientes>> PostCuposClientes(CuposClientes cuposClientes)
        {
            _context.CuposClientes.Add(cuposClientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuposClientes", new { id = cuposClientes.IdCupo }, cuposClientes);
        }

        // DELETE: api/CuposClientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CuposClientes>> DeleteCuposClientes(int id)
        {
            var cuposClientes = await _context.CuposClientes.FindAsync(id);
            if (cuposClientes == null)
            {
                return NotFound();
            }

            _context.CuposClientes.Remove(cuposClientes);
            await _context.SaveChangesAsync();

            return cuposClientes;
        }

        private bool CuposClientesExists(int id)
        {
            return _context.CuposClientes.Any(e => e.IdCupo == id);
        }
    }
}
