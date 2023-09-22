using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceDataPoint
	{
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTimeOffset TimeStamp { get; }

		public Nullable<double> Value { get; }

		public ResourceDataPoint(DateTimeOffset timeStamp, Nullable<double> value)
		{
			TimeStamp = timeStamp;
			Value = value;
		}
	}
}
