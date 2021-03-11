using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDeviceType
	{
		/// <summary>Find all device types</summary>
		public async Task<string> GetDeviceTypesRawAsync()
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync("devicetype");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find Device Type by ID</summary>
		public async Task<string> GetDeviceTypeRawAsync(string id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"devicetype/{id}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
