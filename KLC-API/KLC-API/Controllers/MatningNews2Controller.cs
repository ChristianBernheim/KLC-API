    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KLC_API.Models;

namespace KLC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatningNews2Controller : ControllerBase
    {
        private readonly MatningContext _context;

        public MatningNews2Controller(MatningContext context)
        {
            _context = context;
        }

        // GET: api/MatningNews2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatningNews2>>> GetMatningarNews2()
        {
          if (_context.MatningarNews2 == null)
          {
              return NotFound();
          }
            return await _context.MatningarNews2.ToListAsync();
        }

        // GET: api/MatningNews2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatningNews2>> GetMatningNews2(int id)
        {
          if (_context.MatningarNews2 == null)
          {
              return NotFound();
          }
            var matningNews2 = await _context.MatningarNews2.FindAsync(id);

            if (matningNews2 == null)
            {
                return NotFound();
            }

            return matningNews2;
        }

        // DELETE: api/MatningNews2/GetAllFromPatient/5
        //ej testad
        [HttpGet("GetAllFromPatient/{id}")]
        public async Task<ActionResult<List<MatningNews2>>> GetAllFromPatient(int id)
        {
            if (_context.MatningarNews2 == null)
            {
                
                return new List<MatningNews2>();
            }

            List<MatningNews2> matningar = await _context.MatningarNews2.Where((matning) => id == matning.PatientId).ToListAsync();


            if (matningar.FirstOrDefault() == null)
            {
                return NotFound();
            }
            
            return matningar;
        }
        
        
        // PUT: api/MatningNews2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatningNews2(int id, MatningNews2 matningNews2)
        {
            if (id != matningNews2.Id)
            {
                return BadRequest();
            }

            _context.Entry(matningNews2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatningNews2Exists(id))
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

        // POST: api/MatningNews2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MatningNews2>> PostMatningNews2(MatningNews2 matningNews2)
        {
          if (_context.MatningarNews2 == null)
          {
              return Problem("Entity set 'MatningContext.MatningarNews2'  is null.");
          }
            _context.MatningarNews2.Add(matningNews2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatningNews2", new { id = matningNews2.Id }, matningNews2);
        }

        // DELETE: api/MatningNews2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatningNews2(int id)
        {
            if (_context.MatningarNews2 == null)
            {
                return NotFound();
            }
            var matningNews2 = await _context.MatningarNews2.FindAsync(id);
            if (matningNews2 == null)
            {
                return NotFound();
            }

            _context.MatningarNews2.Remove(matningNews2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/MatningNews2/deleteAllFromPatient/5
        //Verkar fungera , woohoo!
        [HttpDelete("deleteAllFromPatient/{id}")]
        public async Task<IActionResult> DeleteAllFromPatient(int id)
        {
            if (_context.MatningarNews2 == null)
            {
                return NotFound();
            }

            List<MatningNews2> matningar = await _context.MatningarNews2.Where((matning) => id == matning.PatientId).ToListAsync();
            

            if (matningar.FirstOrDefault() == null)
            {
                return NotFound();
            }

            _context.MatningarNews2.RemoveRange(matningar);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        //DELETE: api/MatningsNews2/deleteAll
        //ej testad
        [HttpGet("deleteAll")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            if (_context.MatningarNews2 == null)
            {
                return NotFound();
            }

            List<MatningNews2> matningar = await _context.MatningarNews2.ToListAsync();


            if (matningar.FirstOrDefault() == null)
            {
                return NotFound();
            }

            _context.MatningarNews2.RemoveRange(matningar);
            await _context.SaveChangesAsync();

            return Content("All data raderad!");
        }
        // DELETE: api/MatningNews2/deleteLatestFromPatient/5
        //Ej testad
        [HttpDelete("deleteLatestFromPatient/{id}")]
        public async Task<IActionResult> DeleteLatestFromPatient(int id)
        {
            if (_context.MatningarNews2 == null)
            {
                return NotFound();
            }

            List<MatningNews2> matningar = await _context.MatningarNews2.Where((matning) => id == matning.PatientId).ToListAsync();


            if (matningar.FirstOrDefault() == null)
            {
                return NotFound();
            }

            _context.MatningarNews2.Remove(matningar.Last());
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool MatningNews2Exists(int id)
        {
            return (_context.MatningarNews2?.Any(e => e.Id == id)).GetValueOrDefault();
        }



    }
}
