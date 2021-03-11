using Glowmarkt.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public async Task<UserSystemAuthenticationPostAuthenticationResponse> PostAuthenticationAsync(string username, string password)
			=> await PostAuthenticationAsync(new UserSystemAuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public async Task<UserSystemAuthenticationPostAuthenticationResponse> PostAuthenticationAsync(UserSystemAuthenticationPostAuthenticationRequest request)
		{
			HttpResponseMessage response = await Client.HttpClient.TruePostAsJsonAsync("auth", request);
			response.EnsureSuccessStatusCode();
			return SaveToken(await response.Content.ReadAsAsync<UserSystemAuthenticationPostAuthenticationResponse>());
		}

		private UserSystemAuthenticationPostAuthenticationResponse SaveToken(UserSystemAuthenticationPostAuthenticationResponse response)
		{
			Client.Token = response.Token;
			return response;
		}
	}
}
