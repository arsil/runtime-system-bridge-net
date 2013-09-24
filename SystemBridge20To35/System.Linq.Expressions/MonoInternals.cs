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

	internal static class Syfon
	{
		internal static ReadOnlyCollection<TSource> ToReadOnlyCollection<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
				return ReadOnlyCollectionOf<TSource>.Empty;

			var ro = source as ReadOnlyCollection<TSource>;
			if (ro != null)
				return ro;

			return new ReadOnlyCollection<TSource>(source.ToArray<TSource>());
		}

		static class EmptyOf<T>
		{
			public static readonly T[] Instance = new T[0];
		}
	}

}
