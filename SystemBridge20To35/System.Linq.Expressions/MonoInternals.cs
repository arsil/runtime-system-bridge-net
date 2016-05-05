using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	static class EmptyOf<T>
	{
		public static readonly T[] Instance = new T[0];
	}

	static class ReadOnlyCollectionOf<T>
	{
		public static readonly ReadOnlyCollection<T> Empty = new ReadOnlyCollection<T>(EmptyOf<T>.Instance);
	}
}
