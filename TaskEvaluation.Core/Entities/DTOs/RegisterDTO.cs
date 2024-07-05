using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Entities.DTOs
{
	public class RegisterDTO
	{
		[MaxLength(50)]
		public string? UserName { get; set; } = null;	
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[RegularExpression(RegexPatterns.MobileNumber, ErrorMessage = Errors.MobileNumber)]
		public string MobileNumber { get; set; } = null!;
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

	}
}
