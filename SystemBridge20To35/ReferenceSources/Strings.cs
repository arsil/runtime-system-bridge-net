using System;

namespace System.Linq
{
	static class Strings
	{
		public static string EmptyEnumerable
		{
			get { return "EmptyEnumerable"; }
		}

		public static string NoElements
		{
			get { return "Sequence contains no elements"; }
		}

		public static  string NoMatch
		{
			get { return "Sequence contains no matching element"; }
		}

		public static string MoreThanOneElement
		{
			get { return "Sequence contains more than one element"; }
		}

		public static string MoreThanOneMatch
		{
			get { return "Sequence contains more than one matching element"; }
		}

		public static string NoMethodOnTypeMatchingArguments (object p0, object p1)
		{
			return String.Format ("No method '{0}' on type '{1}' is compatible with the supplied arguments", p0, p1);
		}

		public static string NoMethodOnType (object p0, object p1)
		{
			return String.Format ("No method '{0}' on type '{1}'", p0, p1);;
		}
	}
}