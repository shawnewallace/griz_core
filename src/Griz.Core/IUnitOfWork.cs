using System;

namespace Griz.Core
{
	public interface IUnitOfWork : IDisposable
	{
		void Commit();
		bool LazyLoadingEnabled { get; set; }
	}
}