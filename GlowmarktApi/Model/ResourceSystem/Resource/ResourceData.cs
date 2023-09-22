using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceData : IEnumerable<ResourceDataPoint>
	{
		public List<ResourceDataPoint> Data = new List<ResourceDataPoint>();

		[JsonProperty("firstTs")]
		public DateTimeOffset FirstTs { get; set; }

		[JsonProperty("lastTs")]
		public DateTimeOffset LastTs { get; set; }

		public IEnumerator<ResourceDataPoint> GetEnumerator()
		{
			return Data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal void Add(ResourceDataPoint resourceData)
		{
			throw new NotImplementedException();
		}
	}
}
