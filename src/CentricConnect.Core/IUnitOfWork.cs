using System;

namespace Centric.Core
{
	public interface IUnitOfWork : IDisposable
	{
		void Commit();
		bool LazyLoadingEnabled { get; set; }
	}
}