using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskEvaluation.Core.Entities.Business
{
    public class Group: BaseModel
    {
		[Required(ErrorMessage = Errors.RequiredField)]

		public string Title { get; set; } = null!;
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<Student>? Students { get; set; }

    }
}
