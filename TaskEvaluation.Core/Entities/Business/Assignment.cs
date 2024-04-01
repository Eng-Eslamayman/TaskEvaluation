using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Core.Entities.Business
{
    public class Assignment : BaseModel
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? Deadline { get; set; }
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        public ICollection<Solution> Solutions { get; set; }


    }
}
