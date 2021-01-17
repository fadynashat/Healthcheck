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
        public class QueryedustudyinperiodAPIController : ControllerBase
        {
            private readonly Context _context;

            public QueryedustudyinperiodAPIController(Context context)
            {
                _context = context;
            }

            // GET: api/Queryedustudyinperiod
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Queryedustudyinperiod>>> Getqueryedustudyinperiods()
            {
                return await _context.queryedustudyinperiods.ToListAsync();
            }

            // GET: api/Queryedustudyinperiod/5
            [HttpGet("{id}")]
            public async Task<IActionResult> GetQueryedustudyinperiod(int id)
            {
                var queryedustudyinperiod = await _context.queryedustudyinperiods.FindAsync(id);

                if (queryedustudyinperiod == null)
                {
                    return NotFound();
                }

                return Ok(queryedustudyinperiod);
            }

            // PUT: api/Queryedustudyinperiod/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutQueryedustudyinperiod(int id, Queryedustudyinperiod queryedustudyinperiod)
            {
                if (id != queryedustudyinperiod.Id)
                {
                    return BadRequest();
                }

                _context.Entry(queryedustudyinperiod).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QueryedustudyinperiodExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return Ok(queryedustudyinperiod);
            }

            // POST: api/Queryedustudyinperiod
            [HttpPost]
            public async Task<IActionResult> PostQueryedustudyinperiod(Queryedustudyinperiod queryedustudyinperiod)
            {
                _context.queryedustudyinperiods.Add(queryedustudyinperiod);
                await _context.SaveChangesAsync();

                return Ok(queryedustudyinperiod);
            }

            // DELETE: api/queryedustudyinperiods/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteQueryedustudyinperiod(int id)
            {
                var queryedustudyinperiod = await _context.queryedustudyinperiods.FindAsync(id);
                if (queryedustudyinperiod == null)
                {
                    return NotFound();
                }

                _context.queryedustudyinperiods.Remove(queryedustudyinperiod);
                await _context.SaveChangesAsync();

                return Ok(queryedustudyinperiod);
            }

            private bool QueryedustudyinperiodExists(int id)
            {
                return _context.queryedustudyinperiods.Any(e => e.Id == id);
            }



            [HttpPost("Search")]
           public async Task<IActionResult> Get(Queryedustudyinperiod queryedustudyinperiod = null)
                {
                    var result = _context.queryedustudyinperiods.AsQueryable();

                    if (queryedustudyinperiod != null)
                    {
                           if(queryedustudyinperiod.SchoolArea.HasValue)
result = result.Where(a => a.SchoolArea == queryedustudyinperiod.SchoolArea);
if(queryedustudyinperiod.BuildingCode.HasValue)
result = result.Where(a => a.BuildingCode == queryedustudyinperiod.BuildingCode);
if (!string.IsNullOrEmpty(queryedustudyinperiod.BuildingOwnership))
result = result.Where(a => a.BuildingOwnership == queryedustudyinperiod.BuildingOwnership);
if(queryedustudyinperiod.ClassroomNumber.HasValue)
result = result.Where(a => a.ClassroomNumber == queryedustudyinperiod.ClassroomNumber);
if (!string.IsNullOrEmpty(queryedustudyinperiod.LandPieceCode))
result = result.Where(a => a.LandPieceCode == queryedustudyinperiod.LandPieceCode);
if(queryedustudyinperiod.StudentsNumber.HasValue)
result = result.Where(a => a.StudentsNumber == queryedustudyinperiod.StudentsNumber);
if (!string.IsNullOrEmpty(queryedustudyinperiod.PeriodNumber))
result = result.Where(a => a.PeriodNumber == queryedustudyinperiod.PeriodNumber);
if (!string.IsNullOrEmpty(queryedustudyinperiod.LandOwnership))
result = result.Where(a => a.LandOwnership == queryedustudyinperiod.LandOwnership);
if(queryedustudyinperiod.StudyDate!= null)
result = result.Where(a => a.StudyDate == queryedustudyinperiod.StudyDate);
 
                    }       


              if (result == null)
               {
                   return NotFound();
               }

               return Ok(await result.ToListAsync());
           }




    }
}
