using Centric.Core.Data.Ef;
using NUnit.Framework;

namespace EFmpl.Lib.Integration.Tests
{
	public class EfRepositoryTests : RepositoryTestBase<TestDbContext>
	{
		[Test]
		public void TheLightsComeOn()
		{
			using (var db = new EfUnitOfWork(new TestDbContext()))
			{
				var repo = new EfRepository<Thing, int>(db);

				var newThing = new Thing {Name = "Thing 1"};
				var result = repo.Create(newThing);

				db.Commit();

				var created = repo.GetById(result.Id);
				Assert.AreEqual(result.Id, created.Id);
			}
		}
	}
}