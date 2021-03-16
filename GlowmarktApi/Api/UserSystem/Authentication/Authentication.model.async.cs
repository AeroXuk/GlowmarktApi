using Glowmarkt.Model.UserSystem.Authentication;
using System.Net.Http;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public async Task<AuthenticationPostAuthenticationResponse> PostAuthenticationAsync(string username, string password)
			=> await PostAuthenticationAsync(new AuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public async Task<AuthenticationPostAuthenticationResponse> PostAuthenticationAsync(AuthenticationPostAuthenticationRequest request)
		{
			HttpResponseMessage response = await Client.HttpClient.TruePostAsJsonAsync("auth", request);
			response.EnsureSuccessStatusCode();
			return SaveToken(await response.Content.ReadAsAsync<AuthenticationPostAuthenticationResponse>());
		}

		private AuthenticationPostAuthenticationResponse SaveToken(AuthenticationPostAuthenticationResponse response)
		{
			Client.Token = response.Token;
			return response;
		}
	}
}
