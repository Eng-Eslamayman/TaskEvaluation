using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Core.Entities.Business.Group>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Business.Group> builder)
        {

            builder.HasOne(g => g.Course)
                   .WithMany(c => c.Groups)
                   .HasForeignKey(g => g.CourseId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
