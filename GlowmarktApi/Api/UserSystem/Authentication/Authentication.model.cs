using Glowmarkt.Model.UserSystem.Authentication;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public AuthenticationPostAuthenticationResponse PostAuthentication(string username, string password)
			=> PostAuthentication(new AuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public AuthenticationPostAuthenticationResponse PostAuthentication(AuthenticationPostAuthenticationRequest request)
		{
			var reply = PostAuthenticationAsync(request);
			reply.Wait();
			return reply.Result;
		}
	}
}
