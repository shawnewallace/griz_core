using System;
using NUnit.Framework;

namespace Griz.Core.Tests.Unit.DateTimeOverriderTests
{
	[TestFixture]
	public class ConstructorTests
	{
		[Test]
		public void it_updates_date_time_helper()
		{
			var notRealDate = new DateTime(1995, 8, 26);
			Assert.AreNotEqual(notRealDate, DateTimeHelper.Now);
			
			using (var overrider = new DateTimeOverrider(notRealDate))
			{
				var result = DateTimeHelper.Now;

				Assert.AreEqual(notRealDate, result);
			}
		}

		[Test]
		public void it_resets_when_disposed()
		{
			var notRealDate = new DateTime(1995, 8, 26);

			using (var overrider = new DateTimeOverrider(notRealDate))
			{
				var result = DateTimeHelper.Now;

				Assert.AreEqual(notRealDate, result);
			}
			Assert.AreNotEqual(notRealDate, DateTimeHelper.Now);
		}
	}
}
