using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Infrastructure.Services
{
    public class GradeService : IGradeService
    {
		private readonly IBaseRepository<EvaluationGrade> _evaluationGradeRepository;

		public GradeService(IBaseRepository<EvaluationGrade> evaluationGradeRepository)
		{
			_evaluationGradeRepository = evaluationGradeRepository;
		}

		public async Task<IEnumerable<EvaluationGrade>> GetGradesAsync()
		{
			return await _evaluationGradeRepository.GetAll();
		}
	}
}
