using Glowmarkt.Model.ResourceSystem.Resource;
using System;
using System.Collections.Generic;

namespace Glowmarkt.Api
{
	public partial class ResourceSystemResource
	{
		// Sync
		public List<ResourceGetResourcesResponse> GetResources()
		{
			var reply = GetResourcesAsync();
			reply.Wait();
			return reply.Result;
		}

		public void GetResource(Guid id) => throw new NotImplementedException();

		//public ResourceSystemResourceGetResourceReadingsResponse GetResourceReadings(Guid id, DateTimeOffset from, DateTimeOffset to, ResourceSystemResourcePeriod period, string function = "sum", int offset = 0, bool nulls = true)
		//{
		//	var reply = GetResourceReadingsAsync(id, from, to, period, function, offset, nulls);
		//	reply.Wait();
		//	return reply.Result;
		//}

		public ResourceGetResourceReadingsResponse GetResourceReadings(Guid id, DateTimeOffset from, DateTimeOffset to, string period, string function = "sum", int offset = 0, bool nulls = true)
		{
			var reply = GetResourceReadingsAsync(id, from, to, period, function, offset, nulls);
			reply.Wait();
			return reply.Result;
		}

		public void GetResourceCurrentReading(Guid id) => throw new NotImplementedException();

		public void GetResourceFirstAvailable(Guid id) => throw new NotImplementedException();

		public void GetResourceLastAvailable(Guid id) => throw new NotImplementedException();

		public void GetResourceMeterRead(Guid id) => throw new NotImplementedException();

		public void GetResourceTariff(Guid id) => throw new NotImplementedException();

		public void GetResourceCatchup(Guid id) => throw new NotImplementedException();
	}
}
