using System;

namespace LinqBridge.InternalHelpers
{
	static class ConversionHelper
	{
		public static DateTimeOffset? ToDateTimeOffset(string value)
		{
			return impl.ToDateTimeOffset(value);
		}

		public static TimeSpan ToTimeSpan(string s)
		{
			return impl.ToTimeSpan(s);
		}

		public static float ToSingle(string s)
		{
			return impl.ToSingle(s);
		}

		public static double ToDouble(string s)
		{
			return impl.ToDouble(s);
		}

		private static readonly IConversion impl
			=  (Type.GetType("Mono.Runtime") != null)
				? (IConversion)new MonoConversion()
				: new NetConversion();
	}
}