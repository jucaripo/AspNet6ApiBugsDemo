#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiBugs.Data;
using ApiBugs.Models;

namespace ApiBugs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BugsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Bugs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<bugModel>>> GetBugsDb()
        {
            return await _context.BugsDb.ToListAsync();
        }

        // GET: api/Bugs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<bugModel>> GetbugModel(int id)
        {
            var bugModel = await _context.BugsDb.FindAsync(id);

            if (bugModel == null)
            {
                return NotFound();
            }

            return bugModel;
        }

        // PUT: api/Bugs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutbugModel(int id, bugModel bugModel)
        {
            if (id != bugModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(bugModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!bugModelExists(id))
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

        // POST: api/Bugs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<bugModel>> PostbugModel(bugModel bugModel)
        {
            _context.BugsDb.Add(bugModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetbugModel", new { id = bugModel.ID }, bugModel);
        }

        // DELETE: api/Bugs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletebugModel(int id)
        {
            var bugModel = await _context.BugsDb.FindAsync(id);
            if (bugModel == null)
            {
                return NotFound();
            }

            _context.BugsDb.Remove(bugModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool bugModelExists(int id)
        {
            return _context.BugsDb.Any(e => e.ID == id);
        }
    }
}
