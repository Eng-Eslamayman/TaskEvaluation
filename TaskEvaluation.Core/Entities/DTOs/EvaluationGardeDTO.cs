﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskEvaluation.Core.Entities.DTOs
{
    public class EvaluationGardeDTO: BaseModelDTO
	{
        public string Grade { get; set; } = null!;
    }
}
