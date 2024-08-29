using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskEvaluation.Core.Entities.DTOs
{
    public class SolutionDTO: BaseModelDTO
	{
		[Required(ErrorMessage = Errors.RequiredField)]
		public string SolutionFile { get; set; } = null!;
        public string? Notes { get; set; }
		
	
		public int? StudentId { get; set; }
		public int? AssignmentId { get; set; }
		public int? GradeId { get; set; }

	}
}
