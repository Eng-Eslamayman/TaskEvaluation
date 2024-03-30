using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.General;

namespace TaskEvaluation.Core.Entities.DTOs
{
    public class EvaluationGardeDTO: BaseModel
    {
        public string Grade { get; set; } = null!;
    }
}
