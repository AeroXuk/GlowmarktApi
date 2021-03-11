using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt
{
	internal static class HttpClientExtension
	{
		internal static async Task<HttpResponseMessage> TruePostAsJsonAsync<T>(this HttpClient client, string requestUri, T value)
		{
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUri);
			request.Content = new StringContent(JsonConvert.SerializeObject(value));
			request.Content.Headers.ContentType.CharSet = null;
			request.Content.Headers.ContentType.MediaType = "application/json";
			return await client.SendAsync(request);
		}
	}
}
