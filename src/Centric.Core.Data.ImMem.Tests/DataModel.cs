using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centric.Core.Data.ImMem.Tests
{

	public class DataModel : IEntity<int>
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
