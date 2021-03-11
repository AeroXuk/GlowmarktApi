using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class ResourceSystemResource
	{
		/// <summary>Find all resources per user or application</summary>
		public async Task<string> GetResourcesRawAsync()
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync("resource");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find resource by ID</summary>
		public async Task<string> GetResourceRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find resource readings</summary>
		public async Task<string> GetResourceReadingsRawAsync(Guid id, DateTimeOffset from, DateTimeOffset to, string period, string function = "sum", int offset = 0, bool nulls = true)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/readings?period={period}&function={function}&from={from:s}&to={to:s}&offset={offset}&nulls={nulls:0}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find the current resource reading.</summary>
		public async Task<string> GetResourceCurrentReadingRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/current");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Get the UTC time of the first available reading</summary>
		public async Task<string> GetResourceFirstAvailableRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/first-time");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Get the UTC time of the most recent available reading</summary>
		public async Task<string> GetResourceLastAvailableRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/last-time");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Get the meter read of a smart meter</summary>
		public async Task<string> GetResourceMeterReadRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/meterread");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find the latest tariff that is being applied to a resource</summary>
		public async Task<string> GetResourceTariffRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/tariff");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Trigger a request to retrieve the latest available readings from the DCC</summary>
		public async Task<string> GetResourceCatchupRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resource/{id}/catchup");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Count the number of resources per resourceType</summary>
		public async Task<string> GetResourceCountRawAsync(Guid userId)
		{
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "");
			request.Headers.Add("userId", userId.ToString());
			HttpResponseMessage response = await Client.HttpClient.SendAsync(request);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
