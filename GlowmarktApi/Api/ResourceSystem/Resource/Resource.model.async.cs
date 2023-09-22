using Glowmarkt.Model.ResourceSystem.Resource;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class ResourceSystemResource
	{
		public async Task<List<ResourceGetResourcesResponse>> GetResourcesAsync()
			=> JsonConvert.DeserializeObject<List<ResourceGetResourcesResponse>>(await GetResourcesRawAsync());

		public async Task GetResourceAsync(Guid id) => throw new NotImplementedException();

		//public async Task<ResourceSystemResourceGetResourceReadingsResponse> GetResourceReadingsAsync(Guid id, DateTimeOffset from, DateTimeOffset to, ResourceSystemResourcePeriod period, string function = "sum", int offset = 0, bool nulls = true)
		//	=> JsonConvert.DeserializeObject<ResourceSystemResourceGetResourceReadingsResponse>(await GetResourceReadingsRawAsync(id, from, to, period, function, offset, nulls));

		public async Task<ResourceGetResourceReadingsResponse> GetResourceReadingsAsync(Guid id, DateTimeOffset from, DateTimeOffset to, string period, string function = "sum", int offset = 0, bool nulls = true)
			=> JsonConvert.DeserializeObject<ResourceGetResourceReadingsResponse>(await GetResourceReadingsRawAsync(id, from, to, period, function, offset, nulls));

		public async Task GetResourceCurrentReadingAsync(Guid id) => throw new NotImplementedException();

		public async Task GetResourceFirstAvailableAsync(Guid id) => throw new NotImplementedException();

		public async Task GetResourceLastAvailableAsync(Guid id) => throw new NotImplementedException();

		public async Task GetResourceMeterReadAsync(Guid id) => throw new NotImplementedException();

		public async Task GetResourceTariffAsync(Guid id) => throw new NotImplementedException();

		public async Task GetResourceCatchupAsync(Guid id) => throw new NotImplementedException();
	}
}
