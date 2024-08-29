using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Entities.Business
{
    public class EvaluationGrade : BaseModel
    {
		[Required(ErrorMessage = Errors.RequiredField)]

		public string Grade { get; set; } = null!;
        public ICollection<Solution>? Solutions { get; set; }
    }
}
