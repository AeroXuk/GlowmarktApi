using Newtonsoft.Json;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceDataSourceResourceTypeInfo : JsonModelBase
	{
		[JsonProperty("unit")]
		public string Unit { get; }

		[JsonProperty("type")]
		public string Type { get; }
	}
}
