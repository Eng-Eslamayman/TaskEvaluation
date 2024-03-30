using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Configurations
{
    public class AssignmentConfiguration: IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasMany(a => a.Solutions)
                   .WithOne(a => a.Assignment)
                   .HasForeignKey(s => s.AssignmentId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Group)
                       .WithMany(g => g.Assignments)
                       .HasForeignKey(a => a.GroupId)
                       .IsRequired()
                       .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
