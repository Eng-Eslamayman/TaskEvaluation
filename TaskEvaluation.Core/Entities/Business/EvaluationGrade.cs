using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.General;

namespace TaskEvaluation.Core.Entities.Business
{
    public class EvaluationGrade : BaseModel
    {
        public string Grade { get; set; } = null!;
        public ICollection<Solution>? Solutions { get; set; }
    }
}
