﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Configurations
{
    public class EvaluationGradeConfiguration : IEntityTypeConfiguration<EvaluationGrade>
    {
        public void Configure(EntityTypeBuilder<EvaluationGrade> builder)
        {

            builder.HasMany(g => g.Solutions)
               .WithOne(s => s.EvaluationGrade)
               .HasForeignKey(s => s.EvaluationGradeId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
