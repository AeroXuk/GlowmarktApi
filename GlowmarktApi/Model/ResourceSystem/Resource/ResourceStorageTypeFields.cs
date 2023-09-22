using Newtonsoft.Json;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceStorageTypeFields : JsonModelBase
	{
		[JsonProperty("fieldName")]
		public string FieldName { get; }

		[JsonProperty("Unit")]
		public string Unit { get; }

		[JsonProperty("datatype")]
		public string Datatype { get; }

		[JsonProperty("negative")]
		public bool Negative { get; }
	}
}
