namespace Griz.Core
{
	public interface ICommand
	{
		void Execute();
	}

	public interface ICommand<T>
	{
		void Execute(T deviceId);
	}

	public interface ICommandWithReturn<TReturn>
	{
		TReturn Execute();
	}

	public interface ICommandWithReturn<TReturn, TParam>
	{
		TReturn Execute(TParam id);
	}
}