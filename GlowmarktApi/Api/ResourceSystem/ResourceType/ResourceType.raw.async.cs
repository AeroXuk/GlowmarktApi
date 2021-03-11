using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class ResourceSystemResourceType
	{
		/// <summary>Find all resourceTypes</summary>
		public async Task<string> GetResourceTypesRawAsync()
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync("resourcetype");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find resourceType by ID</summary>
		public async Task<string> GetResourceTypeRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resourcetype/{id}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find resources of a specific resource type that belong to a user</summary>
		public async Task<string> GetResourceTypeResourcesRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resourcetype/{id}/resource");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		/// <summary>Find resources of a specific resource type that an application has access to</summary>
		public async Task<string> GetResourceTypeAppResourcesRawAsync(Guid id)
		{
			HttpResponseMessage response = await Client.HttpClient.GetAsync($"resourcetype/{id}/appresource");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
