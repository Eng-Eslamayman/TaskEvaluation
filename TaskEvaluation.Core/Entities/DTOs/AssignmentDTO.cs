using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Entities.Filters;
namespace TaskEvaluation.Core.Entities.DTOs
{
    public class AssignmentDTO : BaseModelDTO
    {
		[Required(ErrorMessage = Errors.RequiredField)]
		public string Title { get; set; } = null!;
        public string? Description { get; set; }
        [LaterDate]
        public DateTime? Deadline { get; set; }
		public int? GroupId { get; set; }


	}
}
