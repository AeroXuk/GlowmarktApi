using Glowmarkt.Model.UserSystem.Authentication;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public string PostAuthenticationRaw(string username, string password)
			=> PostAuthenticationRaw(new AuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public string PostAuthenticationRaw(AuthenticationPostAuthenticationRequest request)
		{
			var reply = PostAuthenticationRawAsync(request);
			reply.Wait();
			return reply.Result;
		}
	}
}
