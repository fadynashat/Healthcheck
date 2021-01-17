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
        public class CompletlocalizationschoolstudyAPIController : ControllerBase
        {
            private readonly Context _context;

            public CompletlocalizationschoolstudyAPIController(Context context)
            {
                _context = context;
            }

            // GET: api/Completlocalizationschoolstudy
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Completlocalizationschoolstudy>>> Getcompletlocalizationschoolstudies()
            {
                return await _context.completlocalizationschoolstudies.ToListAsync();
            }

            // GET: api/Completlocalizationschoolstudy/5
            [HttpGet("{id}")]
            public async Task<IActionResult> GetCompletlocalizationschoolstudy(int id)
            {
                var completlocalizationschoolstudy = await _context.completlocalizationschoolstudies.FindAsync(id);

                if (completlocalizationschoolstudy == null)
                {
                    return NotFound();
                }

                return Ok(completlocalizationschoolstudy);
            }

            // PUT: api/Completlocalizationschoolstudy/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutCompletlocalizationschoolstudy(int id, Completlocalizationschoolstudy completlocalizationschoolstudy)
            {
                if (id != completlocalizationschoolstudy.Id)
                {
                    return BadRequest();
                }

                _context.Entry(completlocalizationschoolstudy).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompletlocalizationschoolstudyExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Ok(completlocalizationschoolstudy);
            }

            // POST: api/Completlocalizationschoolstudy
            [HttpPost]
            public async Task<IActionResult> PostCompletlocalizationschoolstudy(Completlocalizationschoolstudy completlocalizationschoolstudy)
            {
                _context.completlocalizationschoolstudies.Add(completlocalizationschoolstudy);
                await _context.SaveChangesAsync();

                return Ok(completlocalizationschoolstudy);
            }

            // DELETE: api/completlocalizationschoolstudies/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCompletlocalizationschoolstudy(int id)
            {
                var completlocalizationschoolstudy = await _context.completlocalizationschoolstudies.FindAsync(id);
                if (completlocalizationschoolstudy == null)
                {
                    return NotFound();
                }

                _context.completlocalizationschoolstudies.Remove(completlocalizationschoolstudy);
                await _context.SaveChangesAsync();

                return Ok(completlocalizationschoolstudy);
            }

            private bool CompletlocalizationschoolstudyExists(int id)
            {
                return _context.completlocalizationschoolstudies.Any(e => e.Id == id);
            }



            [HttpPost("Search")]
           public async Task<IActionResult> Get(Completlocalizationschoolstudy completlocalizationschoolstudy = null)
                {
                    var result = _context.completlocalizationschoolstudies.AsQueryable();

                    if (completlocalizationschoolstudy != null)
                    {
                           if(completlocalizationschoolstudy.ClassesNumber.HasValue)
result = result.Where(a => a.ClassesNumber == completlocalizationschoolstudy.ClassesNumber);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.NeedAreaPosition))
result = result.Where(a => a.NeedAreaPosition == completlocalizationschoolstudy.NeedAreaPosition);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.NearestPlacesToBuilding))
result = result.Where(a => a.NearestPlacesToBuilding == completlocalizationschoolstudy.NearestPlacesToBuilding);
if(completlocalizationschoolstudy.LandPieceCode.HasValue)
result = result.Where(a => a.LandPieceCode == completlocalizationschoolstudy.LandPieceCode);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.SurrondSchoolsEffects))
result = result.Where(a => a.SurrondSchoolsEffects == completlocalizationschoolstudy.SurrondSchoolsEffects);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.EducationType))
result = result.Where(a => a.EducationType == completlocalizationschoolstudy.EducationType);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.PeriodStatus2))
result = result.Where(a => a.PeriodStatus2 == completlocalizationschoolstudy.PeriodStatus2);
if(completlocalizationschoolstudy.ConfirmedStudentNumber.HasValue)
result = result.Where(a => a.ConfirmedStudentNumber == completlocalizationschoolstudy.ConfirmedStudentNumber);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.StudentType))
result = result.Where(a => a.StudentType == completlocalizationschoolstudy.StudentType);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.RadiusEmiratizationCircle))
result = result.Where(a => a.RadiusEmiratizationCircle == completlocalizationschoolstudy.RadiusEmiratizationCircle);
if(completlocalizationschoolstudy.StudyDate!= null)
result = result.Where(a => a.StudyDate == completlocalizationschoolstudy.StudyDate);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.EducationalPhase))
result = result.Where(a => a.EducationalPhase == completlocalizationschoolstudy.EducationalPhase);
if (!string.IsNullOrEmpty(completlocalizationschoolstudy.SchoolsPosition))
result = result.Where(a => a.SchoolsPosition == completlocalizationschoolstudy.SchoolsPosition);
 
                    }       


              if (result == null)
               {
                   return NotFound();
               }

               return Ok(await result.ToListAsync());
           }




    }
}
