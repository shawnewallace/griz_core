using System.Data.Entity;
using Centric.Core;

namespace Centric.Core.Data.Ef
{
	public interface IEfUnitOfWork : IUnitOfWork
	{
		DbContext Context { get; set; }
	}

	public class EfUnitOfWork : IEfUnitOfWork
	{
		public DbContext Context { get; set; }
		public EfUnitOfWork() { }
		public EfUnitOfWork(DbContext context) { Context = context; }
		public void Commit() { Context.SaveChanges(); }
		public void Dispose() { Context.Dispose(); }

		public bool LazyLoadingEnabled
		{
			get { return Context.Configuration.LazyLoadingEnabled; }
			set { Context.Configuration.LazyLoadingEnabled = value; }
		}
	}
}
