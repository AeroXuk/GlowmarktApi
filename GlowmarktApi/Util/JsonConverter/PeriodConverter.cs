using Glowmarkt.Model.ResourceSystem.Resource;
using Newtonsoft.Json;
using System;

namespace Glowmarkt
{
	internal class PeriodConverter : JsonConverter<ResourcePeriod>
	{
		public override void WriteJson(JsonWriter writer, ResourcePeriod value, JsonSerializer serializer)
		{
			writer.WriteValue(value.Parameter);
		}

		public override ResourcePeriod ReadJson(JsonReader reader, Type objectType, ResourcePeriod existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return reader.Value as string switch
			{
				"PT1M" => ResourcePeriod.PT1M,
				"PT30M" => ResourcePeriod.PT30M,
				"PT1H" => ResourcePeriod.PT1H,
				"P1D" => ResourcePeriod.P1D,
				"P1W" => ResourcePeriod.P1W,
				"P1M" => ResourcePeriod.P1M,
				"P1Y" => ResourcePeriod.P1Y,
				_ => throw new NotSupportedException()
			};
		}
	}
}
