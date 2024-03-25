﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.General;

namespace TaskEvaluation.Core.Entities.Business
{
    public class Solution : BaseModel
    {
        public string SolutionFile { get; set; } = null!;
        public string? Notes { get; set; }
        public int? GradeId { get; set; }
        public int? StudentId { get; set; }
        public int? AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }
        public Student? Student { get; set; }
    }
}