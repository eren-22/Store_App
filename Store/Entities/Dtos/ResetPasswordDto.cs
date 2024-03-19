using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
	public record ResetPasswordDto
	{
		public String? UserName { get; init; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage ="Password is required !!")]
		public String? Password { get; init; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Confirm Password is required !!")]
		[Compare("Password" , ErrorMessage ="Password and Confirm Password must be match !")]
		public String? ConfirmPassword { get; init; }
		
	}
}
