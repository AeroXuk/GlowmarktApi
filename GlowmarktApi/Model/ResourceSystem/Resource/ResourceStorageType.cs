using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceStorageType : JsonModelBase
	{
		[JsonProperty("type")]
		public string Type { get; }

		[JsonProperty("sampling")]
		public string Sampling { get; }

		[JsonProperty("start")]
		public DateTimeOffset Start { get; }
		
		[JsonProperty("fields")]
		public List<ResourceStorageTypeFields> Fields { get; }
	}
}
