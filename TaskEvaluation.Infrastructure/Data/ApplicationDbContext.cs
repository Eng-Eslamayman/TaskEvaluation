using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Data
{
    public class ApplicationDbContext: IdentityDbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EvaluationGrade> EvalutionGrades { get; set;}
        public DbSet<Group> Groups { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

			foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
		    .SelectMany(e => e.GetForeignKeys()))
			{
				foreignKey.DeleteBehavior = DeleteBehavior.SetNull;
			}
		}
    }
}
