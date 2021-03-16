using Glowmarkt.Model.UserSystem.Authentication;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public async Task<string> PostAuthenticationRawAsync(string username, string password)
			=> await PostAuthenticationRawAsync(new AuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public async Task<string> PostAuthenticationRawAsync(AuthenticationPostAuthenticationRequest request)
		{
			HttpResponseMessage response = await Client.HttpClient.TruePostAsJsonAsync("auth", request);
			response.EnsureSuccessStatusCode();
			return SaveToken(await response.Content.ReadAsStringAsync()); ;
		}

		private string SaveToken(string response)
		{
			_ = SaveToken(JsonConvert.DeserializeObject<AuthenticationPostAuthenticationResponse>(response));
			return response;
		}
	}
}
