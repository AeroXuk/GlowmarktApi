using Newtonsoft.Json;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceDataSourceUnitInfo : JsonModelBase
	{
		[JsonProperty("shid")]
		public string Shid { get; }
	}
}
