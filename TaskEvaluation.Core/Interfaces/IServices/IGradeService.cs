using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEvaluation.Core.Interfaces.IServices
{
    public interface IGradeService
    {
        Task<IEnumerable<EvaluationGrade>> GetGradesAsync();
    }
}
