using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Griz.Core.Tests.Unit.DateTimeHelperTests
{
	[TestFixture]
	public class NowTests
	{
		[Test]
		public void it_returns_current_time()
		{
			var result = DateTimeHelper.Now;

			Assert.NotNull(result);
		}

		[Test]
		public void it_returns_the_overridden_value_if_specified()
		{
			var overridden = new DateTime(1995, 08, 26);
			DateTimeHelper.OverridenDateTime = overridden;
			
			Assert.AreEqual(overridden, DateTimeHelper.Now);
		}
	}
}
