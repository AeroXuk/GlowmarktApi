using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDevice
	{
		/// <summary>Get a user's devices</summary>
		public async Task<string> GetDevicesRawAsync()
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync("device");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find Device by ID</summary>
		public async Task<string> GetDeviceRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"device/{id}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>This call can be used to see whether a gateway device is sending packets to the Glow Platform (i.e. via WiFi).</summary>
		public async Task<string> GetDeviceStatusRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"device/{id}/status");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
