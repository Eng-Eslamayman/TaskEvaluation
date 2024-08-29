using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Core.Entities.DTOs
{
    public class CourseDTO: BaseModelDTO
	{
		public string Title { get; set; } = null!;
        public bool IsCompleted { get; set; } = false;      
    }
}
