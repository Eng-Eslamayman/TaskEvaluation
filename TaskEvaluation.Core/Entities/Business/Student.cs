
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskEvaluation.Core.Entities.Business
{
    public class Student: BaseModel
    {
		[Required(ErrorMessage = Errors.RequiredField)]
		[MaxLength(100, ErrorMessage = Errors.MaxLength)]
		public string FullName { get; set; } = null!;
		[Display(Name = "Mobile Number")]
		[RegularExpression(RegexPatterns.MobileNumber ,ErrorMessage = Errors.MobileNumber)]
        public string MobileNumber { get; set; } = null!;
		[Display(Name = "Email Address")]
		[MaxLength(100, ErrorMessage = Errors.Email)]
		public string Email { get; set; } = null!;
		[Display(Name = "Profile Picture")]

		public string? ProfilePic { get; set; }
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        public ICollection<Solution>? Solutions { get; set; }
    }
}
