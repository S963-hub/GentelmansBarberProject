using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GentelmansProject.Models;
using GentelmansProject.Data;

namespace BarberShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Berber>>> GetBerbers()
        {
            return await _context.Berbers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Berber>> GetBerber(int id)
        {
            var berber = await _context.Berbers.FindAsync(id);

            if (berber == null)
            {
                return NotFound();
            }

            return berber;
        }

        [HttpPost]
        public async Task<ActionResult<Berber>> CreateBerber(Berber berber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Berbers.Add(berber);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBerber), new { id = berber.Id }, berber);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBerber(int id, Berber berber)
        {
            if (id != berber.Id)
            {
                return BadRequest();
            }

            _context.Entry(berber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BerberExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBerber(int id)
        {
            var berber = await _context.Berbers.FindAsync(id);

            if (berber == null)
            {
                return NotFound();
            }

            _context.Berbers.Remove(berber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BerberExists(int id)
        {
            return _context.Berbers.Any(e => e.Id == id);
        }

       /* [HttpGet("filter-by-price")]
        public async Task<ActionResult<IEnumerable<Berber>>> GetBerbersByPrice([FromQuery] decimal maxPrice)
        {
            var filteredBerbers = await _context.Berbers
                .Where(i => i.Ucret < maxPrice)
                .ToListAsync();

            return Ok(filteredBerbers);
        }*/
    }
}
