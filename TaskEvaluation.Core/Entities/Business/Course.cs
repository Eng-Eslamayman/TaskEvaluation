using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.General;

namespace TaskEvaluation.Core.Entities.Business
{
    public class Course : BaseModel
    {
        public string Title { get; set; } = null!;
        public bool IsCompleted { get; set; }
        public ICollection<Group>? Groups { get; set; }
    }
}
