using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Griz.Core;
using Griz.Core.Data.Ef;
using NUnit.Framework;

namespace EFmpl.Lib.Integration.Tests
{
	public class Thing : IEntity<int>
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class TestDbContext : DbContext
	{
		public DbSet<Thing> Profiles { get; set; }
	}

	public class RepositoryTestBase<TContext> where TContext : DbContext
	{
		[TestFixtureSetUp]
		public void SetUp()
		{
			Database.SetInitializer(new DropCreateDatabaseAlways<TContext>());
		}

	}
}
