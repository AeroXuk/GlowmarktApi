using Glowmarkt.Model.ResourceSystem.Resource;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Glowmarkt
{
	internal class ResourceSystemResourceDataConverter : JsonConverter<ResourceData>
	{
		public override void WriteJson(JsonWriter writer, ResourceData value, JsonSerializer serializer)
		{
			if (value.Data != null)
			{
				writer.WriteStartArray();
				foreach (ResourceDataPoint data in value)
				{
					writer.WriteStartArray();
					writer.WriteValue(data.TimeStamp.ToUnixTimeSeconds());
					writer.WriteValue(data.Value);
					writer.WriteEndArray();
				}
				writer.WriteEndArray();
			}
		}

		public override ResourceData ReadJson(JsonReader reader, Type objectType, ResourceData existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			ResourceData resourceDatas = new ResourceData();
			if (reader.TokenType == JsonToken.StartArray)
			{
				reader.Read();
				do
				{
					switch (reader.TokenType)
					{
						case JsonToken.StartArray:
							var array = JArray.Load(reader);
							resourceDatas.Add(new ResourceDataPoint(DateTimeOffset.FromUnixTimeSeconds((long)array[0]), (double)array[1]));
							break;
						default:
							break;
					}
				} while (reader.TokenType != JsonToken.EndArray && reader.Read());
			}
			else if (reader.TokenType == JsonToken.StartObject)
			{

			}
			return resourceDatas;
		}
	}
}
