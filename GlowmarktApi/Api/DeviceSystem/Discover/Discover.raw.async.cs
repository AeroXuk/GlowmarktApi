using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDiscover
	{
		/// <summary>Find device by ID</summary>
		public async Task<string> GetDiscoverRawAsync(string hardwareId)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"discover/{hardwareId}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
