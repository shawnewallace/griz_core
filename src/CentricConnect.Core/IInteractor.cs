using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CentricConnect.Core
{
	public interface IInteractor
	{
		ICollection<ValidationResult> ErrorMessages { get; set; }
	}
}