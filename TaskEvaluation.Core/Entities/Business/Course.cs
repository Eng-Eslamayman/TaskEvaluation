using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Entities.Business
{
    public class Course : BaseModel
    {
		[Required(ErrorMessage = Errors.RequiredField)]

		public string Title { get; set; } = null!;
        public bool IsCompleted { get; set; } = false;
        public ICollection<Group>? Groups { get; set; }
    }
}
