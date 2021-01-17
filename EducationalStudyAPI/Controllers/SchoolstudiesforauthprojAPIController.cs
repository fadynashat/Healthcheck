using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducationalStudyAPI.Models;

namespace EducationalStudyAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class SchoolstudiesforauthprojAPIController : ControllerBase
        {
            private readonly Context _context;

            public SchoolstudiesforauthprojAPIController(Context context)
            {
                _context = context;
            }

            // GET: api/Schoolstudiesforauthproj
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Schoolstudiesforauthproj>>> Getschoolstudiesforauthprojs()
            {
                return await _context.schoolstudiesforauthprojs.ToListAsync();
            }

            // GET: api/Schoolstudiesforauthproj/5
            [HttpGet("{id}")]
            public async Task<IActionResult> GetSchoolstudiesforauthproj(int id)
            {
                var schoolstudiesforauthproj = await _context.schoolstudiesforauthprojs.FindAsync(id);

                if (schoolstudiesforauthproj == null)
                {
                    return NotFound();
                }

                return Ok(schoolstudiesforauthproj);
            }

            // PUT: api/Schoolstudiesforauthproj/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutSchoolstudiesforauthproj(int id, Schoolstudiesforauthproj schoolstudiesforauthproj)
            {
                if (id != schoolstudiesforauthproj.Id)
                {
                    return BadRequest();
                }

                _context.Entry(schoolstudiesforauthproj).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolstudiesforauthprojExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Ok(schoolstudiesforauthproj);
            }

            // POST: api/Schoolstudiesforauthproj
            [HttpPost]
            public async Task<IActionResult> PostSchoolstudiesforauthproj(Schoolstudiesforauthproj schoolstudiesforauthproj)
            {
                _context.schoolstudiesforauthprojs.Add(schoolstudiesforauthproj);
                await _context.SaveChangesAsync();

                return Ok(schoolstudiesforauthproj);
            }

            // DELETE: api/schoolstudiesforauthprojs/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteSchoolstudiesforauthproj(int id)
            {
                var schoolstudiesforauthproj = await _context.schoolstudiesforauthprojs.FindAsync(id);
                if (schoolstudiesforauthproj == null)
                {
                    return NotFound();
                }

                _context.schoolstudiesforauthprojs.Remove(schoolstudiesforauthproj);
                await _context.SaveChangesAsync();

                return Ok(schoolstudiesforauthproj);
            }

            private bool SchoolstudiesforauthprojExists(int id)
            {
                return _context.schoolstudiesforauthprojs.Any(e => e.Id == id);
            }



            [HttpPost("Search")]
           public async Task<IActionResult> Get(Schoolstudiesforauthproj schoolstudiesforauthproj = null)
                {
                    var result = _context.schoolstudiesforauthprojs.AsQueryable();

                    if (schoolstudiesforauthproj != null)
                    {
                           if(schoolstudiesforauthproj.LandPieceCode.HasValue)
result = result.Where(a => a.LandPieceCode == schoolstudiesforauthproj.LandPieceCode);
if (!string.IsNullOrEmpty(schoolstudiesforauthproj.PhaseCode))
result = result.Where(a => a.PhaseCode == schoolstudiesforauthproj.PhaseCode);
if(schoolstudiesforauthproj.StudentsNumber.HasValue)
result = result.Where(a => a.StudentsNumber == schoolstudiesforauthproj.StudentsNumber);
if(schoolstudiesforauthproj.StudyDate!= null)
result = result.Where(a => a.StudyDate == schoolstudiesforauthproj.StudyDate);
 
                    }       


              if (result == null)
               {
                   return NotFound();
               }

               return Ok(await result.ToListAsync());
           }




    }
}
