using System;
using System.Xml;

namespace LinqBridge.InternalHelpers
{
	class NetConversion : IConversion
	{
		public DateTimeOffset ToDateTimeOffset(string value)
		{
			return XmlConvert.ToDateTimeOffset(value);
		}

		public TimeSpan ToTimeSpan(string s)
		{
			return XmlConvert.ToTimeSpan(s);
		}

		public float ToSingle(string s)
		{
			return XmlConvert.ToSingle(s);
		}

		public double ToDouble(string s)
		{
			return XmlConvert.ToDouble(s);
		}
	}
}