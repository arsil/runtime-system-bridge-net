using System;

namespace LinqBridge.InternalHelpers
{
	class MonoConversion : IConversion
	{
		public DateTimeOffset? ToDateTimeOffset(string value)
		{
			return LinqBridge.InternalHelpers.XmlConvert.ToDateTimeOffset(value);
		}

		public TimeSpan ToTimeSpan(string s)
		{
			return LinqBridge.InternalHelpers.XmlConvert.ToTimeSpan(s);
		}

		public float ToSingle(string s)
		{
			return LinqBridge.InternalHelpers.XmlConvert.ToSingle(s);
		}

		public double ToDouble(string s)
		{
			return LinqBridge.InternalHelpers.XmlConvert.ToDouble(s);
		}
	}
}