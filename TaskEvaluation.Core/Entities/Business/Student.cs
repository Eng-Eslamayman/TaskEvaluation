using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.General;

namespace TaskEvaluation.Core.Entities.Business
{
    public class Student: BaseModel
    {
        public string FullName { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ProfilePic { get; set; }
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        public ICollection<Solution>? Solutions { get; set; }
    }
}
