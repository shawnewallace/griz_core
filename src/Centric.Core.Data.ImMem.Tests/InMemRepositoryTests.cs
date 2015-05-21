using Griz.Core.Data.InMem;
using NUnit.Framework;

namespace Griz.Core.Data.ImMem.Tests
{
	[TestFixture]
	public class InMemRepositoryTests
	{
		private InMemUnitOfWork _db;
		private InMemRepository<DataModel, int> _repo;

		[SetUp]
		public void SetUp()
		{
			_db = new InMemUnitOfWork();
			_repo = new InMemRepository<DataModel, int>(_db);

			var newThing = new DataModel { Id = 47, Name = "Thing 1" };
			_repo.Create(newThing);

			newThing = new DataModel { Id = 84, Name = "Thing 2" };
			_repo.Create(newThing);

			_db.Commit();
		}

		[TearDown]
		public void TearDown()
		{
			_repo.CleanUp();
		}

		[Test]
		public void ICanInsertAndQuery()
		{
			var created = _repo.GetById(47);
			Assert.AreEqual(47, created.Id);
		}

		[Test]
		public void ThereAreTwoThingsInTheRepo()
		{
			var result = _repo.GetAll();
			Assert.AreEqual(2, result.Count);
		}

		[Test]
		public void UpdateWorks()
		{
			var item = _repo.GetById(47);
			item.Name = "Updated Thing 1 Name";
			_repo.Update(item);

			var result = _repo.GetById(47);
			Assert.AreEqual("Updated Thing 1 Name", result.Name);
		}

		[Test]
		public void DeleteWorks()
		{
			var item = _repo.GetById(47);
			_repo.Delete(item);

			var result = _repo.GetById(47);
			Assert.IsNull(result);
		}
	}
}