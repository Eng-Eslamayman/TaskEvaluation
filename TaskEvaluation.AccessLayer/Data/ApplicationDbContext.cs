using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.AccessLayer.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EvalutionGrade> EvalutionGrades { get; set;}
        public DbSet<Group> Groups { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
