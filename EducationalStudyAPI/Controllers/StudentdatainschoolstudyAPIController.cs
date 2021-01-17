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
        public class StudentdatainschoolstudyAPIController : ControllerBase
        {
            private readonly Context _context;

            public StudentdatainschoolstudyAPIController(Context context)
            {
                _context = context;
            }

            // GET: api/Studentdatainschoolstudy
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Studentdatainschoolstudy>>> Getstudentdatainschoolstudies()
            {
                return await _context.studentdatainschoolstudies.ToListAsync();
            }

            // GET: api/Studentdatainschoolstudy/5
            [HttpGet("{id}")]
            public async Task<IActionResult> GetStudentdatainschoolstudy(int id)
            {
                var studentdatainschoolstudy = await _context.studentdatainschoolstudies.FindAsync(id);

                if (studentdatainschoolstudy == null)
                {
                    return NotFound();
                }

                return Ok(studentdatainschoolstudy);
            }

            // PUT: api/Studentdatainschoolstudy/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutStudentdatainschoolstudy(int id, Studentdatainschoolstudy studentdatainschoolstudy)
            {
                if (id != studentdatainschoolstudy.Id)
                {
                    return BadRequest();
                }

                _context.Entry(studentdatainschoolstudy).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentdatainschoolstudyExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Ok(studentdatainschoolstudy);
            }

            // POST: api/Studentdatainschoolstudy
            [HttpPost]
            public async Task<IActionResult> PostStudentdatainschoolstudy(Studentdatainschoolstudy studentdatainschoolstudy)
            {
                _context.studentdatainschoolstudies.Add(studentdatainschoolstudy);
                await _context.SaveChangesAsync();

                return Ok(studentdatainschoolstudy);
            }

            // DELETE: api/studentdatainschoolstudies/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteStudentdatainschoolstudy(int id)
            {
                var studentdatainschoolstudy = await _context.studentdatainschoolstudies.FindAsync(id);
                if (studentdatainschoolstudy == null)
                {
                    return NotFound();
                }

                _context.studentdatainschoolstudies.Remove(studentdatainschoolstudy);
                await _context.SaveChangesAsync();

                return Ok(studentdatainschoolstudy);
            }

            private bool StudentdatainschoolstudyExists(int id)
            {
                return _context.studentdatainschoolstudies.Any(e => e.Id == id);
            }



            [HttpPost("Search")]
           public async Task<IActionResult> Get(Studentdatainschoolstudy studentdatainschoolstudy = null)
                {
                    var result = _context.studentdatainschoolstudies.AsQueryable();

                    if (studentdatainschoolstudy != null)
                    {
                           if(studentdatainschoolstudy.BuildingCode.HasValue)
result = result.Where(a => a.BuildingCode == studentdatainschoolstudy.BuildingCode);
if(studentdatainschoolstudy.LandPieceCode.HasValue)
result = result.Where(a => a.LandPieceCode == studentdatainschoolstudy.LandPieceCode);
if (!string.IsNullOrEmpty(studentdatainschoolstudy.StudentsNumber))
result = result.Where(a => a.StudentsNumber == studentdatainschoolstudy.StudentsNumber);
if (!string.IsNullOrEmpty(studentdatainschoolstudy.PeriodName))
result = result.Where(a => a.PeriodName == studentdatainschoolstudy.PeriodName);
if (!string.IsNullOrEmpty(studentdatainschoolstudy.PeriodNumber))
result = result.Where(a => a.PeriodNumber == studentdatainschoolstudy.PeriodNumber);
if(studentdatainschoolstudy.StudyDate!= null)
result = result.Where(a => a.StudyDate == studentdatainschoolstudy.StudyDate);
 
                    }       


              if (result == null)
               {
                   return NotFound();
               }

               return Ok(await result.ToListAsync());
           }




    }
}
