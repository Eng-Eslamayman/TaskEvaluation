﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.General;

namespace TaskEvaluation.Core.Entities.Business
{
    public class Group: BaseModel
    {
        public string Title { get; set; } = null!;
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}