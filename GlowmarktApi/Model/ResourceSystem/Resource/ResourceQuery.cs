using Newtonsoft.Json;
using System;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceQuery : JsonModelBase
	{
		[JsonProperty("from")]
		public DateTimeOffset From { get; }

		[JsonProperty("to")]
		public DateTimeOffset To { get; }

		[JsonProperty("period")]
		public ResourcePeriod Period { get; }

		[JsonProperty("function")]
		public string Function { get; }
	}
}
