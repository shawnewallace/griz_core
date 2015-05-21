using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Griz.Core
{
	public interface IInteractor
	{
		ICollection<ValidationResult> ErrorMessages { get; set; }
	}
}