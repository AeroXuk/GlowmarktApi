using System;

namespace Glowmarkt.Api
{
	public partial class ResourceSystemResource
	{
		/// <summary>Find all resources per user or application</summary>
		public string GetResourcesRaw()
		{
			var reply = GetResourcesRawAsync();
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find resource by ID</summary>
		public string GetResourceRaw(Guid id)
		{
			var reply = GetResourceRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find resource readings</summary>
		public string GetResourceReadingsRaw(Guid id, DateTimeOffset from, DateTimeOffset to, string period, string function = "sum", int offset = 0, bool nulls = true)
		{
			var reply = GetResourceReadingsRawAsync(id, from, to, period, function, offset, nulls);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find the current resource reading.</summary>
		public string GetResourceCurrentReadingRaw(Guid id)
		{
			var reply = GetResourceCurrentReadingRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Get the UTC time of the first available reading</summary>
		public string GetResourceFirstAvailableRaw(Guid id)
		{
			var reply = GetResourceFirstAvailableRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Get the UTC time of the most recent available reading</summary>
		public string GetResourceLastAvailableRaw(Guid id)
		{
			var reply = GetResourceLastAvailableRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Get the meter read of a smart meter</summary>
		public string GetResourceMeterReadRaw(Guid id)
		{
			var reply = GetResourceMeterReadRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find the latest tariff that is being applied to a resource</summary>
		public string GetResourceTariffRaw(Guid id)
		{
			var reply = GetResourceTariffRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Trigger a request to retrieve the latest available readings from the DCC</summary>
		public string GetResourceCatchupRaw(Guid id)
		{
			var reply = GetResourceCatchupRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Count the number of resources per resourceType</summary>
		public string GetResourceCountRaw(Guid userId)
		{
			var reply = GetResourceCountRawAsync(userId);
			reply.Wait();
			return reply.Result;
		}
	}
}
