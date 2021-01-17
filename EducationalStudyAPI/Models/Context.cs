using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalStudyAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Completlocalizationschoolstudy> completlocalizationschoolstudies { get; set; }
        public DbSet<Queryedustudyinperiod> queryedustudyinperiods { get; set; }
        public DbSet<Studentdatainschoolstudy> studentdatainschoolstudies { get; set; }
        public DbSet<Schoolstudiesforauthproj> schoolstudiesforauthprojs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}