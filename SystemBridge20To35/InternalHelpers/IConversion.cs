using System;

namespace LinqBridge.InternalHelpers
{
	interface IConversion
	{
		DateTimeOffset? ToDateTimeOffset(string value);
		TimeSpan ToTimeSpan(string s);
		float ToSingle(string s);
		double ToDouble(string s);
	}
}