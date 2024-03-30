using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Configurations
{
    public class SolutionConfiguration : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.HasOne(sol => sol.Student)
               .WithMany(st => st.Solutions)
               .HasForeignKey(sol => sol.StudentId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
