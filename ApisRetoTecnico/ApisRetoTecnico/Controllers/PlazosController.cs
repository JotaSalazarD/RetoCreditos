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
    public class PlazosController : ControllerBase
    {
        private readonly ApisRetoTecnicoContext _context;

        public PlazosController(ApisRetoTecnicoContext context)
        {
            _context = context;
        }

        // GET: api/Plazos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plazos>>> GetPlazos()
        {
            return await _context.Plazos.ToListAsync();
        }

        // GET: api/Plazos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plazos>> GetPlazos(int id)
        {
            var plazos = await _context.Plazos.FindAsync(id);

            if (plazos == null)
            {
                return NotFound();
            }

            return plazos;
        }

        // PUT: api/Plazos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlazos(int id, Plazos plazos)
        {
            if (id != plazos.IdPlazo)
            {
                return BadRequest();
            }

            _context.Entry(plazos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlazosExists(id))
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

        // POST: api/Plazos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Plazos>> PostPlazos(Plazos plazos)
        {
            _context.Plazos.Add(plazos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlazos", new { id = plazos.IdPlazo }, plazos);
        }

        // DELETE: api/Plazos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Plazos>> DeletePlazos(int id)
        {
            var plazos = await _context.Plazos.FindAsync(id);
            if (plazos == null)
            {
                return NotFound();
            }

            _context.Plazos.Remove(plazos);
            await _context.SaveChangesAsync();

            return plazos;
        }

        private bool PlazosExists(int id)
        {
            return _context.Plazos.Any(e => e.IdPlazo == id);
        }
    }
}
