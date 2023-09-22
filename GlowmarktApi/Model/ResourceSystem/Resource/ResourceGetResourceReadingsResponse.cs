using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public partial class ResourceGetResourceReadingsResponse : JsonModelBase
	{
		[JsonProperty("status")]
		public string Status { get; }

		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("resourceTypeId")]
		public Guid ResourceTypeId { get; }

		[JsonProperty("resourceId")]
		public Guid ResourceId { get; }

		[JsonProperty("classifier")]
		public string Classifier { get; }

		[JsonProperty("data")]
		[JsonConverter(typeof(ResourceSystemResourceDataConverter))]
		public ResourceData Data { get; }

		[JsonProperty("units")]
		public string Units { get; }

		[JsonProperty("query")]
		public ResourceQuery Query { get; }
	}
}
